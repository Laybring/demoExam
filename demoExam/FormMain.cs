using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoExam
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public string cartIDS;
        //string filePath = dataGridView1.CurrentCell.RowIndex;

        public void loaddata()
        {
            using (ConnectDB db = new ConnectDB())
            {
                DataTable users = db.ExecuteSql("SELECT * FROM PRODUCT");
                dataGridView1.DataSource = users;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (levelCheck.level > 2)
            {
                deleteButton.Hide();
                adminButton.Hide();
            }
            if (levelCheck.level > 1 && levelCheck.level < 3)
            {
                adminButton.Hide();
            }
            using (ConnectDB db = new ConnectDB())
            {

                DataTable dt = db.ExecuteSql($"Select * from product");
                {
                    dataGridView1.DataSource = dt;
                }
                loaddata();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (ConnectDB db = new ConnectDB())
            {
                int num = dataGridView1.CurrentCell.RowIndex;
                db.ExecuteSqlNonQuery($"DELETE FROM PRODUCT WHERE ID = {num + 1}");
                db.ExecuteSql($"Select * from users");
                loaddata();
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = dataGridView1.CurrentCell.RowIndex;
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            using (ConnectDB db = new ConnectDB())
            {

                int num = dataGridView1.CurrentCell.RowIndex;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    db.ExecuteSqlNonQuery($"UPDATE users SET login = '"
                    + dataGridView1.Rows[i].Cells["login"].Value + "', password = '"
                    + dataGridView1.Rows[i].Cells["password"].Value + "', mail = '"
                    + dataGridView1.Rows[i].Cells["mail"].Value + "' WHERE ID =  " + num + 1 + ";");
                }
                loaddata();
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }
    }
}
