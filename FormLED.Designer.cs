namespace ArduinoTemperaturaFormsFramework_2022_II
{
    partial class FormLED
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
            this.ptbLED = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLED)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLED
            // 
            this.ptbLED.Image = global::ArduinoTemperaturaFormsFramework_2022_II.Properties.Resources.foco;
            this.ptbLED.Location = new System.Drawing.Point(510, 166);
            this.ptbLED.Name = "ptbLED";
            this.ptbLED.Size = new System.Drawing.Size(675, 807);
            this.ptbLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLED.TabIndex = 0;
            this.ptbLED.TabStop = false;
            this.ptbLED.Click += new System.EventHandler(this.ptbLED_Click);
            // 
            // FormLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 1134);
            this.Controls.Add(this.ptbLED);
            this.Name = "FormLED";
            this.Text = "FormLED";
            ((System.ComponentModel.ISupportInitialize)(this.ptbLED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLED;
    }
}