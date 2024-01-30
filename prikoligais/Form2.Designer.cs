namespace prikoligais
{
    partial class Form2
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
            this.Pierakstities = new System.Windows.Forms.Button();
            this.Ienākt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Parole = new System.Windows.Forms.TextBox();
            this.E_pasts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Pierakstities
            // 
            this.Pierakstities.Location = new System.Drawing.Point(370, 294);
            this.Pierakstities.Name = "Pierakstities";
            this.Pierakstities.Size = new System.Drawing.Size(142, 46);
            this.Pierakstities.TabIndex = 22;
            this.Pierakstities.Text = "Pierakstities";
            this.Pierakstities.UseVisualStyleBackColor = true;
            this.Pierakstities.Click += new System.EventHandler(this.Pierakstities_Click);
            // 
            // Ienākt
            // 
            this.Ienākt.Location = new System.Drawing.Point(370, 224);
            this.Ienākt.Name = "Ienākt";
            this.Ienākt.Size = new System.Drawing.Size(142, 46);
            this.Ienākt.TabIndex = 21;
            this.Ienākt.Text = "Ienākt";
            this.Ienākt.UseVisualStyleBackColor = true;
            this.Ienākt.Click += new System.EventHandler(this.Ienākt_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Parole";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "E_pasts";
            // 
            // Parole
            // 
            this.Parole.Location = new System.Drawing.Point(340, 153);
            this.Parole.Name = "Parole";
            this.Parole.Size = new System.Drawing.Size(163, 20);
            this.Parole.TabIndex = 18;
            // 
            // E_pasts
            // 
            this.E_pasts.Location = new System.Drawing.Point(340, 111);
            this.E_pasts.Name = "E_pasts";
            this.E_pasts.Size = new System.Drawing.Size(163, 20);
            this.E_pasts.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pierakstities);
            this.Controls.Add(this.Ienākt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Parole);
            this.Controls.Add(this.E_pasts);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pierakstities;
        private System.Windows.Forms.Button Ienākt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Parole;
        private System.Windows.Forms.TextBox E_pasts;
    }
}