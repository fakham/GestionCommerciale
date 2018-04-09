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
    public partial class Form_MAJ_Client : Form
    {
        BindingSource bs = new BindingSource();

        public Form_MAJ_Client()
        {
            InitializeComponent();
        }

        private void Form_MAJ_Client_Load(object sender, EventArgs e)
        {
            bs.DataSource = Program.ds.Tables["Client"];
            textBox_codeClient.DataBindings.Add("Text", bs, "codecl");
            textBox_nom.DataBindings.Add("Text", bs, "nom");
            textBox_ville.DataBindings.Add("Text", bs, "ville");
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
            DataRow dr = Program.ds.Tables["Client"].NewRow();
            dr["CodeCl"] = textBox_codeClient.Text;
            dr["Nom"] = textBox_nom.Text;
            dr["Ville"] = textBox_ville.Text;
            Program.ds.Tables["Client"].Rows.Add(dr);
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            DataRow dr = Program.ds.Tables["Client"].Rows.Find(textBox_codeClient.Text);
            dr["Nom"] = textBox_nom.Text;
            dr["Ville"] = textBox_ville.Text;
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            DataRow dr = Program.ds.Tables["Client"].Rows.Find(textBox_codeClient.Text);
            dr.Delete();
            bs.RemoveCurrent();
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            DataRow dr = Program.ds.Tables["Client"].Rows.Find(textBox_codeR.Text);
            textBox_codeClient.Text = dr["CodeCl"].ToString();
            textBox_nom.Text = dr["Nom"].ToString();
            textBox_ville.Text = dr["Ville"].ToString();
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmdB = new SqlCommandBuilder(Program.da_clt);
            Program.da_clt.Update(Program.ds, "Client");
        }
    }
}
