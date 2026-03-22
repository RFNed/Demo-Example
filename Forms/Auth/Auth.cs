using MySql.Data.MySqlClient;

namespace Demo_Example.Forms
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new();
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
                SELECT u.login, u.role_id, r.name AS role_name
                FROM users u
                JOIN roles r ON u.role_id = r.id
                WHERE u.login = @login AND u.passw = @passw
            ", db.GetConnection());

            cmd.Parameters.AddWithValue("@login", LoginBox.Text);
            cmd.Parameters.AddWithValue("@passw", PasswBox.Text);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show("Успешная авторизация", "Успешно",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string name = reader.GetString("login");
                    int roleId = reader.GetInt32("role_id");
                    string roleName = reader.GetString("role_name");

                    Catalog catalog = new(name, roleId, roleName);
                    catalog.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            db.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e) // << -- Гость
        {
            MessageBox.Show("Вы вошли как гость!", "Успешно", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information, defaultButton: MessageBoxDefaultButton.Button1);
            
            Catalog catalog = new Catalog("Гость", 4, "Гость");
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