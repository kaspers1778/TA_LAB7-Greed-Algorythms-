namespace Greed_Algorythms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_randomAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Accounts = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.mtb_randomAccountsAmount = new System.Windows.Forms.MaskedTextBox();
            this.mtb_addAccountMoney = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Accounts = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_findAmountMoneyToSave = new System.Windows.Forms.Button();
            this.txb_output = new System.Windows.Forms.TextBox();
            this.mtb_percent = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Accounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of money on account :";
            // 
            // btn_addAccount
            // 
            this.btn_addAccount.Location = new System.Drawing.Point(9, 54);
            this.btn_addAccount.Name = "btn_addAccount";
            this.btn_addAccount.Size = new System.Drawing.Size(99, 23);
            this.btn_addAccount.TabIndex = 2;
            this.btn_addAccount.Text = "Add an account";
            this.btn_addAccount.UseVisualStyleBackColor = true;
            this.btn_addAccount.Click += new System.EventHandler(this.btn_addAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of accounts to random :";
            // 
            // btn_randomAccount
            // 
            this.btn_randomAccount.Location = new System.Drawing.Point(9, 110);
            this.btn_randomAccount.Name = "btn_randomAccount";
            this.btn_randomAccount.Size = new System.Drawing.Size(108, 23);
            this.btn_randomAccount.TabIndex = 5;
            this.btn_randomAccount.Text = "Random accounts";
            this.btn_randomAccount.UseVisualStyleBackColor = true;
            this.btn_randomAccount.Click += new System.EventHandler(this.btn_randomAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Percent for transaction :";
            // 
            // Accounts
            // 
            this.Accounts.Controls.Add(this.btn_clear);
            this.Accounts.Controls.Add(this.mtb_randomAccountsAmount);
            this.Accounts.Controls.Add(this.mtb_addAccountMoney);
            this.Accounts.Controls.Add(this.dgv_Accounts);
            this.Accounts.Controls.Add(this.label1);
            this.Accounts.Controls.Add(this.btn_addAccount);
            this.Accounts.Controls.Add(this.btn_randomAccount);
            this.Accounts.Controls.Add(this.label2);
            this.Accounts.Location = new System.Drawing.Point(12, 15);
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(298, 436);
            this.Accounts.TabIndex = 8;
            this.Accounts.TabStop = false;
            this.Accounts.Text = "Accounts";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(6, 408);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // mtb_randomAccountsAmount
            // 
            this.mtb_randomAccountsAmount.Location = new System.Drawing.Point(164, 91);
            this.mtb_randomAccountsAmount.Mask = "000000";
            this.mtb_randomAccountsAmount.Name = "mtb_randomAccountsAmount";
            this.mtb_randomAccountsAmount.Size = new System.Drawing.Size(47, 20);
            this.mtb_randomAccountsAmount.TabIndex = 8;
            // 
            // mtb_addAccountMoney
            // 
            this.mtb_addAccountMoney.Location = new System.Drawing.Point(164, 35);
            this.mtb_addAccountMoney.Mask = "00000";
            this.mtb_addAccountMoney.Name = "mtb_addAccountMoney";
            this.mtb_addAccountMoney.Size = new System.Drawing.Size(36, 20);
            this.mtb_addAccountMoney.TabIndex = 7;
            // 
            // dgv_Accounts
            // 
            this.dgv_Accounts.AllowUserToAddRows = false;
            this.dgv_Accounts.AllowUserToDeleteRows = false;
            this.dgv_Accounts.AllowUserToResizeColumns = false;
            this.dgv_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Money});
            this.dgv_Accounts.Location = new System.Drawing.Point(9, 139);
            this.dgv_Accounts.Name = "dgv_Accounts";
            this.dgv_Accounts.RowHeadersVisible = false;
            this.dgv_Accounts.Size = new System.Drawing.Size(202, 263);
            this.dgv_Accounts.TabIndex = 6;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Money
            // 
            this.Money.HeaderText = "Money";
            this.Money.Name = "Money";
            // 
            // btn_findAmountMoneyToSave
            // 
            this.btn_findAmountMoneyToSave.Location = new System.Drawing.Point(6, 62);
            this.btn_findAmountMoneyToSave.Name = "btn_findAmountMoneyToSave";
            this.btn_findAmountMoneyToSave.Size = new System.Drawing.Size(179, 23);
            this.btn_findAmountMoneyToSave.TabIndex = 9;
            this.btn_findAmountMoneyToSave.Text = "Find how much money can save ";
            this.btn_findAmountMoneyToSave.UseVisualStyleBackColor = true;
            this.btn_findAmountMoneyToSave.Click += new System.EventHandler(this.btn_findAmountMoneyToSave_Click);
            // 
            // txb_output
            // 
            this.txb_output.Location = new System.Drawing.Point(192, 64);
            this.txb_output.Name = "txb_output";
            this.txb_output.ReadOnly = true;
            this.txb_output.Size = new System.Drawing.Size(100, 20);
            this.txb_output.TabIndex = 10;
            // 
            // mtb_percent
            // 
            this.mtb_percent.Location = new System.Drawing.Point(132, 40);
            this.mtb_percent.Mask = "00";
            this.mtb_percent.Name = "mtb_percent";
            this.mtb_percent.Size = new System.Drawing.Size(20, 20);
            this.mtb_percent.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtb_percent);
            this.groupBox1.Controls.Add(this.btn_findAmountMoneyToSave);
            this.groupBox1.Controls.Add(this.txb_output);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 104);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Merge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Accounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Coruptionist helper";
            this.Accounts.ResumeLayout(false);
            this.Accounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_randomAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Accounts;
        private System.Windows.Forms.DataGridView dgv_Accounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.MaskedTextBox mtb_addAccountMoney;
        private System.Windows.Forms.MaskedTextBox mtb_randomAccountsAmount;
        private System.Windows.Forms.Button btn_findAmountMoneyToSave;
        private System.Windows.Forms.TextBox txb_output;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.MaskedTextBox mtb_percent;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

