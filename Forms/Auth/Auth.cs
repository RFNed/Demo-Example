using MySql.Data.MySqlClient;
using System.Data;

namespace Demo_Example.Forms
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // << -- Авторизация
        {
            DB db = new();
            DataTable dt = new();
            MySqlDataAdapter adapter = new();

            MySqlCommand cmd = new("select * from users u where u.login = @login", db.GetConnection());
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginBox.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0 && dt.Rows[0]["passw"].ToString() == PasswBox.Text)
            {
                MessageBox.Show("Успешная авторизация", "Успешно", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                DataRow user = dt.Rows[0];
                string name = user["name"].ToString();
                int roleId = Convert.ToInt32(user["role_id"].ToString());
                Catalog catalog = new(name, roleId, "Роль");
                catalog.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) // << -- Гость
        {
            MessageBox.Show("Вы вошли как гость!", "Успешно", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information, defaultButton: MessageBoxDefaultButton.Button1);
            
            Catalog catalog = new Catalog("Гость", 0, "Гость");
            catalog.Show();
            this.Hide();
            
            /* 
            
            ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            Вот эта длинная команда собралась очень просто. Просто использовал подсказки редактора, и даже после аргументов buttons: или icon: он мне стал подсказывать сразу нужные варианты.

            Прикольно, удобно... (всяко лучше чем tkinter..........................)

            */
        }
    }
}