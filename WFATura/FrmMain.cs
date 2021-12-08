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
    public partial class FrmMain : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=tura;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) => UpdateDGV();

        private void UpdateDGV()
        {
            dgvMain.Rows.Clear();

            var connection = new SqlConnection(connectionString);

            connection.Open();

            var command = new SqlCommand("SELECT * FROM turazo", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgvMain.Rows.Add(
                    reader[0],
                    reader[1],
                    reader[2],
                    reader[3],
                    reader[4]);
            }
            reader.Close();
            connection.Close();

            pbMain.Image = Properties.Resources.kep;

        }

        private void dgvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string kivID = dgvMain[0, e.RowIndex].Value + "";
            var frm = new FrmAdatok(connectionString, kivID);
            frm.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var frm = new FrmInsert(connectionString);
            frm.Show();
        }

        private void btnFrissit_Click(object sender, EventArgs e)
        {
            UpdateDGV();
        }
    }
}
