namespace FLSM
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.numIp1 = new System.Windows.Forms.NumericUpDown();
            this.numIp2 = new System.Windows.Forms.NumericUpDown();
            this.numIp3 = new System.Windows.Forms.NumericUpDown();
            this.numIp4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSottoreti = new System.Windows.Forms.NumericUpDown();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioSottoreti = new System.Windows.Forms.RadioButton();
            this.radioHost = new System.Windows.Forms.RadioButton();
            this.numHosts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSottoreti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHosts)).BeginInit();
            this.SuspendLayout();
            // 
            // numIp1
            // 
            this.numIp1.Location = new System.Drawing.Point(13, 34);
            this.numIp1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numIp1.Name = "numIp1";
            this.numIp1.Size = new System.Drawing.Size(46, 20);
            this.numIp1.TabIndex = 0;
            this.numIp1.ValueChanged += new System.EventHandler(this.numIp1_ValueChanged);
            // 
            // numIp2
            // 
            this.numIp2.Location = new System.Drawing.Point(65, 34);
            this.numIp2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numIp2.Name = "numIp2";
            this.numIp2.Size = new System.Drawing.Size(46, 20);
            this.numIp2.TabIndex = 1;
            // 
            // numIp3
            // 
            this.numIp3.Location = new System.Drawing.Point(117, 34);
            this.numIp3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numIp3.Name = "numIp3";
            this.numIp3.Size = new System.Drawing.Size(46, 20);
            this.numIp3.TabIndex = 2;
            // 
            // numIp4
            // 
            this.numIp4.Location = new System.Drawing.Point(169, 34);
            this.numIp4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numIp4.Name = "numIp4";
            this.numIp4.Size = new System.Drawing.Size(46, 20);
            this.numIp4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Indirizzo IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero minimo di sottoreti";
            // 
            // numSottoreti
            // 
            this.numSottoreti.Location = new System.Drawing.Point(263, 34);
            this.numSottoreti.Name = "numSottoreti";
            this.numSottoreti.Size = new System.Drawing.Size(128, 20);
            this.numSottoreti.TabIndex = 6;
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Location = new System.Drawing.Point(646, 13);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(152, 41);
            this.btnAggiorna.TabIndex = 7;
            this.btnAggiorna.Text = "Aggiorna";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(786, 377);
            this.dataGridView1.TabIndex = 8;
            // 
            // radioSottoreti
            // 
            this.radioSottoreti.AutoSize = true;
            this.radioSottoreti.Checked = true;
            this.radioSottoreti.Location = new System.Drawing.Point(243, 37);
            this.radioSottoreti.Name = "radioSottoreti";
            this.radioSottoreti.Size = new System.Drawing.Size(14, 13);
            this.radioSottoreti.TabIndex = 9;
            this.radioSottoreti.TabStop = true;
            this.radioSottoreti.UseVisualStyleBackColor = true;
            // 
            // radioHost
            // 
            this.radioHost.AutoSize = true;
            this.radioHost.Location = new System.Drawing.Point(431, 37);
            this.radioHost.Name = "radioHost";
            this.radioHost.Size = new System.Drawing.Size(14, 13);
            this.radioHost.TabIndex = 12;
            this.radioHost.UseVisualStyleBackColor = true;
            // 
            // numHosts
            // 
            this.numHosts.Location = new System.Drawing.Point(451, 34);
            this.numHosts.Name = "numHosts";
            this.numHosts.Size = new System.Drawing.Size(128, 20);
            this.numHosts.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numero minimo di host per rete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.radioHost);
            this.Controls.Add(this.numHosts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioSottoreti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.numSottoreti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numIp4);
            this.Controls.Add(this.numIp3);
            this.Controls.Add(this.numIp2);
            this.Controls.Add(this.numIp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FLSM";
            ((System.ComponentModel.ISupportInitialize)(this.numIp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSottoreti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numIp1;
        private System.Windows.Forms.NumericUpDown numIp2;
        private System.Windows.Forms.NumericUpDown numIp3;
        private System.Windows.Forms.NumericUpDown numIp4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSottoreti;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioSottoreti;
        private System.Windows.Forms.RadioButton radioHost;
        private System.Windows.Forms.NumericUpDown numHosts;
        private System.Windows.Forms.Label label3;
    }
}

