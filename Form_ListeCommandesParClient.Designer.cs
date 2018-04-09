namespace TP_GestionCommerciale
{
    partial class Form_ListeCommandesParClient
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
            this.label_code = new System.Windows.Forms.Label();
            this.label_ville = new System.Windows.Forms.Label();
            this.comboBox_nom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_commandes = new System.Windows.Forms.DataGridView();
            this.NumCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_commandes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des Commandes par Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Client : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville : ";
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Location = new System.Drawing.Point(125, 154);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(23, 13);
            this.label_code.TabIndex = 4;
            this.label_code.Text = "null";
            // 
            // label_ville
            // 
            this.label_ville.AutoSize = true;
            this.label_ville.Location = new System.Drawing.Point(297, 154);
            this.label_ville.Name = "label_ville";
            this.label_ville.Size = new System.Drawing.Size(23, 13);
            this.label_ville.TabIndex = 5;
            this.label_ville.Text = "null";
            // 
            // comboBox_nom
            // 
            this.comboBox_nom.FormattingEnabled = true;
            this.comboBox_nom.Location = new System.Drawing.Point(155, 112);
            this.comboBox_nom.Name = "comboBox_nom";
            this.comboBox_nom.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nom.TabIndex = 6;
            this.comboBox_nom.SelectedIndexChanged += new System.EventHandler(this.comboBox_nom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Liste des commandes";
            // 
            // dataGridView_commandes
            // 
            this.dataGridView_commandes.AllowUserToAddRows = false;
            this.dataGridView_commandes.AllowUserToDeleteRows = false;
            this.dataGridView_commandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_commandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_commandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCom,
            this.Date,
            this.Detail});
            this.dataGridView_commandes.Location = new System.Drawing.Point(36, 215);
            this.dataGridView_commandes.Name = "dataGridView_commandes";
            this.dataGridView_commandes.ReadOnly = true;
            this.dataGridView_commandes.Size = new System.Drawing.Size(443, 181);
            this.dataGridView_commandes.TabIndex = 8;
            this.dataGridView_commandes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_commandes_CellContentClick);
            // 
            // NumCom
            // 
            this.NumCom.HeaderText = "NumCom";
            this.NumCom.Name = "NumCom";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.Text = "Voir";
            this.Detail.UseColumnTextForButtonValue = true;
            // 
            // Form_ListeCommandesParClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.dataGridView_commandes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_nom);
            this.Controls.Add(this.label_ville);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_ListeCommandesParClient";
            this.Text = "Form_ListeCommandesParClient";
            this.Load += new System.EventHandler(this.Form_ListeCommandesParClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_commandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label label_ville;
        private System.Windows.Forms.ComboBox comboBox_nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_commandes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
    }
}