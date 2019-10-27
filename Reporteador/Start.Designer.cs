namespace Reporteador
{
    partial class Start
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
            this.TextoX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextoX
            // 
            this.TextoX.AutoSize = true;
            this.TextoX.Location = new System.Drawing.Point(375, 225);
            this.TextoX.Name = "TextoX";
            this.TextoX.Size = new System.Drawing.Size(91, 13);
            this.TextoX.TabIndex = 0;
            this.TextoX.Text = "Reporteador ABD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextoX);
            this.Name = "Form1";
            this.Text = "Reporteador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextoX;
    }
}

