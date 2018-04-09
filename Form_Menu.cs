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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            Program.ChargerDataSet();
        }

        private void listeNomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeNomsClients f = new Form_ListeNomsClients();
            f.Show();
        }

        private void listeParVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeClientsParVille f = new Form_ListeClientsParVille();
            f.Show();
        }

        private void nombreParVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NombreClientsParVille f = new Form_NombreClientsParVille();
            f.Show();
        }

        private void miseAJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MAJ_Client f = new Form_MAJ_Client();
            f.Show();
        }

        private void miseAJourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_MAJ_Article f = new Form_MAJ_Article();
            f.Show();
        }

        private void listeCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeCommandesParClient f = new Form_ListeCommandesParClient();
            f.Show();
        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RechercheArticle f = new Form_RechercheArticle();
            f.Show();
        }

        private void rapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ClientRapport f = new Form_ClientRapport();
            f.Show();
        }
    }
}
