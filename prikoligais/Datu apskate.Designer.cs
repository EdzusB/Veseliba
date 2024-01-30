namespace prikoligais
{
    partial class Datu_apskate
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
            this.veselibas_dati = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.veselibas_dati)).BeginInit();
            this.SuspendLayout();
            // 
            // veselibas_dati
            // 
            this.veselibas_dati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veselibas_dati.Location = new System.Drawing.Point(12, 12);
            this.veselibas_dati.Name = "veselibas_dati";
            this.veselibas_dati.Size = new System.Drawing.Size(776, 353);
            this.veselibas_dati.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "fiziska_aktivitate",
            "lietotajs",
            "miegs",
            "uzturs"});
            this.comboBox1.Location = new System.Drawing.Point(331, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Datu_apskate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.veselibas_dati);
            this.Name = "Datu_apskate";
            this.Text = "Datu_apskate";
            ((System.ComponentModel.ISupportInitialize)(this.veselibas_dati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView veselibas_dati;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}