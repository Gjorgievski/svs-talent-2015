namespace TransactionApp
{
    partial class frmMain
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
            this.btnCreateTransactionAccount = new System.Windows.Forms.Button();
            this.btnCreateDepositAccount = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnitInterestRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitPeriod = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLimitCurrency = new System.Windows.Forms.Label();
            this.lblLimitAmount = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_fromLimitCurrency = new System.Windows.Forms.Label();
            this.lbl_fromLimitAmount = new System.Windows.Forms.Label();
            this.lbl_fromBalance = new System.Windows.Forms.Label();
            this.lbl_fromCurrency = new System.Windows.Forms.Label();
            this.lbl_fromNumber = new System.Windows.Forms.Label();
            this.lbl_fromId = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbl_toEndDate = new System.Windows.Forms.Label();
            this.lbl_toStartDate = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.lbl_toInterest = new System.Windows.Forms.Label();
            this.lbl_toPeriod = new System.Windows.Forms.Label();
            this.lbl_toBalance = new System.Windows.Forms.Label();
            this.lbl_toCurrency = new System.Windows.Forms.Label();
            this.lbl_toNumber = new System.Windows.Forms.Label();
            this.lbl_toId = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.lblTransactionStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(12, 573);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(175, 23);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = " Create Transaction Account ";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(193, 573);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(175, 23);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "Create Deposit Account";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(112, 42);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(112, 20);
            this.txtCurrency.TabIndex = 2;
            this.txtCurrency.Text = "MKD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Currency ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account Limit";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(112, 75);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(112, 20);
            this.txtLimit.TabIndex = 5;
            this.txtLimit.Text = "10000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUnitInterestRate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPercent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUnitPeriod);
            this.groupBox1.Controls.Add(this.txtPeriod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(248, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 167);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit Account";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(70, 135);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "End Date";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(70, 101);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Start Date";
            // 
            // txtUnitInterestRate
            // 
            this.txtUnitInterestRate.Location = new System.Drawing.Point(343, 68);
            this.txtUnitInterestRate.Name = "txtUnitInterestRate";
            this.txtUnitInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtUnitInterestRate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "InterestRate/Unit";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(119, 68);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(100, 20);
            this.txtPercent.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "InterestRate/Percent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TimePeriod/Unit";
            // 
            // txtUnitPeriod
            // 
            this.txtUnitPeriod.Location = new System.Drawing.Point(343, 34);
            this.txtUnitPeriod.Name = "txtUnitPeriod";
            this.txtUnitPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPeriod.TabIndex = 2;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(119, 38);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriod.TabIndex = 1;
            this.txtPeriod.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TimePeriod/Period";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCurrency);
            this.groupBox2.Controls.Add(this.txtLimit);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 167);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Account";
            // 
            // lblId
            // 
            this.lblId.AutoEllipsis = true;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(73, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(99, 51);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 1;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(61, 77);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblCurrency.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(59, 103);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblBalance);
            this.groupBox3.Controls.Add(this.lblId);
            this.groupBox3.Controls.Add(this.lblCurrency);
            this.groupBox3.Controls.Add(this.lblNumber);
            this.groupBox3.Location = new System.Drawing.Point(12, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 130);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Common Account Properties";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Balance:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Currency:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Account Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Account ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lblLimitCurrency);
            this.groupBox4.Controls.Add(this.lblLimitAmount);
            this.groupBox4.Location = new System.Drawing.Point(243, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 130);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transaction Account Properties ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Limit Currency:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Limit Amount:";
            // 
            // lblLimitCurrency
            // 
            this.lblLimitCurrency.AutoSize = true;
            this.lblLimitCurrency.Location = new System.Drawing.Point(85, 51);
            this.lblLimitCurrency.Name = "lblLimitCurrency";
            this.lblLimitCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblLimitCurrency.TabIndex = 1;
            // 
            // lblLimitAmount
            // 
            this.lblLimitAmount.AutoSize = true;
            this.lblLimitAmount.Location = new System.Drawing.Point(79, 27);
            this.lblLimitAmount.Name = "lblLimitAmount";
            this.lblLimitAmount.Size = new System.Drawing.Size(0, 13);
            this.lblLimitAmount.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lblEndDate);
            this.groupBox5.Controls.Add(this.lblStartDate);
            this.groupBox5.Controls.Add(this.lblInterest);
            this.groupBox5.Controls.Add(this.lblPeriod);
            this.groupBox5.Location = new System.Drawing.Point(474, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 130);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Deposit Account Properties";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "End Date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Start Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Interest Rate:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Time Period:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(65, 102);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(0, 13);
            this.lblEndDate.TabIndex = 3;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(68, 77);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(0, 13);
            this.lblStartDate.TabIndex = 2;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(81, 51);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(0, 13);
            this.lblInterest.TabIndex = 1;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(76, 27);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(0, 13);
            this.lblPeriod.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_fromLimitCurrency);
            this.groupBox6.Controls.Add(this.lbl_fromLimitAmount);
            this.groupBox6.Controls.Add(this.lbl_fromBalance);
            this.groupBox6.Controls.Add(this.lbl_fromCurrency);
            this.groupBox6.Controls.Add(this.lbl_fromNumber);
            this.groupBox6.Controls.Add(this.lbl_fromId);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Location = new System.Drawing.Point(12, 337);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 207);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transaction Account";
            // 
            // lbl_fromLimitCurrency
            // 
            this.lbl_fromLimitCurrency.AutoSize = true;
            this.lbl_fromLimitCurrency.Location = new System.Drawing.Point(86, 135);
            this.lbl_fromLimitCurrency.Name = "lbl_fromLimitCurrency";
            this.lbl_fromLimitCurrency.Size = new System.Drawing.Size(0, 13);
            this.lbl_fromLimitCurrency.TabIndex = 19;
            // 
            // lbl_fromLimitAmount
            // 
            this.lbl_fromLimitAmount.AutoSize = true;
            this.lbl_fromLimitAmount.Location = new System.Drawing.Point(83, 113);
            this.lbl_fromLimitAmount.Name = "lbl_fromLimitAmount";
            this.lbl_fromLimitAmount.Size = new System.Drawing.Size(0, 13);
            this.lbl_fromLimitAmount.TabIndex = 18;
            // 
            // lbl_fromBalance
            // 
            this.lbl_fromBalance.AutoSize = true;
            this.lbl_fromBalance.Location = new System.Drawing.Point(65, 91);
            this.lbl_fromBalance.Name = "lbl_fromBalance";
            this.lbl_fromBalance.Size = new System.Drawing.Size(0, 13);
            this.lbl_fromBalance.TabIndex = 17;
            // 
            // lbl_fromCurrency
            // 
            this.lbl_fromCurrency.AutoSize = true;
            this.lbl_fromCurrency.Location = new System.Drawing.Point(68, 69);
            this.lbl_fromCurrency.Name = "lbl_fromCurrency";
            this.lbl_fromCurrency.Size = new System.Drawing.Size(0, 13);
            this.lbl_fromCurrency.TabIndex = 16;
            // 
            // lbl_fromNumber
            // 
            this.lbl_fromNumber.AutoSize = true;
            this.lbl_fromNumber.Location = new System.Drawing.Point(106, 47);
            this.lbl_fromNumber.Name = "lbl_fromNumber";
            this.lbl_fromNumber.Size = new System.Drawing.Size(0, 13);
            this.lbl_fromNumber.TabIndex = 15;
            // 
            // lbl_fromId
            // 
            this.lbl_fromId.AutoSize = true;
            this.lbl_fromId.Location = new System.Drawing.Point(79, 26);
            this.lbl_fromId.Name = "lbl_fromId";
            this.lbl_fromId.Size = new System.Drawing.Size(0, 13);
            this.lbl_fromId.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Limit Curency:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Limit Amount:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Balance:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Currency:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Account Number:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Account ID:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbl_toEndDate);
            this.groupBox7.Controls.Add(this.lbl_toStartDate);
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.lbl_toInterest);
            this.groupBox7.Controls.Add(this.lbl_toPeriod);
            this.groupBox7.Controls.Add(this.lbl_toBalance);
            this.groupBox7.Controls.Add(this.lbl_toCurrency);
            this.groupBox7.Controls.Add(this.lbl_toNumber);
            this.groupBox7.Controls.Add(this.lbl_toId);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.label42);
            this.groupBox7.Location = new System.Drawing.Point(362, 337);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(335, 207);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Deposit/Loan Account";
            // 
            // lbl_toEndDate
            // 
            this.lbl_toEndDate.AutoSize = true;
            this.lbl_toEndDate.Location = new System.Drawing.Point(67, 182);
            this.lbl_toEndDate.Name = "lbl_toEndDate";
            this.lbl_toEndDate.Size = new System.Drawing.Size(0, 13);
            this.lbl_toEndDate.TabIndex = 35;
            // 
            // lbl_toStartDate
            // 
            this.lbl_toStartDate.AutoSize = true;
            this.lbl_toStartDate.Location = new System.Drawing.Point(71, 159);
            this.lbl_toStartDate.Name = "lbl_toStartDate";
            this.lbl_toStartDate.Size = new System.Drawing.Size(0, 13);
            this.lbl_toStartDate.TabIndex = 34;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 182);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(55, 13);
            this.label44.TabIndex = 33;
            this.label44.Text = "End Date:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 160);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(58, 13);
            this.label43.TabIndex = 32;
            this.label43.Text = "Start Date:";
            // 
            // lbl_toInterest
            // 
            this.lbl_toInterest.AutoSize = true;
            this.lbl_toInterest.Location = new System.Drawing.Point(83, 135);
            this.lbl_toInterest.Name = "lbl_toInterest";
            this.lbl_toInterest.Size = new System.Drawing.Size(0, 13);
            this.lbl_toInterest.TabIndex = 31;
            // 
            // lbl_toPeriod
            // 
            this.lbl_toPeriod.AutoSize = true;
            this.lbl_toPeriod.Location = new System.Drawing.Point(80, 113);
            this.lbl_toPeriod.Name = "lbl_toPeriod";
            this.lbl_toPeriod.Size = new System.Drawing.Size(0, 13);
            this.lbl_toPeriod.TabIndex = 30;
            // 
            // lbl_toBalance
            // 
            this.lbl_toBalance.AutoSize = true;
            this.lbl_toBalance.Location = new System.Drawing.Point(62, 91);
            this.lbl_toBalance.Name = "lbl_toBalance";
            this.lbl_toBalance.Size = new System.Drawing.Size(0, 13);
            this.lbl_toBalance.TabIndex = 29;
            // 
            // lbl_toCurrency
            // 
            this.lbl_toCurrency.AutoSize = true;
            this.lbl_toCurrency.Location = new System.Drawing.Point(65, 69);
            this.lbl_toCurrency.Name = "lbl_toCurrency";
            this.lbl_toCurrency.Size = new System.Drawing.Size(0, 13);
            this.lbl_toCurrency.TabIndex = 28;
            // 
            // lbl_toNumber
            // 
            this.lbl_toNumber.AutoSize = true;
            this.lbl_toNumber.Location = new System.Drawing.Point(103, 47);
            this.lbl_toNumber.Name = "lbl_toNumber";
            this.lbl_toNumber.Size = new System.Drawing.Size(0, 13);
            this.lbl_toNumber.TabIndex = 27;
            // 
            // lbl_toId
            // 
            this.lbl_toId.AutoSize = true;
            this.lbl_toId.Location = new System.Drawing.Point(76, 26);
            this.lbl_toId.Name = "lbl_toId";
            this.lbl_toId.Size = new System.Drawing.Size(0, 13);
            this.lbl_toId.TabIndex = 26;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 136);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(71, 13);
            this.label37.TabIndex = 25;
            this.label37.Text = "Interest Rate:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 114);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(66, 13);
            this.label38.TabIndex = 24;
            this.label38.Text = "Time Period:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 92);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(49, 13);
            this.label39.TabIndex = 23;
            this.label39.Text = "Balance:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 70);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(52, 13);
            this.label40.TabIndex = 22;
            this.label40.Text = "Currency:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 48);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(90, 13);
            this.label41.TabIndex = 21;
            this.label41.Text = "Account Number:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 26);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(64, 13);
            this.label42.TabIndex = 20;
            this.label42.Text = "Account ID:";
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(374, 573);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(175, 23);
            this.btnMakeTransaction.TabIndex = 14;
            this.btnMakeTransaction.Text = "Make Transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // lblTransactionStatus
            // 
            this.lblTransactionStatus.AutoSize = true;
            this.lblTransactionStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTransactionStatus.Location = new System.Drawing.Point(12, 547);
            this.lblTransactionStatus.Name = "lblTransactionStatus";
            this.lblTransactionStatus.Size = new System.Drawing.Size(96, 13);
            this.lblTransactionStatus.TabIndex = 20;
            this.lblTransactionStatus.Text = "Transaction Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 608);
            this.Controls.Add(this.lblTransactionStatus);
            this.Controls.Add(this.btnMakeTransaction);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCreateDepositAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreateTransactionAccount);
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUnitInterestRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitPeriod;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLimitAmount;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblLimitCurrency;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbl_fromLimitCurrency;
        private System.Windows.Forms.Label lbl_fromLimitAmount;
        private System.Windows.Forms.Label lbl_fromBalance;
        private System.Windows.Forms.Label lbl_fromCurrency;
        private System.Windows.Forms.Label lbl_fromNumber;
        private System.Windows.Forms.Label lbl_fromId;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbl_toEndDate;
        private System.Windows.Forms.Label lbl_toStartDate;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label lbl_toInterest;
        private System.Windows.Forms.Label lbl_toPeriod;
        private System.Windows.Forms.Label lbl_toBalance;
        private System.Windows.Forms.Label lbl_toCurrency;
        private System.Windows.Forms.Label lbl_toNumber;
        private System.Windows.Forms.Label lbl_toId;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.Label lblTransactionStatus;
    }
}

