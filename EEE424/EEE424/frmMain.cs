using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;


namespace EEE424
{
    public partial class frmMain : Form
    {
        private OleDbConnection conn = new
            OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + Application.StartupPath + "\\data\\student.accdb");
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void grpBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void changeClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass frmClass = new frmClass(this);
            frmClass.Show();
        }

        private void howToUseDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT * FROM student order by student_id='" + txtBoxSt.Text + "'";
            OleDbCommand dbComm = new OleDbCommand(sql, conn);
            
            DataSet ds = new DataSet();
            OleDbDataAdapter dbAdap = new OleDbDataAdapter(dbComm);
            dbAdap.Fill(ds);
            conn.Close();

            txtBoxSt.Text = ds.Tables[0].Rows[0]["student_id"].ToString();
            txtBoxNa.Text = ds.Tables[0].Rows[0]["sname"].ToString();
            txtBoxMa.Text = ds.Tables[0].Rows[0]["major"].ToString();
            txtBoxMi.Text = ds.Tables[0].Rows[0]["minor"].ToString();

            data_GridView();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "UPDATE student SET sname='" + txtBoxNa.Text + "', major='" + 
                txtBoxMa.Text + "', minor='" + txtBoxMi.Text + "' where student_id='"+
                txtBoxSt.Text+"'";
            OleDbCommand dbComm = new OleDbCommand(sql, conn);
            dbComm.ExecuteScalar();
            conn.Close();

            data_GridView();
            MessageBox.Show("Data updated");
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "insert into student (student_id, sname, major, minor) values('" +
                txtBoxSt.Text +"', '" + txtBoxNa.Text + "', '" + txtBoxMa.Text + "', '" +
                txtBoxMi.Text + "')";
            OleDbCommand dbComm = new OleDbCommand(sql, conn);

            dbComm.ExecuteScalar();
            conn.Close();

            MessageBox.Show("Data Inserted");
            data_GridView();
            
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "delete FROM student where student_id='" + txtBoxSt.Text + "'";
            OleDbCommand dbComm = new OleDbCommand(sql, conn);
            dbComm.ExecuteScalar();
            conn.Close();

            data_GridView();
            MessageBox.Show("Data deleted");
        }

        private void data_GridView()
        {
            conn.Open();
            string sql = "SELECT student_id,sname,major,minor from student order by student_id";
            //string sql = "SELECT * FROM student";
            OleDbCommand dbComm = new OleDbCommand(sql, conn);

            DataSet ds = new DataSet();
            OleDbDataAdapter dbAdap = new OleDbDataAdapter(dbComm);
            dbAdap.Fill(ds);
            conn.Close();

            //MessageBox.Show("inside data_gridview 1");

            dataGridView1.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string student_id = Convert.ToString(ds.Tables[0].Rows[i]["student_id"]);
                string sname = Convert.ToString(ds.Tables[0].Rows[i]["sname"]);
                string major = Convert.ToString(ds.Tables[0].Rows[i]["major"]);
                string minor = Convert.ToString(ds.Tables[0].Rows[i]["minor"]);
                dataGridView1.Rows.Add(student_id, sname, major, minor);
            }
            dataGridView1.Visible = true;
        }
    }
}
