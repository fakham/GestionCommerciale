using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_GestionCommerciale
{
    public partial class Form_ListeCommandesParClient : Form
    {
        public Form_ListeCommandesParClient()
        {
            InitializeComponent();
        }

        private void Form_ListeCommandesParClient_Load(object sender, EventArgs e)
        {
            comboBox_nom.DisplayMember = "nom";
            comboBox_nom.ValueMember = "codecl";
            comboBox_nom.DataSource = Program.ds.Tables["Client"];
        }

        private void comboBox_nom_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_code.Text = comboBox_nom.SelectedValue.ToString();

            DataRow dr = Program.ds.Tables["Client"].Rows.Find(comboBox_nom.SelectedValue);
            label_ville.Text = dr["ville"].ToString();

            DataRow []rows = dr.GetChildRows("R_clt_cmd");

            dataGridView_commandes.Rows.Clear();
            foreach (DataRow r in rows)
            {
                dataGridView_commandes.Rows.Add(r[0], r[1]);
            }
        }

        private void dataGridView_commandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Program.codeCmd = int.Parse(dataGridView_commandes.Rows[e.RowIndex].Cells[0].Value.ToString());

                Form_DetailCommande f = new Form_DetailCommande();
                f.Show();
            }
        }
    }
}
