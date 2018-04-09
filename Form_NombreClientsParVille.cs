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
    public partial class Form_NombreClientsParVille : Form
    {
        public Form_NombreClientsParVille()
        {
            InitializeComponent();
        }

        private void Form_NombreClientsParVille_Load(object sender, EventArgs e)
        {
            comboBox_ville.DisplayMember = "ville";
            comboBox_ville.DataSource = Program.ds.Tables["Client"];
        }

        private void comboBox_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(Program.ds.Tables["Client"]);
            dv.RowFilter = "ville='" + comboBox_ville.Text + "'";

            label_nbrClients.Text = dv.Count.ToString();
        }
    }
}
