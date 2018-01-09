namespace V_Project
{
    partial class Form1
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
            this.serialPortArd = new System.IO.Ports.SerialPort(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.comboBoxSerial = new System.Windows.Forms.ComboBox();
            this.progressBarState = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStage = new System.Windows.Forms.ComboBox();
            this.btn_stage = new System.Windows.Forms.Button();
            this.textBox10L = new System.Windows.Forms.TextBox();
            this.textBox80L = new System.Windows.Forms.TextBox();
            this.textBoxVac = new System.Windows.Forms.TextBox();
            this.textBoxStg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBarVac = new System.Windows.Forms.ProgressBar();
            this.progressBarTerm = new System.Windows.Forms.ProgressBar();
            this.btnTermOff = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTermOn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVacOn = new System.Windows.Forms.Button();
            this.btnVacOff = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxTermSet = new System.Windows.Forms.TextBox();
            this.textBoxVacSet = new System.Windows.Forms.TextBox();
            this.textBoxVlv1 = new System.Windows.Forms.TextBox();
            this.btnVlv1On = new System.Windows.Forms.Button();
            this.btnVlv1Off = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBarVlv1 = new System.Windows.Forms.ProgressBar();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBoxVlv2 = new System.Windows.Forms.TextBox();
            this.btnVlv2On = new System.Windows.Forms.Button();
            this.btnVlv2Off = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBarVlv2 = new System.Windows.Forms.ProgressBar();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btn_next_stage = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxLaser = new System.Windows.Forms.TextBox();
            this.btnLaserOn = new System.Windows.Forms.Button();
            this.btnLaserOff = new System.Windows.Forms.Button();
            this.textBoxShowRead = new System.Windows.Forms.TextBox();
            this.textBoxShowSet = new System.Windows.Forms.TextBox();
            this.textBoxShowSerial = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.progressBarAlarm = new System.Windows.Forms.ProgressBar();
            this.textBoxAlarm = new System.Windows.Forms.TextBox();
            this.textBoxShowSend = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxVlvOne = new System.Windows.Forms.TextBox();
            this.textBoxVlvTwo = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.progressBarLvl = new System.Windows.Forms.ProgressBar();
            this.checkBoxTherm = new System.Windows.Forms.CheckBox();
            this.serialPortTherm = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxThermo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.Location = new System.Drawing.Point(272, 295);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(112, 34);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stop.Location = new System.Drawing.Point(272, 351);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(112, 40);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(27, 44);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSerial.TabIndex = 2;
            // 
            // progressBarState
            // 
            this.progressBarState.Location = new System.Drawing.Point(27, 195);
            this.progressBarState.Name = "progressBarState";
            this.progressBarState.Size = new System.Drawing.Size(100, 23);
            this.progressBarState.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.textBoxSend);
            this.groupBox1.Location = new System.Drawing.Point(37, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "send";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(6, 19);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(186, 63);
            this.textBoxSend.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(43, 470);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(181, 44);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Open Port";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Location = new System.Drawing.Point(181, 74);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close Port";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.textBoxRead);
            this.groupBox2.Location = new System.Drawing.Point(539, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 101);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "read";
            // 
            // textBoxRead
            // 
            this.textBoxRead.Enabled = false;
            this.textBoxRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRead.Location = new System.Drawing.Point(6, 19);
            this.textBoxRead.Multiline = true;
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.ReadOnly = true;
            this.textBoxRead.Size = new System.Drawing.Size(186, 76);
            this.textBoxRead.TabIndex = 0;
            // 
            // btn_read
            // 
            this.btn_read.Enabled = false;
            this.btn_read.Location = new System.Drawing.Point(656, 121);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stage";
            // 
            // comboBoxStage
            // 
            this.comboBoxStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStage.Enabled = false;
            this.comboBoxStage.FormattingEnabled = true;
            this.comboBoxStage.Items.AddRange(new object[] {
            "STOP",
            "WELCOME",
            "STAGE1",
            "STAGE2",
            "STAGE3",
            "STAGE4",
            "STAGE5",
            "STAGE6",
            "STAGE7",
            "STAGE8",
            "STAGE9",
            "STAGE10",
            "STAGE11",
            "STAGE12",
            "STAGE13",
            "STAGE14",
            "STAGE15",
            "STAGE16",
            "STAGE17",
            "STAGE18",
            "STAGE19",
            "STAGE20",
            "STAGE21",
            "STAGE22",
            "STAGE23",
            "STAGE24",
            "STAGE25",
            "STAGE26",
            "STAGE27",
            "STAGE28"});
            this.comboBoxStage.Location = new System.Drawing.Point(37, 300);
            this.comboBoxStage.Name = "comboBoxStage";
            this.comboBoxStage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStage.TabIndex = 11;
            // 
            // btn_stage
            // 
            this.btn_stage.Enabled = false;
            this.btn_stage.Location = new System.Drawing.Point(177, 300);
            this.btn_stage.Name = "btn_stage";
            this.btn_stage.Size = new System.Drawing.Size(75, 23);
            this.btn_stage.TabIndex = 12;
            this.btn_stage.Text = "send";
            this.btn_stage.UseVisualStyleBackColor = true;
            this.btn_stage.Click += new System.EventHandler(this.btn_stage_Click);
            // 
            // textBox10L
            // 
            this.textBox10L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10L.Location = new System.Drawing.Point(288, 38);
            this.textBox10L.Name = "textBox10L";
            this.textBox10L.ReadOnly = true;
            this.textBox10L.Size = new System.Drawing.Size(100, 29);
            this.textBox10L.TabIndex = 13;
            // 
            // textBox80L
            // 
            this.textBox80L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox80L.Location = new System.Drawing.Point(288, 123);
            this.textBox80L.Name = "textBox80L";
            this.textBox80L.ReadOnly = true;
            this.textBox80L.Size = new System.Drawing.Size(100, 29);
            this.textBox80L.TabIndex = 14;
            // 
            // textBoxVac
            // 
            this.textBoxVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVac.Location = new System.Drawing.Point(416, 38);
            this.textBoxVac.Name = "textBoxVac";
            this.textBoxVac.ReadOnly = true;
            this.textBoxVac.Size = new System.Drawing.Size(100, 29);
            this.textBoxVac.TabIndex = 16;
            // 
            // textBoxStg
            // 
            this.textBoxStg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStg.Location = new System.Drawing.Point(416, 123);
            this.textBoxStg.Name = "textBoxStg";
            this.textBoxStg.ReadOnly = true;
            this.textBoxStg.Size = new System.Drawing.Size(100, 29);
            this.textBoxStg.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(284, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Temp 10 L";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(284, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Temp 80 L";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(421, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Vacuum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(433, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Stage";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBarVac
            // 
            this.progressBarVac.Location = new System.Drawing.Point(668, 296);
            this.progressBarVac.Maximum = 1;
            this.progressBarVac.Name = "progressBarVac";
            this.progressBarVac.Size = new System.Drawing.Size(39, 23);
            this.progressBarVac.TabIndex = 26;
            // 
            // progressBarTerm
            // 
            this.progressBarTerm.Location = new System.Drawing.Point(527, 296);
            this.progressBarTerm.Maximum = 1;
            this.progressBarTerm.Name = "progressBarTerm";
            this.progressBarTerm.Size = new System.Drawing.Size(35, 23);
            this.progressBarTerm.TabIndex = 28;
            // 
            // btnTermOff
            // 
            this.btnTermOff.Enabled = false;
            this.btnTermOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTermOff.Location = new System.Drawing.Point(508, 338);
            this.btnTermOff.Name = "btnTermOff";
            this.btnTermOff.Size = new System.Drawing.Size(54, 32);
            this.btnTermOff.TabIndex = 29;
            this.btnTermOff.Text = "off";
            this.btnTermOff.UseVisualStyleBackColor = true;
            this.btnTermOff.Click += new System.EventHandler(this.btnTermOff_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(587, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Vacuum";
            // 
            // btnTermOn
            // 
            this.btnTermOn.Enabled = false;
            this.btnTermOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTermOn.Location = new System.Drawing.Point(442, 338);
            this.btnTermOn.Name = "btnTermOn";
            this.btnTermOn.Size = new System.Drawing.Size(56, 32);
            this.btnTermOn.TabIndex = 31;
            this.btnTermOn.Text = "on";
            this.btnTermOn.UseVisualStyleBackColor = true;
            this.btnTermOn.Click += new System.EventHandler(this.btnTermOn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(426, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Thermostat";
            // 
            // btnVacOn
            // 
            this.btnVacOn.Enabled = false;
            this.btnVacOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVacOn.Location = new System.Drawing.Point(591, 338);
            this.btnVacOn.Name = "btnVacOn";
            this.btnVacOn.Size = new System.Drawing.Size(56, 32);
            this.btnVacOn.TabIndex = 34;
            this.btnVacOn.Text = "on";
            this.btnVacOn.UseVisualStyleBackColor = true;
            this.btnVacOn.Click += new System.EventHandler(this.btnVacOn_Click);
            // 
            // btnVacOff
            // 
            this.btnVacOff.Enabled = false;
            this.btnVacOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVacOff.Location = new System.Drawing.Point(653, 338);
            this.btnVacOff.Name = "btnVacOff";
            this.btnVacOff.Size = new System.Drawing.Size(54, 32);
            this.btnVacOff.TabIndex = 33;
            this.btnVacOff.Text = "off";
            this.btnVacOff.UseVisualStyleBackColor = true;
            this.btnVacOff.Click += new System.EventHandler(this.btnVacOff_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.Location = new System.Drawing.Point(581, 272);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(146, 156);
            this.textBox3.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Silver;
            this.textBox4.Location = new System.Drawing.Point(416, 272);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(151, 156);
            this.textBox4.TabIndex = 36;
            // 
            // textBoxTermSet
            // 
            this.textBoxTermSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTermSet.Location = new System.Drawing.Point(446, 388);
            this.textBoxTermSet.Name = "textBoxTermSet";
            this.textBoxTermSet.Size = new System.Drawing.Size(100, 29);
            this.textBoxTermSet.TabIndex = 37;
            // 
            // textBoxVacSet
            // 
            this.textBoxVacSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVacSet.Location = new System.Drawing.Point(591, 388);
            this.textBoxVacSet.Name = "textBoxVacSet";
            this.textBoxVacSet.Size = new System.Drawing.Size(100, 29);
            this.textBoxVacSet.TabIndex = 38;
            // 
            // textBoxVlv1
            // 
            this.textBoxVlv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVlv1.Location = new System.Drawing.Point(431, 550);
            this.textBoxVlv1.Name = "textBoxVlv1";
            this.textBoxVlv1.Size = new System.Drawing.Size(100, 29);
            this.textBoxVlv1.TabIndex = 44;
            this.textBoxVlv1.Text = "0";
            // 
            // btnVlv1On
            // 
            this.btnVlv1On.Enabled = false;
            this.btnVlv1On.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVlv1On.Location = new System.Drawing.Point(431, 500);
            this.btnVlv1On.Name = "btnVlv1On";
            this.btnVlv1On.Size = new System.Drawing.Size(56, 32);
            this.btnVlv1On.TabIndex = 42;
            this.btnVlv1On.Text = "on";
            this.btnVlv1On.UseVisualStyleBackColor = true;
            this.btnVlv1On.Click += new System.EventHandler(this.btnVlv1On_Click);
            // 
            // btnVlv1Off
            // 
            this.btnVlv1Off.Enabled = false;
            this.btnVlv1Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVlv1Off.Location = new System.Drawing.Point(493, 500);
            this.btnVlv1Off.Name = "btnVlv1Off";
            this.btnVlv1Off.Size = new System.Drawing.Size(54, 32);
            this.btnVlv1Off.TabIndex = 41;
            this.btnVlv1Off.Text = "off";
            this.btnVlv1Off.UseVisualStyleBackColor = true;
            this.btnVlv1Off.Click += new System.EventHandler(this.btnVlv1Off_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(430, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 40;
            this.label10.Text = "Valve1";
            // 
            // progressBarVlv1
            // 
            this.progressBarVlv1.Location = new System.Drawing.Point(508, 458);
            this.progressBarVlv1.Maximum = 1;
            this.progressBarVlv1.Name = "progressBarVlv1";
            this.progressBarVlv1.Size = new System.Drawing.Size(39, 23);
            this.progressBarVlv1.TabIndex = 39;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Silver;
            this.textBox6.Location = new System.Drawing.Point(416, 434);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(151, 156);
            this.textBox6.TabIndex = 43;
            // 
            // textBoxVlv2
            // 
            this.textBoxVlv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVlv2.Location = new System.Drawing.Point(591, 550);
            this.textBoxVlv2.Name = "textBoxVlv2";
            this.textBoxVlv2.Size = new System.Drawing.Size(100, 29);
            this.textBoxVlv2.TabIndex = 50;
            this.textBoxVlv2.Text = "0";
            // 
            // btnVlv2On
            // 
            this.btnVlv2On.Enabled = false;
            this.btnVlv2On.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVlv2On.Location = new System.Drawing.Point(591, 500);
            this.btnVlv2On.Name = "btnVlv2On";
            this.btnVlv2On.Size = new System.Drawing.Size(56, 32);
            this.btnVlv2On.TabIndex = 48;
            this.btnVlv2On.Text = "on";
            this.btnVlv2On.UseVisualStyleBackColor = true;
            this.btnVlv2On.Click += new System.EventHandler(this.btnVlv2On_Click);
            // 
            // btnVlv2Off
            // 
            this.btnVlv2Off.Enabled = false;
            this.btnVlv2Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVlv2Off.Location = new System.Drawing.Point(653, 500);
            this.btnVlv2Off.Name = "btnVlv2Off";
            this.btnVlv2Off.Size = new System.Drawing.Size(54, 32);
            this.btnVlv2Off.TabIndex = 47;
            this.btnVlv2Off.Text = "off";
            this.btnVlv2Off.UseVisualStyleBackColor = true;
            this.btnVlv2Off.Click += new System.EventHandler(this.btnVlv2Off_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(587, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 46;
            this.label11.Text = "Valve2";
            // 
            // progressBarVlv2
            // 
            this.progressBarVlv2.Location = new System.Drawing.Point(668, 458);
            this.progressBarVlv2.Maximum = 1;
            this.progressBarVlv2.Name = "progressBarVlv2";
            this.progressBarVlv2.Size = new System.Drawing.Size(39, 23);
            this.progressBarVlv2.TabIndex = 45;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Silver;
            this.textBox8.Location = new System.Drawing.Point(581, 434);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(146, 156);
            this.textBox8.TabIndex = 49;
            // 
            // btn_next_stage
            // 
            this.btn_next_stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next_stage.Location = new System.Drawing.Point(36, 338);
            this.btn_next_stage.Name = "btn_next_stage";
            this.btn_next_stage.Size = new System.Drawing.Size(122, 28);
            this.btn_next_stage.TabIndex = 52;
            this.btn_next_stage.Text = "Next Stage";
            this.btn_next_stage.UseVisualStyleBackColor = true;
            this.btn_next_stage.Click += new System.EventHandler(this.btn_next_stage_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(430, 602);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 57;
            this.label13.Text = "Laser";
            // 
            // textBoxLaser
            // 
            this.textBoxLaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLaser.Location = new System.Drawing.Point(284, 190);
            this.textBoxLaser.Name = "textBoxLaser";
            this.textBoxLaser.ReadOnly = true;
            this.textBoxLaser.Size = new System.Drawing.Size(100, 29);
            this.textBoxLaser.TabIndex = 58;
            // 
            // btnLaserOn
            // 
            this.btnLaserOn.Enabled = false;
            this.btnLaserOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLaserOn.Location = new System.Drawing.Point(429, 638);
            this.btnLaserOn.Name = "btnLaserOn";
            this.btnLaserOn.Size = new System.Drawing.Size(56, 32);
            this.btnLaserOn.TabIndex = 59;
            this.btnLaserOn.Text = "on";
            this.btnLaserOn.UseVisualStyleBackColor = true;
            this.btnLaserOn.Click += new System.EventHandler(this.btnLaserOn_Click);
            // 
            // btnLaserOff
            // 
            this.btnLaserOff.Enabled = false;
            this.btnLaserOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLaserOff.Location = new System.Drawing.Point(493, 638);
            this.btnLaserOff.Name = "btnLaserOff";
            this.btnLaserOff.Size = new System.Drawing.Size(54, 32);
            this.btnLaserOff.TabIndex = 60;
            this.btnLaserOff.Text = "off";
            this.btnLaserOff.UseVisualStyleBackColor = true;
            this.btnLaserOff.Click += new System.EventHandler(this.btnLaserOff_Click);
            // 
            // textBoxShowRead
            // 
            this.textBoxShowRead.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxShowRead.Location = new System.Drawing.Point(272, 9);
            this.textBoxShowRead.Multiline = true;
            this.textBoxShowRead.Name = "textBoxShowRead";
            this.textBoxShowRead.ReadOnly = true;
            this.textBoxShowRead.Size = new System.Drawing.Size(483, 228);
            this.textBoxShowRead.TabIndex = 61;
            // 
            // textBoxShowSet
            // 
            this.textBoxShowSet.BackColor = System.Drawing.Color.Silver;
            this.textBoxShowSet.Location = new System.Drawing.Point(402, 259);
            this.textBoxShowSet.Multiline = true;
            this.textBoxShowSet.Name = "textBoxShowSet";
            this.textBoxShowSet.ReadOnly = true;
            this.textBoxShowSet.Size = new System.Drawing.Size(353, 456);
            this.textBoxShowSet.TabIndex = 62;
            // 
            // textBoxShowSerial
            // 
            this.textBoxShowSerial.BackColor = System.Drawing.Color.Lavender;
            this.textBoxShowSerial.Location = new System.Drawing.Point(2, 9);
            this.textBoxShowSerial.Multiline = true;
            this.textBoxShowSerial.Name = "textBoxShowSerial";
            this.textBoxShowSerial.ReadOnly = true;
            this.textBoxShowSerial.Size = new System.Drawing.Size(264, 228);
            this.textBoxShowSerial.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(546, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "ALARM";
            // 
            // progressBarAlarm
            // 
            this.progressBarAlarm.ForeColor = System.Drawing.Color.Red;
            this.progressBarAlarm.Location = new System.Drawing.Point(643, 155);
            this.progressBarAlarm.Maximum = 1;
            this.progressBarAlarm.Name = "progressBarAlarm";
            this.progressBarAlarm.Size = new System.Drawing.Size(84, 23);
            this.progressBarAlarm.Step = 1;
            this.progressBarAlarm.TabIndex = 54;
            // 
            // textBoxAlarm
            // 
            this.textBoxAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAlarm.Location = new System.Drawing.Point(609, 190);
            this.textBoxAlarm.Multiline = true;
            this.textBoxAlarm.Name = "textBoxAlarm";
            this.textBoxAlarm.ReadOnly = true;
            this.textBoxAlarm.Size = new System.Drawing.Size(122, 40);
            this.textBoxAlarm.TabIndex = 55;
            // 
            // textBoxShowSend
            // 
            this.textBoxShowSend.BackColor = System.Drawing.Color.Thistle;
            this.textBoxShowSend.Location = new System.Drawing.Point(19, 259);
            this.textBoxShowSend.Multiline = true;
            this.textBoxShowSend.Name = "textBoxShowSend";
            this.textBoxShowSend.ReadOnly = true;
            this.textBoxShowSend.Size = new System.Drawing.Size(377, 430);
            this.textBoxShowSend.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(284, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 65;
            this.label14.Text = "Laser";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Silver;
            this.textBox11.Location = new System.Drawing.Point(416, 593);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(151, 96);
            this.textBox11.TabIndex = 66;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(176, 344);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(90, 20);
            this.textBoxNumber.TabIndex = 67;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(398, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 20);
            this.label15.TabIndex = 68;
            this.label15.Text = "test";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(480, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 20);
            this.label16.TabIndex = 69;
            this.label16.Text = "test";
            // 
            // textBoxVlvOne
            // 
            this.textBoxVlvOne.Location = new System.Drawing.Point(402, 198);
            this.textBoxVlvOne.Name = "textBoxVlvOne";
            this.textBoxVlvOne.Size = new System.Drawing.Size(56, 20);
            this.textBoxVlvOne.TabIndex = 70;
            // 
            // textBoxVlvTwo
            // 
            this.textBoxVlvTwo.Location = new System.Drawing.Point(476, 198);
            this.textBoxVlvTwo.Name = "textBoxVlvTwo";
            this.textBoxVlvTwo.Size = new System.Drawing.Size(64, 20);
            this.textBoxVlvTwo.TabIndex = 71;
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(162, 169);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 21);
            this.checkBox2.TabIndex = 72;
            this.checkBox2.Text = "File record";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // progressBarLvl
            // 
            this.progressBarLvl.Location = new System.Drawing.Point(509, 602);
            this.progressBarLvl.Name = "progressBarLvl";
            this.progressBarLvl.Size = new System.Drawing.Size(38, 23);
            this.progressBarLvl.TabIndex = 73;
            // 
            // checkBoxTherm
            // 
            this.checkBoxTherm.AutoSize = true;
            this.checkBoxTherm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkBoxTherm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxTherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTherm.Location = new System.Drawing.Point(27, 79);
            this.checkBoxTherm.Name = "checkBoxTherm";
            this.checkBoxTherm.Size = new System.Drawing.Size(109, 24);
            this.checkBoxTherm.TabIndex = 74;
            this.checkBoxTherm.Text = "Thermostat";
            this.checkBoxTherm.UseVisualStyleBackColor = false;
            this.checkBoxTherm.CheckedChanged += new System.EventHandler(this.checkBoxTherm_CheckedChanged);
            // 
            // comboBoxThermo
            // 
            this.comboBoxThermo.FormattingEnabled = true;
            this.comboBoxThermo.Location = new System.Drawing.Point(27, 121);
            this.comboBoxThermo.Name = "comboBoxThermo";
            this.comboBoxThermo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxThermo.TabIndex = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(791, 727);
            this.Controls.Add(this.comboBoxThermo);
            this.Controls.Add(this.checkBoxTherm);
            this.Controls.Add(this.progressBarLvl);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBoxVlvTwo);
            this.Controls.Add(this.textBoxVlvOne);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnLaserOn);
            this.Controls.Add(this.btnLaserOff);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxLaser);
            this.Controls.Add(this.textBoxAlarm);
            this.Controls.Add(this.progressBarAlarm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_next_stage);
            this.Controls.Add(this.textBoxVlv2);
            this.Controls.Add(this.btnVlv2On);
            this.Controls.Add(this.btnVlv2Off);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.progressBarVlv2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBoxVlv1);
            this.Controls.Add(this.btnVlv1On);
            this.Controls.Add(this.btnVlv1Off);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBarVlv1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBoxVacSet);
            this.Controls.Add(this.textBoxTermSet);
            this.Controls.Add(this.btnVacOn);
            this.Controls.Add(this.btnVacOff);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTermOn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTermOff);
            this.Controls.Add(this.progressBarTerm);
            this.Controls.Add(this.progressBarVac);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStg);
            this.Controls.Add(this.textBoxVac);
            this.Controls.Add(this.textBox80L);
            this.Controls.Add(this.textBox10L);
            this.Controls.Add(this.btn_stage);
            this.Controls.Add(this.comboBoxStage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBarState);
            this.Controls.Add(this.comboBoxSerial);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxShowRead);
            this.Controls.Add(this.textBoxShowSet);
            this.Controls.Add(this.textBoxShowSerial);
            this.Controls.Add(this.textBoxShowSend);
            this.Name = "Form1";
            this.Text = "Serial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortArd;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ComboBox comboBoxSerial;
        private System.Windows.Forms.ProgressBar progressBarState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStage;
        private System.Windows.Forms.Button btn_stage;
        private System.Windows.Forms.TextBox textBox10L;
        private System.Windows.Forms.TextBox textBox80L;
        private System.Windows.Forms.TextBox textBoxVac;
        private System.Windows.Forms.TextBox textBoxStg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBarVac;
        private System.Windows.Forms.ProgressBar progressBarTerm;
        private System.Windows.Forms.Button btnTermOff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTermOn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVacOn;
        private System.Windows.Forms.Button btnVacOff;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxTermSet;
        private System.Windows.Forms.TextBox textBoxVacSet;
        private System.Windows.Forms.TextBox textBoxVlv1;
        private System.Windows.Forms.Button btnVlv1On;
        private System.Windows.Forms.Button btnVlv1Off;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBarVlv1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBoxVlv2;
        private System.Windows.Forms.Button btnVlv2On;
        private System.Windows.Forms.Button btnVlv2Off;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBarVlv2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btn_next_stage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxLaser;
        private System.Windows.Forms.Button btnLaserOn;
        private System.Windows.Forms.Button btnLaserOff;
        private System.Windows.Forms.TextBox textBoxShowRead;
        private System.Windows.Forms.TextBox textBoxShowSet;
        private System.Windows.Forms.TextBox textBoxShowSerial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar progressBarAlarm;
        private System.Windows.Forms.TextBox textBoxAlarm;
        private System.Windows.Forms.TextBox textBoxShowSend;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxVlvOne;
        private System.Windows.Forms.TextBox textBoxVlvTwo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ProgressBar progressBarLvl;
        private System.Windows.Forms.CheckBox checkBoxTherm;
        private System.IO.Ports.SerialPort serialPortTherm;
        private System.Windows.Forms.ComboBox comboBoxThermo;
    }
}

