using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TP_GestionCommerciale
{
    static class Program
    {
        public static string conString = @"Database=Vente; Server=.\SQLExpress; Integrated Security=SSPI";
        public static DataSet ds = new DataSet();
        public static SqlDataAdapter da_clt = new SqlDataAdapter("select * from Client", conString);
        public static SqlDataAdapter da_art = new SqlDataAdapter("select * from Article", conString);
        public static SqlDataAdapter da_cmd = new SqlDataAdapter("select * from Commande", conString);
        public static SqlDataAdapter da_detail = new SqlDataAdapter("select * from Detail", conString);

        public static int codeCmd;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Menu());
        }


        public static void ChargerDataSet()
        {
            da_clt.Fill(ds, "Client");
            da_art.Fill(ds, "Article");
            da_cmd.Fill(ds, "Commande");
            da_detail.Fill(ds, "Detail");

            ds.Tables["Client"].PrimaryKey = new DataColumn[] { ds.Tables["Client"].Columns["codecl"] };
            ds.Tables["Commande"].PrimaryKey = new DataColumn[] { ds.Tables["Commande"].Columns["NumCom"] };
            ds.Tables["Article"].PrimaryKey = new DataColumn[] { ds.Tables["Article"].Columns["CodeArt"] };
            ds.Tables["Detail"].PrimaryKey = new DataColumn[] { ds.Tables["Detail"].Columns["NumCom"], 
                                                                ds.Tables["Detail"].Columns["CodeArt"] };

            ds.Relations.Add(new DataRelation("R_clt_cmd", ds.Tables["Client"].Columns["CodeCl"], 
                                                           ds.Tables["Commande"].Columns["CodeCl"]));
            ds.Relations.Add(new DataRelation("R_cmd_detail", ds.Tables["Commande"].Columns["NumCom"],
                                                              ds.Tables["Detail"].Columns["NumCom"]));
        }
    }
}
