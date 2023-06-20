using System.Data;

namespace demoExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            

            using (ConnectDB db = new ConnectDB())
            {
                DataTable users = db.ExecuteSql($"SELECT * FROM USERS WHERE login = {login} and password = {password};");
                DataTable isAdmin = db.ExecuteSql($"SELECT * FROM USERS WHERE login = {login} and password = {password} and usersRole = 1;");
                DataTable isManager = db.ExecuteSql($"SELECT * FROM USERS WHERE login = {login} and password = {password} and usersRole = 2;");
                if (isAdmin.Rows.Count > 0)
                {
                    levelCheck.level = 1;

                };
                if (isManager.Rows.Count > 0)
                {
                    levelCheck.level = 2;
 
                };
                if (users.Rows.Count > 0)
                {
                    FormMain main = new FormMain();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }
            }
        }
    }
}