using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using CsvHelper;
using Rater.Types;
using System.Drawing;
using System.ComponentModel;
namespace Rater.Solution
{
    public partial class MainForm : Form
    {
        private DateTime StartRoundTime;
        private DateTime StartTotalTime;
        public Stopwatch mainStopWatch = new Stopwatch();
        public List<RecordItem> recordItems = new List<RecordItem>();
        private RecordItem currentRecordItem = new RecordItem();
        private Command command = Command.Ready;
        private bool keyPressed = false;
        private bool record = false;
        private bool editSubject = false;
        public BindingList<RecordItem> bindingList;

        private List<CommandButton> commandButtons = new List<CommandButton>()
        {
            new CommandButton(){Name = "W", Command = Command.LookAway},
            new CommandButton(){Name = "A", Command = Command.Familiar},
            new CommandButton(){Name = "S", Command = Command.Switch},
            new CommandButton(){Name = "D", Command = Command.Novel}
        };

        public MainForm()
        {
            InitializeComponent();
            bindingList = new BindingList<RecordItem>(recordItems);
            dgvResult.DataSource = bindingList;

            Dictionary<string, string> comboItems = new Dictionary<string, string>();
            comboItems.Add("1", "1");
            comboItems.Add("2", "2");
            comboItems.Add("3", "3");
            comboItems.Add("4", "4");
            comboItems.Add("5", "5");
            comboItems.Add("6", "6");
            comboItems.Add("7", "7");
            comboItems.Add("8", "8");
            comboItems.Add("9", "9");
            comboItems.Add("10", "10");
            comboItems.Add("11", "11");
            testNumber.DataSource = new BindingSource(comboItems, null);
            testNumber.DisplayMember = "Value";
            testNumber.ValueMember = "Key";

            // Get combobox selection (in handler)
            string value = ((KeyValuePair<string, string>)testNumber.SelectedItem).Value;
        }

        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = subjectId.Text + "_" + subjectAge.Text + "_" + raterName.Text + "_" + testName.Text + "_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
            saveFileDialog.Filter = "Comma-separated values|*.csv";
            saveFileDialog.Title = "Save an Experiment File";
            var result = saveFileDialog.ShowDialog();
            if(saveFileDialog.FileName != null && result == DialogResult.OK)
            {
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                {
                    var csv = new CsvWriter(writer);
                    csv.WriteRecords(recordItems);
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            lbTime.Text = "00:00:00.000";
            bindingList.Clear();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!editSubject)
            {
                e.Handled = true;
                if (keyPressed) return;
                keyPressed = true;
                Debug.WriteLine(e.KeyChar);
                switch (e.KeyChar)
                {
                    case 'a':
                        SetCommand(GetCommandButton("A").Command);
                        panel_A.BackColor = Color.Gainsboro;
                        break;
                    case 'd':
                        SetCommand(GetCommandButton("D").Command);
                        panel_D.BackColor = Color.Gainsboro;
                        break;
                    case 'w':
                        SetCommand(GetCommandButton("W").Command);
                        panel_W.BackColor = Color.Gainsboro;
                        break;
                    case 's':
                        SetCommand(GetCommandButton("S").Command);
                        panel_S.BackColor = Color.Gainsboro;
                        SwitchButton();
                        break;
                    default:
                        SetCommand(Command.None);
                        break;
                }
                UpdatePressButton();
                if (record && command != Command.None)
                {
                    var now = DateTime.UtcNow;
                    if(currentRecordItem.ButtonName == null)
                    {
                        currentRecordItem.ButtonName = command.ToString();
                        currentRecordItem.TestNumber = ((KeyValuePair<string, string>)testNumber.SelectedItem).Value;
                        currentRecordItem.Start = GetTimeDuration(StartTotalTime, now);
                    }
                    else
                    {
                        currentRecordItem.End = GetTimeDuration(StartTotalTime, now);
                        currentRecordItem.Duration = GetTimeDuration(currentRecordItem.Start, currentRecordItem.End);
                        AddRecordItem(currentRecordItem);
                       

                        currentRecordItem = new RecordItem();
                        currentRecordItem.ButtonName = command.ToString();
                        currentRecordItem.TestNumber = ((KeyValuePair<string, string>)testNumber.SelectedItem).Value;
                        currentRecordItem.Start = GetTimeDuration(StartRoundTime, now);

                        
                    }

                    
                }
            }
           
        }

        private void AddRecordItem(RecordItem recordItem)
        {
            bindingList.Add(recordItem);
            dgvResult.FirstDisplayedScrollingRowIndex = bindingList.Count - 1;
            
        }

        private CommandButton GetCommandButton(string name)
        {
            foreach (var button in commandButtons)
            {
                if(button.Name == name)
                return button;
            }
            return null;
            
        }
        private void SwitchButton()
        {
            var aButton = GetCommandButton("A");
            var dButton = GetCommandButton("D");
            aButton.Command = aButton.Command == Command.Familiar?Command.Novel:Command.Familiar;
            dButton.Command = dButton.Command == Command.Novel?Command.Familiar:Command.Novel;
        }
 
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            keyPressed = false;
            ResetButtonColor();
        }

        private void SetCommand(Command command)
        {
            this.command = command;
        }

        private void UpdatePressButton()
        {
            
            if(GetCommandButton("A").Command == Command.Familiar)
            {
                lbCommandA.Text = "Familiar";
            }
            else if (GetCommandButton("A").Command == Command.Novel)
            {
                lbCommandA.Text = "Novel";
            }

            if (GetCommandButton("D").Command == Command.Familiar)
            {
                lbCommandD.Text = "Familiar";
            }
            else if (GetCommandButton("D").Command == Command.Novel)
            {
                lbCommandD.Text = "Novel";
            }

        }

        private void ResetButtonColor()
        {
            panel_A.BackColor = Color.White;
            panel_W.BackColor = Color.White;
            panel_D.BackColor = Color.White;
            panel_S.BackColor = Color.White;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            ToggleRecord();
        }
        private void ToggleRecord()
        {
            DateTime now = DateTime.UtcNow;
            record = !record;
            if (record)
            {
                currentRecordItem = new RecordItem();
                StartRoundTime = now;
                StartTotalTime = now;
                lbTime.Text = "00:00:00.000";
                MainTimer.Start();
                testNumber.Enabled = false;
                btnStart.Text = "Stop Record";
                btnStart.BackColor = Color.Red;
                record = true;
                btnEdit.Enabled = false;
            }
            else
            {

                currentRecordItem.End = GetTimeDuration(StartTotalTime, now);
                currentRecordItem.Duration = GetTimeDuration(currentRecordItem.Start, currentRecordItem.End);
                AddRecordItem(currentRecordItem);


                MainTimer.Stop();
                testNumber.Enabled = true;
                btnStart.Text = "Start Record";
                btnStart.BackColor = SystemColors.Control;
                record = false;
                btnEdit.Enabled = true;
            }
        }
        private TimeSpan GetTimeDuration(DateTime start,DateTime end)
        {
            TimeSpan duration = end - start;
            return new TimeSpan(0, 0, 0, 0, (int)(duration.TotalMilliseconds));
        }
        private TimeSpan GetTimeDuration(TimeSpan start, TimeSpan end)
        {
            TimeSpan duration = end - start;
            return new TimeSpan(0, 0, 0, 0, (int)(duration.TotalMilliseconds));
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            // display time couter
            TimeSpan duration = DateTime.UtcNow - StartTotalTime;
            TimeSpan durationR = new TimeSpan(0,0,0,0, (int)(duration.TotalMilliseconds * timeRatio.Value / 100.0));
            lbTime.Text = durationR.ToString("hh':'mm':'ss'.'fff");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editSubject = !editSubject;
            
            if (!editSubject)
            {
                btnEdit.Text = "Edit";
                subjectId.ReadOnly = true;
                subjectAge.ReadOnly = true;
                raterName.ReadOnly = true;
                testName.ReadOnly = true;
                btnStart.Enabled = true;
            }
            else
            {
                btnEdit.Text = "Save";
                subjectId.ReadOnly = false;
                subjectAge.ReadOnly = false;
                raterName.ReadOnly = false;
                testName.ReadOnly = false;
                btnStart.Enabled = false;
            }
        }
    }
}