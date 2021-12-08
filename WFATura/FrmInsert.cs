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
    public partial class FrmInsert : Form
    {
        private readonly string connectionString;

        public FrmInsert(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void FrmInsert_Load(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();

            var command = new SqlCommand("SELECT MAX(id) + 1 FROM turazo", connection);
            var reader = command.ExecuteReader();
            reader.Read();
            tbId.Text = reader[0].ToString();
            reader.Close();

            connection.Close();
        }

        private void btnFelvetel_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connectionString);
            int id = Convert.ToInt32(tbId.Text);
            string veznev = tbVeznev.Text;
            string kernev = tbKernev.Text;
            string telszam = tbTelszam.Text;
            string varos = tbVaros.Text;

            try
            {
                connection.Open();

                var errMessage = "";

                if (String.IsNullOrWhiteSpace(tbVeznev.Text)) errMessage += "A vezetéknév mező kitöltése kötelező!\n";
                if (String.IsNullOrWhiteSpace(tbKernev.Text)) errMessage += "A keresztnév mező kitöltése kötelező!\n";
                if (String.IsNullOrWhiteSpace(tbVaros.Text)) errMessage += "A város mező kitöltése kötelező!\n";
                if (String.IsNullOrWhiteSpace(tbTelszam.Text)) errMessage += "A telefonszám mező kitöltése kötelező!\n";

                if (!String.IsNullOrEmpty(errMessage)) throw new Exception(errMessage);

                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand("INSERT INTO turazo VALUES " +
                    $"('{veznev}','{kernev}','{varos}','{telszam}');", connection),
                };

                adapter.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            this.Close();
        }
    }
}
