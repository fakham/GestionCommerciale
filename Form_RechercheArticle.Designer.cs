namespace TP_GestionCommerciale
{
    partial class Form_RechercheArticle
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
            this.checkBox_description = new System.Windows.Forms.CheckBox();
            this.checkBox_PU = new System.Windows.Forms.CheckBox();
            this.checkBox_QtteStock = new System.Windows.Forms.CheckBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_PU = new System.Windows.Forms.TextBox();
            this.textBox_QtteStock = new System.Windows.Forms.TextBox();
            this.button_recherche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_produits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Critère de Filter";
            // 
            // checkBox_description
            // 
            this.checkBox_description.AutoSize = true;
            this.checkBox_description.Location = new System.Drawing.Point(87, 95);
            this.checkBox_description.Name = "checkBox_description";
            this.checkBox_description.Size = new System.Drawing.Size(79, 17);
            this.checkBox_description.TabIndex = 1;
            this.checkBox_description.Text = "Description";
            this.checkBox_description.UseVisualStyleBackColor = true;
            // 
            // checkBox_PU
            // 
            this.checkBox_PU.AutoSize = true;
            this.checkBox_PU.Location = new System.Drawing.Point(87, 135);
            this.checkBox_PU.Name = "checkBox_PU";
            this.checkBox_PU.Size = new System.Drawing.Size(41, 17);
            this.checkBox_PU.TabIndex = 2;
            this.checkBox_PU.Text = "PU";
            this.checkBox_PU.UseVisualStyleBackColor = true;
            // 
            // checkBox_QtteStock
            // 
            this.checkBox_QtteStock.AutoSize = true;
            this.checkBox_QtteStock.Location = new System.Drawing.Point(87, 177);
            this.checkBox_QtteStock.Name = "checkBox_QtteStock";
            this.checkBox_QtteStock.Size = new System.Drawing.Size(77, 17);
            this.checkBox_QtteStock.TabIndex = 3;
            this.checkBox_QtteStock.Text = "Qtté Stock";
            this.checkBox_QtteStock.UseVisualStyleBackColor = true;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(198, 93);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(100, 20);
            this.textBox_description.TabIndex = 4;
            this.textBox_description.TextChanged += new System.EventHandler(this.textBox_description_TextChanged);
            // 
            // textBox_PU
            // 
            this.textBox_PU.Location = new System.Drawing.Point(198, 133);
            this.textBox_PU.Name = "textBox_PU";
            this.textBox_PU.Size = new System.Drawing.Size(100, 20);
            this.textBox_PU.TabIndex = 5;
            this.textBox_PU.TextChanged += new System.EventHandler(this.textBox_PU_TextChanged);
            // 
            // textBox_QtteStock
            // 
            this.textBox_QtteStock.Location = new System.Drawing.Point(198, 175);
            this.textBox_QtteStock.Name = "textBox_QtteStock";
            this.textBox_QtteStock.Size = new System.Drawing.Size(100, 20);
            this.textBox_QtteStock.TabIndex = 6;
            this.textBox_QtteStock.TextChanged += new System.EventHandler(this.textBox_QtteStock_TextChanged);
            // 
            // button_recherche
            // 
            this.button_recherche.Location = new System.Drawing.Point(364, 173);
            this.button_recherche.Name = "button_recherche";
            this.button_recherche.Size = new System.Drawing.Size(75, 23);
            this.button_recherche.TabIndex = 7;
            this.button_recherche.Text = "Recherche";
            this.button_recherche.UseVisualStyleBackColor = true;
            this.button_recherche.Click += new System.EventHandler(this.button_recherche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Produits";
            // 
            // dataGridView_produits
            // 
            this.dataGridView_produits.AllowUserToAddRows = false;
            this.dataGridView_produits.AllowUserToDeleteRows = false;
            this.dataGridView_produits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_produits.Location = new System.Drawing.Point(30, 262);
            this.dataGridView_produits.Name = "dataGridView_produits";
            this.dataGridView_produits.ReadOnly = true;
            this.dataGridView_produits.Size = new System.Drawing.Size(409, 150);
            this.dataGridView_produits.TabIndex = 9;
            // 
            // Form_RechercheArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 424);
            this.Controls.Add(this.dataGridView_produits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_recherche);
            this.Controls.Add(this.textBox_QtteStock);
            this.Controls.Add(this.textBox_PU);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.checkBox_QtteStock);
            this.Controls.Add(this.checkBox_PU);
            this.Controls.Add(this.checkBox_description);
            this.Controls.Add(this.label1);
            this.Name = "Form_RechercheArticle";
            this.Text = "Form_RechercheArticle";
            this.Load += new System.EventHandler(this.Form_RechercheArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_description;
        private System.Windows.Forms.CheckBox checkBox_PU;
        private System.Windows.Forms.CheckBox checkBox_QtteStock;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_PU;
        private System.Windows.Forms.TextBox textBox_QtteStock;
        private System.Windows.Forms.Button button_recherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_produits;
    }
}