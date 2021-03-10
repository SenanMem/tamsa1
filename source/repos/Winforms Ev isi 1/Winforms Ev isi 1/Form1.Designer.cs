
namespace Winforms_Ev_isi_1
{
    partial class BakuOrLondon
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
            this.button1 = new System.Windows.Forms.Button();
            this.London = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::Winforms_Ev_isi_1.Properties.Resources.Baku;
            this.button1.Location = new System.Drawing.Point(28, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 135);
            this.button1.TabIndex = 0;
            this.button1.Text = "History of London";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // London
            // 
            this.London.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.London.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.London.Image = global::Winforms_Ev_isi_1.Properties.Resources.download;
            this.London.Location = new System.Drawing.Point(363, 101);
            this.London.Name = "London";
            this.London.Size = new System.Drawing.Size(223, 135);
            this.London.TabIndex = 1;
            this.London.Text = "History of London";
            this.London.UseVisualStyleBackColor = true;
            // 
            // BakuOrLondon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Winforms_Ev_isi_1.Properties.Resources.Ilk_sekil;
            this.ClientSize = new System.Drawing.Size(598, 300);
            this.Controls.Add(this.London);
            this.Controls.Add(this.button1);
            this.Name = "BakuOrLondon";
            this.Text = "Dunya";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button London;
    }
}

