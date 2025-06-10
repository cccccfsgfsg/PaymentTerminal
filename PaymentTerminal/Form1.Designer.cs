namespace PaymentTerminal
{
    partial class PaymentTerminalForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpService = new System.Windows.Forms.GroupBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpService.SuspendLayout();
            this.grpPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Платежный терминал";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpService
            // 
            this.grpService.Controls.Add(this.cmbService);
            this.grpService.Location = new System.Drawing.Point(50, 60);
            this.grpService.Name = "grpService";
            this.grpService.Size = new System.Drawing.Size(300, 100);
            this.grpService.TabIndex = 1;
            this.grpService.TabStop = false;
            this.grpService.Text = "Выберите услугу";
            this.grpService.Enter += new System.EventHandler(this.grpService_Enter);
            // 
            // cmbService
            // 
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Items.AddRange(new object[] {
            "Пополнение мобильного телефона",
            "Интернет",
            "Steam",
            "Другое"});
            this.cmbService.Location = new System.Drawing.Point(20, 30);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(121, 21);
            this.cmbService.TabIndex = 0;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.Controls.Add(this.txtAmount);
            this.grpPaymentDetails.Controls.Add(this.lblAmount);
            this.grpPaymentDetails.Controls.Add(this.txtPhoneNumber);
            this.grpPaymentDetails.Controls.Add(this.lblPhone);
            this.grpPaymentDetails.Location = new System.Drawing.Point(50, 170);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Size = new System.Drawing.Size(300, 150);
            this.grpPaymentDetails.TabIndex = 2;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Данные платежа";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 30);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(187, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Номер телефона (+7XXXXXXXXXX):";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(20, 50);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(250, 20);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 90);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(121, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Сумма (100-10000 руб)";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(20, 106);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(250, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(53, 355);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(138, 32);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Подтвердить платеж";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(222, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "пусто";
            // 
            // PaymentTerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpPaymentDetails);
            this.Controls.Add(this.grpService);
            this.Controls.Add(this.lblTitle);
            this.Name = "PaymentTerminalForm";
            this.Text = "Платежный терминал";
            this.Load += new System.EventHandler(this.PaymentTerminalForm_Load);
            this.grpService.ResumeLayout(false);
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpService;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStatus;
    }
}

