using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Demo_Example.Forms
{
    public partial class Catalog : Form
    {

        string connStr = "server=mysql-8.4;user=root;database=demo;port=3306;password=;";


        public Catalog(string name, int roleID, string roleName)
        {
            InitializeComponent();
            greet_label.Text += name; // Подгрузка ..........
            roleName_label.Text += roleName;
            LoadItems();


        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            // Заглушка
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Заглушка
        }

        public void LoadItems()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr)) // O_o
            {
                try
                {

                    conn.Open();
                    System.Diagnostics.Debug.WriteLine("Connected.");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `tovar` WHERE 1", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    /* 
                    
                    че нибудь сюда интересное напишу.........

                    */

                    itemList.Controls.Clear(); // Обновляем список

                    while (reader.Read()) // Перебираем каждую строчку из запроса
                    {
                        string id = reader["id"].ToString();
                        string name = reader.GetString("name");
                        int price = reader.GetInt32("price");
                        int promo = reader.GetInt32("promo");
                        string description = reader.GetString("description");
                        string photo = reader.GetString("photo");
                        // Считываем информацию о товаре

                        Panel card = new Panel // Создаем новую панель, ну, что то типа Canvas на Tkinter.
                        {
                            Width = 150,
                            Height = 220,
                            Margin = new Padding(10),
                            BackColor = Color.LightGray,
                            Cursor = Cursors.Hand
                        };

                        

                        PictureBox pic = new PictureBox // Картинка должна прилагаться.
                        {
                            Width = 130,
                            Height = 130,
                            Top = 10,
                            Left = 10,
                            SizeMode = PictureBoxSizeMode.Zoom
                        };

                        if (System.IO.File.Exists($"Resources\\Images\\{photo}")) { 

                            pic.Image = Image.FromFile($"Resources\\Images\\{photo}");
                        }

                        /*
                        
                        -> В Visual Studio нужно выставлять свойства и параметры прямо внутри картинок, поэтому
                        нужно поставить в каждом фронтенд элементе свойство "Копировать в выходной каталог", чтобы
                        даже при деве картинка учитывалась как отдельный ОБЯЗАТЕЛЬНЫЙ файл.

                        */

                        else { 

                            pic.BackColor = Color.DarkGray;
                        } // -> Если нет картинки, то просто серый фон =)
                        
                        card.Controls.Add(pic); // Учитываем в карточку картинку!

                        Label lblName = new Label
                        {
                            Text = name,
                            Top = 150,
                            Left = 10,
                            Width = 130,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        card.Controls.Add(lblName); // Учитываем название товара в карточке.

                        string priceStr;
                        if (promo != 0)
                        {
                            priceStr = (price - (price * (promo / 100))).ToString(); // попытка рассчитать скидочку....
                        }
                        else
                        {
                            priceStr = price.ToString();
                        }

                        priceStr += " руб";

                        Label lblPrice = new Label
                        {
                            Text = priceStr,
                            Width = 130,
                            Top = 170,
                            Left = 10,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        card.Controls.Add(lblPrice); // Ну, понятно.

                        itemList.Controls.Add(card); // Добавляем в сам контейнер карточку.
                        

                    }

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"oops.. -> {ex}");
                }
            }
        }
    }
}
