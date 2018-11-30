namespace Pico_y_Placa_Predictor
{
    partial class FormFarewell
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
            this.labelBye = new System.Windows.Forms.Label();
            this.labelGreat = new System.Windows.Forms.Label();
            this.labelFarewell = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBye
            // 
            this.labelBye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBye.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBye.Location = new System.Drawing.Point(0, 300);
            this.labelBye.Name = "labelBye";
            this.labelBye.Size = new System.Drawing.Size(751, 54);
            this.labelBye.TabIndex = 6;
            this.labelBye.Text = "Bye! :)";
            this.labelBye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGreat
            // 
            this.labelGreat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGreat.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreat.Location = new System.Drawing.Point(0, 226);
            this.labelGreat.Name = "labelGreat";
            this.labelGreat.Size = new System.Drawing.Size(751, 55);
            this.labelGreat.TabIndex = 5;
            this.labelGreat.Text = "Was great to help you! Come back whenever you want";
            this.labelGreat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFarewell
            // 
            this.labelFarewell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFarewell.Font = new System.Drawing.Font("Segoe UI Light", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFarewell.Location = new System.Drawing.Point(0, 9);
            this.labelFarewell.Name = "labelFarewell";
            this.labelFarewell.Size = new System.Drawing.Size(751, 254);
            this.labelFarewell.TabIndex = 4;
            this.labelFarewell.Text = "You are all Set";
            this.labelFarewell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFarewell
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(749, 421);
            this.Controls.Add(this.labelBye);
            this.Controls.Add(this.labelGreat);
            this.Controls.Add(this.labelFarewell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(749, 421);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(749, 421);
            this.Name = "FormFarewell";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormFarewell";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBye;
        private System.Windows.Forms.Label labelGreat;
        private System.Windows.Forms.Label labelFarewell;
    }
}