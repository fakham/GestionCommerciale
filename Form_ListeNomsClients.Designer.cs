namespace TP_GestionCommerciale
{
    partial class Form_ListeNomsClients
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
            this.listBox_listeNoms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_listeNoms
            // 
            this.listBox_listeNoms.FormattingEnabled = true;
            this.listBox_listeNoms.Location = new System.Drawing.Point(95, 33);
            this.listBox_listeNoms.Name = "listBox_listeNoms";
            this.listBox_listeNoms.Size = new System.Drawing.Size(245, 329);
            this.listBox_listeNoms.TabIndex = 0;
            // 
            // Form_ListeNomsClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 426);
            this.Controls.Add(this.listBox_listeNoms);
            this.Name = "Form_ListeNomsClients";
            this.Text = "Form_ListeNomsClients";
            this.Load += new System.EventHandler(this.Form_ListeNomsClients_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_listeNoms;
    }
}