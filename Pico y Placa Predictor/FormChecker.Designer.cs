namespace Pico_y_Placa_Predictor
{
    partial class FormChecker
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.mTBTime = new System.Windows.Forms.MaskedTextBox();
            this.mTBDate = new System.Windows.Forms.MaskedTextBox();
            this.mTBLicensePlate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelVerdict = new System.Windows.Forms.Label();
            this.labelCommentaries = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(-2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(751, 106);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Checker";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the Data and then Click on Check";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonCheck);
            this.groupBox1.Controls.Add(this.mTBTime);
            this.groupBox1.Controls.Add(this.mTBDate);
            this.groupBox1.Controls.Add(this.mTBLicensePlate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(160)))));
            this.buttonCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(83)))), ((int)(((byte)(210)))));
            this.buttonCheck.FlatAppearance.BorderSize = 2;
            this.buttonCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.buttonCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(83)))), ((int)(((byte)(210)))));
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(443, 41);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(187, 79);
            this.buttonCheck.TabIndex = 6;
            this.buttonCheck.Text = "Check!";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // mTBTime
            // 
            this.mTBTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTBTime.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mTBTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBTime.Location = new System.Drawing.Point(245, 105);
            this.mTBTime.Margin = new System.Windows.Forms.Padding(5);
            this.mTBTime.Mask = "00:00";
            this.mTBTime.Name = "mTBTime";
            this.mTBTime.PromptChar = ' ';
            this.mTBTime.Size = new System.Drawing.Size(89, 29);
            this.mTBTime.TabIndex = 5;
            this.mTBTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTBTime.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.toolTipInfo.SetToolTip(this.mTBTime, "Use 24 Time-Format Please");
            this.mTBTime.ValidatingType = typeof(System.DateTime);
            this.mTBTime.TextChanged += new System.EventHandler(this.mTBTime_TextChanged);
            // 
            // mTBDate
            // 
            this.mTBDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTBDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBDate.HidePromptOnLeave = true;
            this.mTBDate.Location = new System.Drawing.Point(199, 65);
            this.mTBDate.Margin = new System.Windows.Forms.Padding(5);
            this.mTBDate.Mask = "00/00/0000";
            this.mTBDate.Name = "mTBDate";
            this.mTBDate.RejectInputOnFirstFailure = true;
            this.mTBDate.Size = new System.Drawing.Size(185, 29);
            this.mTBDate.TabIndex = 4;
            this.mTBDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipInfo.SetToolTip(this.mTBDate, "Use the Format dd/MM/YYYY for the Date Please");
            this.mTBDate.ValidatingType = typeof(System.DateTime);
            this.mTBDate.TextChanged += new System.EventHandler(this.mTBDate_TextChanged);
            // 
            // mTBLicensePlate
            // 
            this.mTBLicensePlate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTBLicensePlate.AsciiOnly = true;
            this.mTBLicensePlate.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mTBLicensePlate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBLicensePlate.HidePromptOnLeave = true;
            this.mTBLicensePlate.Location = new System.Drawing.Point(199, 25);
            this.mTBLicensePlate.Margin = new System.Windows.Forms.Padding(5);
            this.mTBLicensePlate.Mask = "aaa - 0000";
            this.mTBLicensePlate.Name = "mTBLicensePlate";
            this.mTBLicensePlate.RejectInputOnFirstFailure = true;
            this.mTBLicensePlate.Size = new System.Drawing.Size(185, 29);
            this.mTBLicensePlate.TabIndex = 3;
            this.mTBLicensePlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipInfo.SetToolTip(this.mTBLicensePlate, "Enter the Full Licence Plate Number Please. The 3 letter part must be UPPERCASE. " +
        "If your License Plate Numbers has less than 4 Digits, fill it with 0 on left unt" +
        "il have 4 Digits.");
            this.mTBLicensePlate.TabIndexChanged += new System.EventHandler(this.mTBLicensePlate_TabIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 25, 10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Licence Plate Number:";
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo.ToolTipTitle = "Info";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelVerdict);
            this.groupBox2.Controls.Add(this.labelCommentaries);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 301);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 117);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // labelVerdict
            // 
            this.labelVerdict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVerdict.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerdict.ForeColor = System.Drawing.Color.Black;
            this.labelVerdict.Location = new System.Drawing.Point(6, 17);
            this.labelVerdict.Name = "labelVerdict";
            this.labelVerdict.Size = new System.Drawing.Size(679, 34);
            this.labelVerdict.TabIndex = 6;
            this.labelVerdict.Text = "You are Authorized to Drive, Good Travel! : )";
            this.labelVerdict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVerdict.Visible = false;
            // 
            // labelCommentaries
            // 
            this.labelCommentaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCommentaries.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentaries.ForeColor = System.Drawing.Color.Black;
            this.labelCommentaries.Location = new System.Drawing.Point(6, 45);
            this.labelCommentaries.Name = "labelCommentaries";
            this.labelCommentaries.Size = new System.Drawing.Size(679, 69);
            this.labelCommentaries.TabIndex = 7;
            this.labelCommentaries.Text = "•••";
            this.labelCommentaries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChecker
            // 
            this.AcceptButton = this.buttonCheck;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(749, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(749, 421);
            this.MinimumSize = new System.Drawing.Size(749, 421);
            this.Name = "FormChecker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormChecker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mTBTime;
        private System.Windows.Forms.MaskedTextBox mTBDate;
        private System.Windows.Forms.MaskedTextBox mTBLicensePlate;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelVerdict;
        private System.Windows.Forms.Label labelCommentaries;
    }
}