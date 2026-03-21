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

            db.OpenConnection();

            MySqlCommand cmd = new("select * from users where login = @login and passw = @passw", db.GetConnection());
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginBox.Text;
            cmd.Parameters.Add("@passw", MySqlDbType.VarChar).Value = PasswBox.Text;
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                MessageBox.Show("Успешная авторизация", "Успешно", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                string name = reader.GetString("name");
                int roleId = reader.GetInt16("role_id");
                Catalog catalog = new(name, roleId, "Роль");
                catalog.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            db.CloseConnection();
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