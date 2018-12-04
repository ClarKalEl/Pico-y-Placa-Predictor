namespace Pico_y_Placa_Predictor
{
    partial class FormSplash
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
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxSplash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSplash
            // 
            this.timerSplash.Enabled = true;
            this.timerSplash.Interval = 3500;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // pictureBoxSplash
            // 
            this.pictureBoxSplash.BackgroundImage = global::Pico_y_Placa_Predictor.Properties.Resources.Pico_y_Placa_Predictor_Splash_Screen_WinForms;
            this.pictureBoxSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSplash.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSplash.MaximumSize = new System.Drawing.Size(750, 428);
            this.pictureBoxSplash.MinimumSize = new System.Drawing.Size(750, 428);
            this.pictureBoxSplash.Name = "pictureBoxSplash";
            this.pictureBoxSplash.Size = new System.Drawing.Size(750, 428);
            this.pictureBoxSplash.TabIndex = 0;
            this.pictureBoxSplash.TabStop = false;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(750, 428);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxSplash);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 428);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 428);
            this.Name = "FormSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplash";
            this.TransparencyKey = System.Drawing.Color.Blue;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.PictureBox pictureBoxSplash;
    }
}