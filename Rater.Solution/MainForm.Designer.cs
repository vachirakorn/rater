namespace Rater.Solution
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subjectId = new System.Windows.Forms.TextBox();
            this.raterName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.testName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectAge = new System.Windows.Forms.TextBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel_A = new System.Windows.Forms.Panel();
            this.lb_A = new System.Windows.Forms.Label();
            this.lbCommandA = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel_S = new System.Windows.Forms.Panel();
            this.lb_S = new System.Windows.Forms.Label();
            this.lbCommandS = new System.Windows.Forms.Label();
            this.panel_D = new System.Windows.Forms.Panel();
            this.lb_D = new System.Windows.Forms.Label();
            this.lbCommandD = new System.Windows.Forms.Label();
            this.panel_W = new System.Windows.Forms.Panel();
            this.lb_W = new System.Windows.Forms.Label();
            this.lbCommandW = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.testNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeRatio = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordItemBindingSource)).BeginInit();
            this.panel_A.SuspendLayout();
            this.panel_S.SuspendLayout();
            this.panel_D.SuspendLayout();
            this.panel_W.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rater Name";
            // 
            // subjectId
            // 
            this.subjectId.Location = new System.Drawing.Point(169, 33);
            this.subjectId.Name = "subjectId";
            this.subjectId.ReadOnly = true;
            this.subjectId.Size = new System.Drawing.Size(177, 20);
            this.subjectId.TabIndex = 8;
            // 
            // raterName
            // 
            this.raterName.Location = new System.Drawing.Point(169, 88);
            this.raterName.Name = "raterName";
            this.raterName.ReadOnly = true;
            this.raterName.Size = new System.Drawing.Size(177, 20);
            this.raterName.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.testName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.subjectAge);
            this.groupBox1.Controls.Add(this.raterName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.subjectId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(39, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 205);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Details";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(238, 152);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 30);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // testName
            // 
            this.testName.Location = new System.Drawing.Point(169, 114);
            this.testName.Name = "testName";
            this.testName.ReadOnly = true;
            this.testName.Size = new System.Drawing.Size(177, 20);
            this.testName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Test Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Age";
            // 
            // subjectAge
            // 
            this.subjectAge.Location = new System.Drawing.Point(169, 62);
            this.subjectAge.Name = "subjectAge";
            this.subjectAge.ReadOnly = true;
            this.subjectAge.Size = new System.Drawing.Size(177, 20);
            this.subjectAge.TabIndex = 18;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AutoGenerateColumns = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dgvResult.DataSource = this.recordItemBindingSource;
            this.dgvResult.Location = new System.Drawing.Point(470, 44);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.Size = new System.Drawing.Size(517, 511);
            this.dgvResult.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ButtonName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ButtonName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TestNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "TestNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            dataGridViewCellStyle1.Format = "hh\':\'mm\':\'ss\'.\'fff";
            dataGridViewCellStyle1.NullValue = null;
            this.startDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "End";
            dataGridViewCellStyle2.Format = "hh\':\'mm\':\'ss\'.\'fff";
            this.endDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            dataGridViewCellStyle3.Format = "hh\':\'mm\':\'ss\'.\'fff";
            this.durationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recordItemBindingSource
            // 
            this.recordItemBindingSource.DataSource = typeof(Rater.Types.RecordItem);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(750, 577);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 30);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(879, 577);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Export";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel_A
            // 
            this.panel_A.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_A.BackColor = System.Drawing.Color.White;
            this.panel_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_A.Controls.Add(this.lb_A);
            this.panel_A.Controls.Add(this.lbCommandA);
            this.panel_A.Location = new System.Drawing.Point(119, 202);
            this.panel_A.Name = "panel_A";
            this.panel_A.Size = new System.Drawing.Size(58, 58);
            this.panel_A.TabIndex = 11;
            // 
            // lb_A
            // 
            this.lb_A.AutoSize = true;
            this.lb_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_A.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_A.Location = new System.Drawing.Point(20, 5);
            this.lb_A.Name = "lb_A";
            this.lb_A.Size = new System.Drawing.Size(15, 13);
            this.lb_A.TabIndex = 1;
            this.lb_A.Text = "A";
            // 
            // lbCommandA
            // 
            this.lbCommandA.AutoSize = true;
            this.lbCommandA.Location = new System.Drawing.Point(6, 22);
            this.lbCommandA.Name = "lbCommandA";
            this.lbCommandA.Size = new System.Drawing.Size(42, 13);
            this.lbCommandA.TabIndex = 0;
            this.lbCommandA.Text = "Familiar";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStart.Location = new System.Drawing.Point(116, 283);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 39);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start Record";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // panel_S
            // 
            this.panel_S.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_S.BackColor = System.Drawing.Color.White;
            this.panel_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_S.Controls.Add(this.lb_S);
            this.panel_S.Controls.Add(this.lbCommandS);
            this.panel_S.Location = new System.Drawing.Point(183, 202);
            this.panel_S.Name = "panel_S";
            this.panel_S.Size = new System.Drawing.Size(58, 58);
            this.panel_S.TabIndex = 12;
            // 
            // lb_S
            // 
            this.lb_S.AutoSize = true;
            this.lb_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_S.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_S.Location = new System.Drawing.Point(21, 4);
            this.lb_S.Name = "lb_S";
            this.lb_S.Size = new System.Drawing.Size(15, 13);
            this.lb_S.TabIndex = 1;
            this.lb_S.Text = "S";
            // 
            // lbCommandS
            // 
            this.lbCommandS.AutoSize = true;
            this.lbCommandS.Location = new System.Drawing.Point(9, 22);
            this.lbCommandS.Name = "lbCommandS";
            this.lbCommandS.Size = new System.Drawing.Size(39, 13);
            this.lbCommandS.TabIndex = 0;
            this.lbCommandS.Text = "Switch";
            // 
            // panel_D
            // 
            this.panel_D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_D.BackColor = System.Drawing.Color.White;
            this.panel_D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_D.Controls.Add(this.lb_D);
            this.panel_D.Controls.Add(this.lbCommandD);
            this.panel_D.Location = new System.Drawing.Point(247, 202);
            this.panel_D.Name = "panel_D";
            this.panel_D.Size = new System.Drawing.Size(58, 58);
            this.panel_D.TabIndex = 12;
            // 
            // lb_D
            // 
            this.lb_D.AutoSize = true;
            this.lb_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_D.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_D.Location = new System.Drawing.Point(21, 4);
            this.lb_D.Name = "lb_D";
            this.lb_D.Size = new System.Drawing.Size(16, 13);
            this.lb_D.TabIndex = 1;
            this.lb_D.Text = "D";
            // 
            // lbCommandD
            // 
            this.lbCommandD.AutoSize = true;
            this.lbCommandD.Location = new System.Drawing.Point(11, 22);
            this.lbCommandD.Name = "lbCommandD";
            this.lbCommandD.Size = new System.Drawing.Size(35, 13);
            this.lbCommandD.TabIndex = 0;
            this.lbCommandD.Text = "Novel";
            // 
            // panel_W
            // 
            this.panel_W.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_W.BackColor = System.Drawing.Color.White;
            this.panel_W.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_W.Controls.Add(this.lb_W);
            this.panel_W.Controls.Add(this.lbCommandW);
            this.panel_W.Location = new System.Drawing.Point(183, 138);
            this.panel_W.Name = "panel_W";
            this.panel_W.Size = new System.Drawing.Size(58, 58);
            this.panel_W.TabIndex = 15;
            // 
            // lb_W
            // 
            this.lb_W.AutoSize = true;
            this.lb_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_W.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_W.Location = new System.Drawing.Point(20, 6);
            this.lb_W.Name = "lb_W";
            this.lb_W.Size = new System.Drawing.Size(19, 13);
            this.lb_W.TabIndex = 1;
            this.lb_W.Text = "W";
            // 
            // lbCommandW
            // 
            this.lbCommandW.AutoSize = true;
            this.lbCommandW.Location = new System.Drawing.Point(1, 24);
            this.lbCommandW.Name = "lbCommandW";
            this.lbCommandW.Size = new System.Drawing.Size(57, 13);
            this.lbCommandW.TabIndex = 0;
            this.lbCommandW.Text = "LookAway";
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(12, 9);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(102, 20);
            this.lbTime.TabIndex = 16;
            this.lbTime.Text = "00:00:00.000";
            // 
            // testNumber
            // 
            this.testNumber.FormattingEnabled = true;
            this.testNumber.Location = new System.Drawing.Point(116, 36);
            this.testNumber.Name = "testNumber";
            this.testNumber.Size = new System.Drawing.Size(177, 21);
            this.testNumber.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Trial Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.timeRatio);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.testNumber);
            this.groupBox2.Controls.Add(this.panel_W);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.panel_D);
            this.groupBox2.Controls.Add(this.panel_S);
            this.groupBox2.Controls.Add(this.panel_A);
            this.groupBox2.Location = new System.Drawing.Point(39, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 364);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controller";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "0.5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Time Ratio";
            // 
            // timeRatio
            // 
            this.timeRatio.Location = new System.Drawing.Point(114, 74);
            this.timeRatio.Maximum = 100;
            this.timeRatio.Name = "timeRatio";
            this.timeRatio.Size = new System.Drawing.Size(180, 45);
            this.timeRatio.TabIndex = 16;
            this.timeRatio.TickFrequency = 5;
            this.timeRatio.Value = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Neuro Development Interrater";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordItemBindingSource)).EndInit();
            this.panel_A.ResumeLayout(false);
            this.panel_A.PerformLayout();
            this.panel_S.ResumeLayout(false);
            this.panel_S.PerformLayout();
            this.panel_D.ResumeLayout(false);
            this.panel_D.PerformLayout();
            this.panel_W.ResumeLayout(false);
            this.panel_W.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subjectId;
        private System.Windows.Forms.TextBox raterName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel_A;
        private System.Windows.Forms.Label lbCommandA;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lb_A;
        private System.Windows.Forms.Panel panel_S;
        private System.Windows.Forms.Label lb_S;
        private System.Windows.Forms.Label lbCommandS;
        private System.Windows.Forms.Panel panel_D;
        private System.Windows.Forms.Label lb_D;
        private System.Windows.Forms.Label lbCommandD;
        private System.Windows.Forms.Panel panel_W;
        private System.Windows.Forms.Label lb_W;
        private System.Windows.Forms.Label lbCommandW;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn buttonNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundTimeElapsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeElapsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox testNumber;
        private System.Windows.Forms.TextBox testName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjectAge;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar timeRatio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource recordItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
    }
}

