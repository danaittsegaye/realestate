namespace WindowsFormsApp1.Forms
{
    partial class FormAddContract
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContractInfoInput = new System.Windows.Forms.Panel();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.panelTransactionInfoInput = new System.Windows.Forms.Panel();
            this.richTextBoxTrasactionDetail = new System.Windows.Forms.RichTextBox();
            this.lblTransactionDetail = new System.Windows.Forms.Label();
            this.dateTimePickerTrasactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.comboBoxClientRequested = new System.Windows.Forms.ComboBox();
            this.lblClientRequested = new System.Windows.Forms.Label();
            this.comboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.comboBoxClientOffered = new System.Windows.Forms.ComboBox();
            this.lblClientOffered = new System.Windows.Forms.Label();
            this.panelFinancialInput = new System.Windows.Forms.Panel();
            this.textBoxFeePercentage = new System.Windows.Forms.TextBox();
            this.lblFeePercentage = new System.Windows.Forms.Label();
            this.textBoxPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.comboBoxPaymentFrequency = new System.Windows.Forms.ComboBox();
            this.lblPaymentFrequency = new System.Windows.Forms.Label();
            this.panelDateInput = new System.Windows.Forms.Panel();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerDateSigned = new System.Windows.Forms.DateTimePicker();
            this.lblDateSigned = new System.Windows.Forms.Label();
            this.panelUnderContractInput = new System.Windows.Forms.Panel();
            this.comboBoxEstateUnderContract = new System.Windows.Forms.ComboBox();
            this.lblEstateUnderContract = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAddConract = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.panelContractInfoInput.SuspendLayout();
            this.panelTransactionInfoInput.SuspendLayout();
            this.panelFinancialInput.SuspendLayout();
            this.panelDateInput.SuspendLayout();
            this.panelUnderContractInput.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 39);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Add Contract";
            // 
            // panelContractInfoInput
            // 
            this.panelContractInfoInput.Controls.Add(this.comboBoxEmployee);
            this.panelContractInfoInput.Controls.Add(this.lblEmployee);
            this.panelContractInfoInput.Controls.Add(this.comboBoxType);
            this.panelContractInfoInput.Controls.Add(this.lblType);
            this.panelContractInfoInput.Controls.Add(this.comboBoxClient);
            this.panelContractInfoInput.Controls.Add(this.lblClient);
            this.panelContractInfoInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContractInfoInput.Location = new System.Drawing.Point(0, 39);
            this.panelContractInfoInput.Margin = new System.Windows.Forms.Padding(4);
            this.panelContractInfoInput.Name = "panelContractInfoInput";
            this.panelContractInfoInput.Size = new System.Drawing.Size(1088, 133);
            this.panelContractInfoInput.TabIndex = 24;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(288, 91);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(225, 24);
            this.comboBoxEmployee.TabIndex = 21;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmployee.Location = new System.Drawing.Point(16, 89);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(99, 25);
            this.lblEmployee.TabIndex = 20;
            this.lblEmployee.Text = "Employee";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(288, 58);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(225, 24);
            this.comboBoxType.TabIndex = 19;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblType.Location = new System.Drawing.Point(16, 55);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(57, 25);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "Type";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(288, 25);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(225, 24);
            this.comboBoxClient.TabIndex = 17;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClient.Location = new System.Drawing.Point(16, 22);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(62, 25);
            this.lblClient.TabIndex = 6;
            this.lblClient.Text = "Client";
            // 
            // panelTransactionInfoInput
            // 
            this.panelTransactionInfoInput.Controls.Add(this.richTextBoxTrasactionDetail);
            this.panelTransactionInfoInput.Controls.Add(this.lblTransactionDetail);
            this.panelTransactionInfoInput.Controls.Add(this.dateTimePickerTrasactionDate);
            this.panelTransactionInfoInput.Controls.Add(this.lblTransactionDate);
            this.panelTransactionInfoInput.Controls.Add(this.comboBoxClientRequested);
            this.panelTransactionInfoInput.Controls.Add(this.lblClientRequested);
            this.panelTransactionInfoInput.Controls.Add(this.comboBoxTransactionType);
            this.panelTransactionInfoInput.Controls.Add(this.lblTransactionType);
            this.panelTransactionInfoInput.Controls.Add(this.comboBoxClientOffered);
            this.panelTransactionInfoInput.Controls.Add(this.lblClientOffered);
            this.panelTransactionInfoInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransactionInfoInput.Location = new System.Drawing.Point(0, 172);
            this.panelTransactionInfoInput.Margin = new System.Windows.Forms.Padding(4);
            this.panelTransactionInfoInput.Name = "panelTransactionInfoInput";
            this.panelTransactionInfoInput.Size = new System.Drawing.Size(1088, 310);
            this.panelTransactionInfoInput.TabIndex = 25;
            // 
            // richTextBoxTrasactionDetail
            // 
            this.richTextBoxTrasactionDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTrasactionDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxTrasactionDetail.Location = new System.Drawing.Point(288, 177);
            this.richTextBoxTrasactionDetail.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxTrasactionDetail.Name = "richTextBoxTrasactionDetail";
            this.richTextBoxTrasactionDetail.Size = new System.Drawing.Size(409, 118);
            this.richTextBoxTrasactionDetail.TabIndex = 15;
            this.richTextBoxTrasactionDetail.Text = "";
            // 
            // lblTransactionDetail
            // 
            this.lblTransactionDetail.AutoSize = true;
            this.lblTransactionDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTransactionDetail.Location = new System.Drawing.Point(16, 178);
            this.lblTransactionDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionDetail.Name = "lblTransactionDetail";
            this.lblTransactionDetail.Size = new System.Drawing.Size(61, 25);
            this.lblTransactionDetail.TabIndex = 14;
            this.lblTransactionDetail.Text = "Detail";
            // 
            // dateTimePickerTrasactionDate
            // 
            this.dateTimePickerTrasactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerTrasactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTrasactionDate.Location = new System.Drawing.Point(288, 126);
            this.dateTimePickerTrasactionDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTrasactionDate.Name = "dateTimePickerTrasactionDate";
            this.dateTimePickerTrasactionDate.Size = new System.Drawing.Size(225, 30);
            this.dateTimePickerTrasactionDate.TabIndex = 27;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTransactionDate.Location = new System.Drawing.Point(15, 133);
            this.lblTransactionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(161, 25);
            this.lblTransactionDate.TabIndex = 26;
            this.lblTransactionDate.Text = "Transaction Date";
            // 
            // comboBoxClientRequested
            // 
            this.comboBoxClientRequested.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClientRequested.FormattingEnabled = true;
            this.comboBoxClientRequested.Location = new System.Drawing.Point(288, 59);
            this.comboBoxClientRequested.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClientRequested.Name = "comboBoxClientRequested";
            this.comboBoxClientRequested.Size = new System.Drawing.Size(225, 24);
            this.comboBoxClientRequested.TabIndex = 24;
            // 
            // lblClientRequested
            // 
            this.lblClientRequested.AutoSize = true;
            this.lblClientRequested.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClientRequested.Location = new System.Drawing.Point(16, 57);
            this.lblClientRequested.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientRequested.Name = "lblClientRequested";
            this.lblClientRequested.Size = new System.Drawing.Size(161, 25);
            this.lblClientRequested.TabIndex = 23;
            this.lblClientRequested.Text = "Client Requested";
            // 
            // comboBoxTransactionType
            // 
            this.comboBoxTransactionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTransactionType.FormattingEnabled = true;
            this.comboBoxTransactionType.Location = new System.Drawing.Point(288, 92);
            this.comboBoxTransactionType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.Size = new System.Drawing.Size(225, 24);
            this.comboBoxTransactionType.TabIndex = 13;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTransactionType.Location = new System.Drawing.Point(16, 94);
            this.lblTransactionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(165, 25);
            this.lblTransactionType.TabIndex = 12;
            this.lblTransactionType.Text = "Transaction Type";
            // 
            // comboBoxClientOffered
            // 
            this.comboBoxClientOffered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClientOffered.FormattingEnabled = true;
            this.comboBoxClientOffered.Location = new System.Drawing.Point(288, 26);
            this.comboBoxClientOffered.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClientOffered.Name = "comboBoxClientOffered";
            this.comboBoxClientOffered.Size = new System.Drawing.Size(225, 24);
            this.comboBoxClientOffered.TabIndex = 11;
            // 
            // lblClientOffered
            // 
            this.lblClientOffered.AutoSize = true;
            this.lblClientOffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClientOffered.Location = new System.Drawing.Point(16, 23);
            this.lblClientOffered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientOffered.Name = "lblClientOffered";
            this.lblClientOffered.Size = new System.Drawing.Size(132, 25);
            this.lblClientOffered.TabIndex = 9;
            this.lblClientOffered.Text = "Client Offered";
            // 
            // panelFinancialInput
            // 
            this.panelFinancialInput.Controls.Add(this.textBoxFeePercentage);
            this.panelFinancialInput.Controls.Add(this.lblFeePercentage);
            this.panelFinancialInput.Controls.Add(this.textBoxPaymentAmount);
            this.panelFinancialInput.Controls.Add(this.lblPaymentAmount);
            this.panelFinancialInput.Controls.Add(this.dateTimePickerDateFrom);
            this.panelFinancialInput.Controls.Add(this.lblDateFrom);
            this.panelFinancialInput.Controls.Add(this.comboBoxPaymentFrequency);
            this.panelFinancialInput.Controls.Add(this.lblPaymentFrequency);
            this.panelFinancialInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFinancialInput.Location = new System.Drawing.Point(0, 482);
            this.panelFinancialInput.Margin = new System.Windows.Forms.Padding(4);
            this.panelFinancialInput.Name = "panelFinancialInput";
            this.panelFinancialInput.Size = new System.Drawing.Size(1088, 176);
            this.panelFinancialInput.TabIndex = 26;
            // 
            // textBoxFeePercentage
            // 
            this.textBoxFeePercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFeePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFeePercentage.Location = new System.Drawing.Point(288, 133);
            this.textBoxFeePercentage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFeePercentage.Name = "textBoxFeePercentage";
            this.textBoxFeePercentage.Size = new System.Drawing.Size(227, 23);
            this.textBoxFeePercentage.TabIndex = 28;
            // 
            // lblFeePercentage
            // 
            this.lblFeePercentage.AutoSize = true;
            this.lblFeePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFeePercentage.Location = new System.Drawing.Point(16, 129);
            this.lblFeePercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeePercentage.Name = "lblFeePercentage";
            this.lblFeePercentage.Size = new System.Drawing.Size(151, 25);
            this.lblFeePercentage.TabIndex = 29;
            this.lblFeePercentage.Text = "Fee Percentage";
            // 
            // textBoxPaymentAmount
            // 
            this.textBoxPaymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPaymentAmount.Location = new System.Drawing.Point(288, 102);
            this.textBoxPaymentAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPaymentAmount.Name = "textBoxPaymentAmount";
            this.textBoxPaymentAmount.Size = new System.Drawing.Size(227, 23);
            this.textBoxPaymentAmount.TabIndex = 26;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPaymentAmount.Location = new System.Drawing.Point(16, 98);
            this.lblPaymentAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(162, 25);
            this.lblPaymentAmount.TabIndex = 27;
            this.lblPaymentAmount.Text = "Payment Amount";
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(288, 63);
            this.dateTimePickerDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(225, 30);
            this.dateTimePickerDateFrom.TabIndex = 25;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateFrom.Location = new System.Drawing.Point(15, 66);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(103, 25);
            this.lblDateFrom.TabIndex = 24;
            this.lblDateFrom.Text = "Date From";
            // 
            // comboBoxPaymentFrequency
            // 
            this.comboBoxPaymentFrequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaymentFrequency.FormattingEnabled = true;
            this.comboBoxPaymentFrequency.Location = new System.Drawing.Point(288, 28);
            this.comboBoxPaymentFrequency.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPaymentFrequency.Name = "comboBoxPaymentFrequency";
            this.comboBoxPaymentFrequency.Size = new System.Drawing.Size(225, 24);
            this.comboBoxPaymentFrequency.TabIndex = 23;
            // 
            // lblPaymentFrequency
            // 
            this.lblPaymentFrequency.AutoSize = true;
            this.lblPaymentFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPaymentFrequency.Location = new System.Drawing.Point(16, 26);
            this.lblPaymentFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentFrequency.Name = "lblPaymentFrequency";
            this.lblPaymentFrequency.Size = new System.Drawing.Size(176, 25);
            this.lblPaymentFrequency.TabIndex = 7;
            this.lblPaymentFrequency.Text = "Payment Frequecy";
            // 
            // panelDateInput
            // 
            this.panelDateInput.Controls.Add(this.dateTimePickerStartDate);
            this.panelDateInput.Controls.Add(this.lblStartDate);
            this.panelDateInput.Controls.Add(this.dateTimePickerEndDate);
            this.panelDateInput.Controls.Add(this.lblEndDate);
            this.panelDateInput.Controls.Add(this.dateTimePickerDateSigned);
            this.panelDateInput.Controls.Add(this.lblDateSigned);
            this.panelDateInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDateInput.Location = new System.Drawing.Point(0, 658);
            this.panelDateInput.Margin = new System.Windows.Forms.Padding(4);
            this.panelDateInput.Name = "panelDateInput";
            this.panelDateInput.Size = new System.Drawing.Size(1088, 129);
            this.panelDateInput.TabIndex = 27;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(288, 47);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(225, 30);
            this.dateTimePickerStartDate.TabIndex = 31;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStartDate.Location = new System.Drawing.Point(15, 53);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(99, 25);
            this.lblStartDate.TabIndex = 30;
            this.lblStartDate.Text = "Start Date";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(288, 86);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(225, 30);
            this.dateTimePickerEndDate.TabIndex = 29;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEndDate.Location = new System.Drawing.Point(15, 92);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 25);
            this.lblEndDate.TabIndex = 28;
            this.lblEndDate.Text = "End Date";
            // 
            // dateTimePickerDateSigned
            // 
            this.dateTimePickerDateSigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDateSigned.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateSigned.Location = new System.Drawing.Point(288, 7);
            this.dateTimePickerDateSigned.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDateSigned.Name = "dateTimePickerDateSigned";
            this.dateTimePickerDateSigned.Size = new System.Drawing.Size(225, 30);
            this.dateTimePickerDateSigned.TabIndex = 27;
            // 
            // lblDateSigned
            // 
            this.lblDateSigned.AutoSize = true;
            this.lblDateSigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateSigned.Location = new System.Drawing.Point(15, 14);
            this.lblDateSigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateSigned.Name = "lblDateSigned";
            this.lblDateSigned.Size = new System.Drawing.Size(120, 25);
            this.lblDateSigned.TabIndex = 26;
            this.lblDateSigned.Text = "Date Signed";
            // 
            // panelUnderContractInput
            // 
            this.panelUnderContractInput.Controls.Add(this.comboBoxEstateUnderContract);
            this.panelUnderContractInput.Controls.Add(this.lblEstateUnderContract);
            this.panelUnderContractInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUnderContractInput.Location = new System.Drawing.Point(0, 787);
            this.panelUnderContractInput.Margin = new System.Windows.Forms.Padding(4);
            this.panelUnderContractInput.Name = "panelUnderContractInput";
            this.panelUnderContractInput.Size = new System.Drawing.Size(1088, 54);
            this.panelUnderContractInput.TabIndex = 29;
            // 
            // comboBoxEstateUnderContract
            // 
            this.comboBoxEstateUnderContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstateUnderContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEstateUnderContract.FormattingEnabled = true;
            this.comboBoxEstateUnderContract.Location = new System.Drawing.Point(288, 7);
            this.comboBoxEstateUnderContract.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEstateUnderContract.Name = "comboBoxEstateUnderContract";
            this.comboBoxEstateUnderContract.Size = new System.Drawing.Size(225, 24);
            this.comboBoxEstateUnderContract.TabIndex = 25;
            // 
            // lblEstateUnderContract
            // 
            this.lblEstateUnderContract.AutoSize = true;
            this.lblEstateUnderContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEstateUnderContract.Location = new System.Drawing.Point(16, 7);
            this.lblEstateUnderContract.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstateUnderContract.Name = "lblEstateUnderContract";
            this.lblEstateUnderContract.Size = new System.Drawing.Size(204, 25);
            this.lblEstateUnderContract.TabIndex = 24;
            this.lblEstateUnderContract.Text = "Estate Under Contract";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAddConract);
            this.panelButtons.Controls.Add(this.btnClearForm);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 791);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1088, 123);
            this.panelButtons.TabIndex = 30;
            // 
            // btnAddConract
            // 
            this.btnAddConract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btnAddConract.FlatAppearance.BorderSize = 0;
            this.btnAddConract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddConract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnAddConract.Location = new System.Drawing.Point(179, 14);
            this.btnAddConract.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddConract.Name = "btnAddConract";
            this.btnAddConract.Size = new System.Drawing.Size(187, 49);
            this.btnAddConract.TabIndex = 10;
            this.btnAddConract.Text = "Add Contract";
            this.btnAddConract.UseVisualStyleBackColor = false;
            this.btnAddConract.Click += new System.EventHandler(this.btnAddConract_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btnClearForm.FlatAppearance.BorderSize = 0;
            this.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClearForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnClearForm.Location = new System.Drawing.Point(437, 14);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(187, 49);
            this.btnClearForm.TabIndex = 11;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = false;
            // 
            // FormAddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 914);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelUnderContractInput);
            this.Controls.Add(this.panelDateInput);
            this.Controls.Add(this.panelFinancialInput);
            this.Controls.Add(this.panelTransactionInfoInput);
            this.Controls.Add(this.panelContractInfoInput);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormAddContract";
            this.Text = "FormAddContract";
            this.panelContractInfoInput.ResumeLayout(false);
            this.panelContractInfoInput.PerformLayout();
            this.panelTransactionInfoInput.ResumeLayout(false);
            this.panelTransactionInfoInput.PerformLayout();
            this.panelFinancialInput.ResumeLayout(false);
            this.panelFinancialInput.PerformLayout();
            this.panelDateInput.ResumeLayout(false);
            this.panelDateInput.PerformLayout();
            this.panelUnderContractInput.ResumeLayout(false);
            this.panelUnderContractInput.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContractInfoInput;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel panelTransactionInfoInput;
        private System.Windows.Forms.RichTextBox richTextBoxTrasactionDetail;
        private System.Windows.Forms.Label lblTransactionDetail;
        private System.Windows.Forms.DateTimePicker dateTimePickerTrasactionDate;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.ComboBox comboBoxClientRequested;
        private System.Windows.Forms.Label lblClientRequested;
        private System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.ComboBox comboBoxClientOffered;
        private System.Windows.Forms.Label lblClientOffered;
        private System.Windows.Forms.Panel panelFinancialInput;
        private System.Windows.Forms.TextBox textBoxFeePercentage;
        private System.Windows.Forms.Label lblFeePercentage;
        private System.Windows.Forms.TextBox textBoxPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.ComboBox comboBoxPaymentFrequency;
        private System.Windows.Forms.Label lblPaymentFrequency;
        private System.Windows.Forms.Panel panelDateInput;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSigned;
        private System.Windows.Forms.Label lblDateSigned;
        private System.Windows.Forms.Panel panelUnderContractInput;
        private System.Windows.Forms.ComboBox comboBoxEstateUnderContract;
        private System.Windows.Forms.Label lblEstateUnderContract;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAddConract;
        private System.Windows.Forms.Button btnClearForm;
    }
}