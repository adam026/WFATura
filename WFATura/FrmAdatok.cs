using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFATura
{
    public partial class FrmAdatok : Form
    {
        string connectionString;
        string kivId;
        public FrmAdatok(string connectionString, string kivId)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.kivId = kivId;

        }

        private void FrmAdatok_Load(object sender, EventArgs e)
        {
            dgvAdatok.Rows.Clear();

            var connection = new SqlConnection(connectionString);

            connection.Open();
            var command = new SqlCommand("SELECT honnan,hova,km FROM utvonal " +
                $"INNER JOIN turazo ON turazoID = turazo.id " +
                $"WHERE turazoID = '{Convert.ToInt32(kivId)}';", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgvAdatok.Rows.Add(
                    reader[0],
                    reader[1],
                    reader[2]);
            }
            reader.Close();

            var command1 = new SqlCommand($"SELECT SUM(km) FROM utvonal WHERE turazoID = '{Convert.ToInt32(kivId)}';", connection);
            var reader1 = command1.ExecuteReader();
            reader1.Read();
            if (!int.TryParse(reader1[0].ToString(), out _))
            {
                tbSum.Text = "Nincs érték";
            }
            else
            {
                tbSum.Text = reader1[0].ToString();
            }

            if (!int.TryParse(reader1[0].ToString(), out _))
            {
                tbJutalom.Text = "Nincs érték";
            }
            else
            {
                tbJutalom.Text = (reader1.GetInt32(0) / 20).ToString();
            }
            reader1.Close();

            connection.Close();

        }
    }
}
