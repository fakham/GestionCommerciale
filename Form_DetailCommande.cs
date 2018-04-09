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
    public partial class Form_DetailCommande : Form
    {
        public Form_DetailCommande()
        {
            InitializeComponent();
        }

        private void Form_DetailCommande_Load(object sender, EventArgs e)
        {
            decimal prixTotal = 0, qtteTotal = 0;
            textBox_numCommande.Text = Program.codeCmd.ToString();

            DataRow dr = Program.ds.Tables["Commande"].Rows.Find(Program.codeCmd);

            textBox_date.Text = dr["DateCom"].ToString();
            textBox_numClient.Text = dr["CodeCl"].ToString();

            DataRow[] rows = dr.GetChildRows("R_cmd_detail");

            dataGridView_detail.Rows.Clear();
            foreach (DataRow r in rows)
            { 
                DataRow artRow = Program.ds.Tables["Article"].Rows.Find(r["CodeArt"]);
                dataGridView_detail.Rows.Add(r["CodeArt"], artRow["Designation"], artRow["PU"], r["Qte"]);

                prixTotal += decimal.Parse(artRow["PU"].ToString());
                qtteTotal += decimal.Parse(r["Qte"].ToString());
            }

            foreach (DataGridViewRow r in dataGridView_detail.Rows)
            {
                if (int.Parse(r.Cells[3].Value.ToString()) > 5)
                    r.DefaultCellStyle.BackColor = Color.LawnGreen;
            }

            dataGridView_detail.Rows.Add("Total", "", prixTotal, qtteTotal);
            dataGridView_detail.Rows[dataGridView_detail.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView_detail.Rows[dataGridView_detail.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);
            dataGridView_detail.Rows[dataGridView_detail.Rows.Count - 1].ReadOnly = true;
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow r in dataGridView_detail.Rows)
            //{
            //    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)r.Cells[4];
            //    if (cell.Value.ToString() == "True")
            //    {
            //        DataRow dr = Program.ds.Tables["Detail"].Rows.Find(r.Cells[0].Value);
            //        dr.Delete();
            //    }
            //}

            for (int i = 0; i < dataGridView_detail.Rows.Count; i++)
            {
                DataGridViewRow r = dataGridView_detail.Rows[i];
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)r.Cells[4];

                if (cell.Value != null && cell.Value.ToString() == "True")
                {
                    DataRow dr = Program.ds.Tables["Detail"].Rows.Find(new[]{Program.codeCmd, r.Cells[0].Value});
                    dr.Delete();
                    dataGridView_detail.Rows.RemoveAt(i);
                }
            }

            //for (int i = 0; i < dataGridView_detail.Rows.Count; i++)
            //{
            //    DataGridViewRow r = dataGridView_detail.Rows[i];
            //    CheckBox cell = (CheckBox)r.Cells[4].;

            //    if (cell.Checked != null && cell.Value.ToString() == "True")
            //    {
            //        DataRow dr = Program.ds.Tables["Detail"].Rows.Find(r.Cells[0].Value);
            //        dr.Delete();
            //        dataGridView_detail.Rows.RemoveAt(i);
            //    }
            //}
        }
    }
}
