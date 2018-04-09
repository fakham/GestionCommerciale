namespace TP_GestionCommerciale
{
    partial class Form_MAJ_Article
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
            this.button_quitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.textBox_codeR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_last = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_pre = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.textBox_pu = new System.Windows.Forms.TextBox();
            this.textBox_des = new System.Windows.Forms.TextBox();
            this.textBox_codeArt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(178, 335);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(75, 23);
            this.button_quitter.TabIndex = 33;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_rechercher);
            this.groupBox1.Controls.Add(this.textBox_codeR);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(299, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 125);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche : ";
            // 
            // button_rechercher
            // 
            this.button_rechercher.Location = new System.Drawing.Point(96, 35);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(75, 23);
            this.button_rechercher.TabIndex = 16;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.UseVisualStyleBackColor = true;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // textBox_codeR
            // 
            this.textBox_codeR.Location = new System.Drawing.Point(96, 81);
            this.textBox_codeR.Name = "textBox_codeR";
            this.textBox_codeR.Size = new System.Drawing.Size(85, 20);
            this.textBox_codeR.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Code Client : ";
            // 
            // button_last
            // 
            this.button_last.Location = new System.Drawing.Point(252, 248);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(56, 23);
            this.button_last.TabIndex = 31;
            this.button_last.Text = ">>";
            this.button_last.UseVisualStyleBackColor = true;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(180, 248);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(56, 23);
            this.button_next.TabIndex = 30;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_pre
            // 
            this.button_pre.Location = new System.Drawing.Point(85, 248);
            this.button_pre.Name = "button_pre";
            this.button_pre.Size = new System.Drawing.Size(56, 23);
            this.button_pre.TabIndex = 29;
            this.button_pre.Text = "<";
            this.button_pre.UseVisualStyleBackColor = true;
            this.button_pre.Click += new System.EventHandler(this.button_pre_Click);
            // 
            // button_first
            // 
            this.button_first.Location = new System.Drawing.Point(12, 248);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(56, 23);
            this.button_first.TabIndex = 28;
            this.button_first.Text = "<<";
            this.button_first.UseVisualStyleBackColor = true;
            this.button_first.Click += new System.EventHandler(this.button_first_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Location = new System.Drawing.Point(42, 335);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.button_enregistrer.TabIndex = 27;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = true;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(439, 180);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 26;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(439, 133);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 25;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(439, 90);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 24;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // textBox_pu
            // 
            this.textBox_pu.Location = new System.Drawing.Point(106, 167);
            this.textBox_pu.Name = "textBox_pu";
            this.textBox_pu.Size = new System.Drawing.Size(128, 20);
            this.textBox_pu.TabIndex = 23;
            // 
            // textBox_des
            // 
            this.textBox_des.Location = new System.Drawing.Point(106, 130);
            this.textBox_des.Name = "textBox_des";
            this.textBox_des.Size = new System.Drawing.Size(128, 20);
            this.textBox_des.TabIndex = 22;
            // 
            // textBox_codeArt
            // 
            this.textBox_codeArt.Location = new System.Drawing.Point(106, 92);
            this.textBox_codeArt.Name = "textBox_codeArt";
            this.textBox_codeArt.Size = new System.Drawing.Size(128, 20);
            this.textBox_codeArt.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Prix Unitaire : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Designation : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Code Article : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mise à jour article";
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(106, 207);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(128, 20);
            this.textBox_stock.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Stock : ";
            // 
            // Form_MAJ_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 429);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_pre);
            this.Controls.Add(this.button_first);
            this.Controls.Add(this.button_enregistrer);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.textBox_pu);
            this.Controls.Add(this.textBox_des);
            this.Controls.Add(this.textBox_codeArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_MAJ_Article";
            this.Text = "Form_MAJ_Article";
            this.Load += new System.EventHandler(this.Form_MAJ_Article_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.TextBox textBox_codeR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_pre;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.TextBox textBox_pu;
        private System.Windows.Forms.TextBox textBox_des;
        private System.Windows.Forms.TextBox textBox_codeArt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.Label label6;
    }
}