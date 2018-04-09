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
    public partial class Form_RechercheArticle : Form
    {
        public Form_RechercheArticle()
        {
            InitializeComponent();
        }


        private void Form_RechercheArticle_Load(object sender, EventArgs e)
        {
            //dataGridView_produits.Rows.Clear();
            //foreach (DataRow dr in Program.ds.Tables["Article"].Rows)
            //    dataGridView_produits.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            dataGridView_produits.DataSource = Program.ds.Tables["Article"];
        }

        public void UpdateDGV()
        {
            string des = "%", PU = "%", QStock = "%";

            if (checkBox_description.Checked)
                des = textBox_description.Text + "%";
            if (checkBox_PU.Checked)
                PU = textBox_PU.Text + "%";
            if (checkBox_QtteStock.Checked)
                QStock = textBox_QtteStock.Text + "%";

            string req = string.Format(@"select * from Article where designation like '{0}'
                                         and PU like '{1}' and QStock like '{2}'",
                                        des, PU, QStock);

            SqlDataAdapter da = new SqlDataAdapter(req, Program.conString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_produits.DataSource = dt;
        }

        private void textBox_description_TextChanged(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        private void button_recherche_Click(object sender, EventArgs e)
        {
            string Designation = "%";
            string PU = "%";
            if (checkBox_description.Checked)
                Designation = textBox_description.Text;
            if (checkBox_PU.Checked)
                PU = textBox_PU.Text;
            //mode déconnecté
            DataView dv = new DataView(Program.ds.Tables["Article"]);
            dv.RowFilter = string.Format("Designation like '{0}'", Designation);
            dataGridView_produits.DataSource = dv;
            //mode connecté(supporte le like sur un int)
            string req = @"select * from Article where Designation like '" + Designation + "' and PU like '"+PU+"'";
            SqlDataAdapter da = new SqlDataAdapter(req, Program.conString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_produits.DataSource = dt;
        }

        private void textBox_PU_TextChanged(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        private void textBox_QtteStock_TextChanged(object sender, EventArgs e)
        {
            UpdateDGV();
        }
    }
}
