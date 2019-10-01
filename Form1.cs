using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GSB_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chargerListe();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
        private void chargerListe()
        {
            MySqlConnection maConnexion = new MySqlConnection("server=127.0.0.1;port=3306;uid=root;pwd=;database=bsg;");
            maConnexion.Open();

            string sql = "SELECT id FROM commande";
            MySqlCommand maReq = new MySqlCommand(sql, maConnexion);
            MySqlDataReader resultats = maReq.ExecuteReader();
            while (resultats.Read())
            {
                comboBox1.Items.Add(resultats["id"]);
            }

        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerListe();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
