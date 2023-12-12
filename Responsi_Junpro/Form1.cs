using Npgsql;
using System.Data;

namespace Responsi_Junpro
{
    public partial class Form1 : Form
    {
        List<string> listDepartement = new List<string>();

        public Form1()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            /* rbDev.Checked = true;
             rbEng.Checked = true;  
             rbFinance.Checked = true;
             rbPM.Checked = true;    
             rdHR.Checked = true;*/
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsidifta";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private int dept;
        private string id_karayawan;


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            setDepartement();
            try
            {
                conn.Open();
                sql = @"select * from st_insert(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbName.Text);
                cmd.Parameters.AddWithValue("_id_dep", dept);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil ditambahkan", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbName.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error Happen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error Happen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setDepartement()
        {
            if (rbHR.Checked == true)
            {
                dept = 1;
            }
            else if (rbENG.Checked == true)
            {
                dept = 2;
            }
            else if (rbDev.Checked == true)
            {
                dept = 3;
            }
            else if (rbPM.Checked == true)
            {
                dept = 4;
            }
            else
            {
                dept = 5;
            }

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbName.Text = r.Cells["_nama"].Value.ToString();
                id_karayawan = r.Cells["_id_karyawan"].Value.ToString();
                string dept = r.Cells["_nama_dep"].Value.ToString();
                setDepartement(dept);

            }
        }

        public void setDepartement(string dept)
        {
            if (dept == "HR")
            {
                rbHR.Checked = true;
                rbENG.Checked = false;
                rbDev.Checked = false;
                rbPM.Checked = false;
                rbFinance.Checked = false;
            }
            else if (dept == "Engineer")
            {
                rbHR.Checked = false;
                rbENG.Checked = true;
                rbDev.Checked = false;
                rbPM.Checked = false;
                rbFinance.Checked = false;
            }
            else if (dept == "Developer")
            {
                rbHR.Checked = false;
                rbENG.Checked = false;
                rbDev.Checked = true;
                rbPM.Checked = false;
                rbFinance.Checked = false;
            }
            else if (dept == "Product Manager")
            {
                rbHR.Checked = false;
                rbENG.Checked = false;
                rbDev.Checked = false;
                rbPM.Checked = true;
                rbFinance.Checked = false;
            }
            else
            {
                rbHR.Checked = false;
                rbENG.Checked = false;
                rbDev.Checked = false;
                rbPM.Checked = false;
                rbFinance.Checked = true;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setDepartement();
            try
            {
                conn.Open();
                sql = @"select * from st_update(:_id_karyawan, :_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", id_karayawan);
                cmd.Parameters.AddWithValue("_nama", tbName.Text);
                cmd.Parameters.AddWithValue("_id_dep", dept);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil Diupdate", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbName.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error Happen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from st_delete(:_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", id_karayawan);
                
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil Didelete", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error Happen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}