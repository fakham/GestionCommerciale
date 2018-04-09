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
    public partial class Form_ListeNomsClients : Form
    {
        public Form_ListeNomsClients()
        {
            InitializeComponent();
        }

        private void Form_ListeNomsClients_Load(object sender, EventArgs e)
        {
            listBox_listeNoms.DisplayMember = "nom";
            listBox_listeNoms.DataSource = Program.ds.Tables["Client"];
        }
    }
}
