namespace TP_GestionCommerciale
{
    partial class Form_DetailCommande
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_numCommande = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_numClient = new System.Windows.Forms.TextBox();
            this.dataGridView_detail = new System.Windows.Forms.DataGridView();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.NumP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtteCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Détail Commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num Commande : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Num Client : ";
            // 
            // textBox_numCommande
            // 
            this.textBox_numCommande.Enabled = false;
            this.textBox_numCommande.Location = new System.Drawing.Point(184, 103);
            this.textBox_numCommande.Name = "textBox_numCommande";
            this.textBox_numCommande.Size = new System.Drawing.Size(134, 20);
            this.textBox_numCommande.TabIndex = 5;
            // 
            // textBox_date
            // 
            this.textBox_date.Enabled = false;
            this.textBox_date.Location = new System.Drawing.Point(184, 132);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(134, 20);
            this.textBox_date.TabIndex = 6;
            // 
            // textBox_numClient
            // 
            this.textBox_numClient.Enabled = false;
            this.textBox_numClient.Location = new System.Drawing.Point(184, 164);
            this.textBox_numClient.Name = "textBox_numClient";
            this.textBox_numClient.Size = new System.Drawing.Size(134, 20);
            this.textBox_numClient.TabIndex = 7;
            // 
            // dataGridView_detail
            // 
            this.dataGridView_detail.AllowUserToAddRows = false;
            this.dataGridView_detail.AllowUserToDeleteRows = false;
            this.dataGridView_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumP,
            this.Description,
            this.Prix,
            this.QtteCom,
            this.Supprimer});
            this.dataGridView_detail.Location = new System.Drawing.Point(49, 199);
            this.dataGridView_detail.Name = "dataGridView_detail";
            this.dataGridView_detail.Size = new System.Drawing.Size(470, 180);
            this.dataGridView_detail.TabIndex = 8;
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(431, 393);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 9;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // NumP
            // 
            this.NumP.HeaderText = "NumP";
            this.NumP.Name = "NumP";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // QtteCom
            // 
            this.QtteCom.HeaderText = "QtteCom";
            this.QtteCom.Name = "QtteCom";
            // 
            // Supprimer
            // 
            this.Supprimer.FalseValue = "False";
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.TrueValue = "True";
            // 
            // Form_DetailCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 428);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.dataGridView_detail);
            this.Controls.Add(this.textBox_numClient);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_numCommande);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_DetailCommande";
            this.Text = "Form_DetailCommande";
            this.Load += new System.EventHandler(this.Form_DetailCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_numCommande;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_numClient;
        private System.Windows.Forms.DataGridView dataGridView_detail;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtteCom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Supprimer;
    }
}