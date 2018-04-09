using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TP_GestionCommerciale
{
    public partial class Form_MAJ_Article : Form
    {
        BindingSource bs = new BindingSource();

        public Form_MAJ_Article()
        {
            InitializeComponent();
        }

        private void Form_MAJ_Article_Load(object sender, EventArgs e)
        {
            bs.DataSource = Program.ds.Tables["Article"];
            textBox_codeArt.DataBindings.Add("Text", bs, "CodeArt");
            textBox_des.DataBindings.Add("Text", bs, "Designation");
            textBox_pu.DataBindings.Add("Text", bs, "PU");
            textBox_stock.DataBindings.Add("Text", bs, "QStock");
        }

        private void button_first_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void button_pre_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Find("CodeArt", textBox_codeR.Text);
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmdB = new SqlCommandBuilder(Program.da_art);
            Program.da_art.Update(Program.ds, "Article");
        }
    }
}
