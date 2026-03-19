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
            if (LoginBox.Text == "" || PasswBox.Text == "")
            {
                MessageBox.Show("Есть какое то пустое значение... =(");
            }
            else 
            { 
            
            System.Diagnostics.Debug.WriteLine($"{LoginBox.Text} <- Логин\n{PasswBox.Text} <- Пароль") ; // К большому сожалению Console.WriteLine работает коряво в WinForms
            /* 
            ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            Но зато эта длинная команда гарантированно выводит все что угодно в отладочную консоль.
             
            */            
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