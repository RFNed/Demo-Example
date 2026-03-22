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

        private int _roleId;

        public Catalog(string name, int roleID, string roleName)
        {
            
            InitializeComponent();
            _roleId = roleID;
            greet_label.Text += name; // Подгрузка ..........
            roleName_label.Text += roleName;
            
            LoadItems(roleId: _roleId);
            
        }





        private void Catalog_Load(object sender, EventArgs e)
        {
            // Заглушка
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Заглушка
        }

        public void LoadItems(int roleId)
        {
            DB db = new();

            try
            {
                db.OpenConnection();

                System.Diagnostics.Debug.WriteLine("Connected.");

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `tovar` WHERE 1", db.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                /* 
                    
                че нибудь сюда интересное напишу.........

                */

                itemList.Controls.Clear(); // Обновляем список


                while (reader.Read()) // Перебираем каждую строчку из запроса
                {
                    int id = reader.GetInt32("id");
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

                    

                    if (roleId < 3) { 
                        ContextMenuStrip menu = new ContextMenuStrip();
                        ToolStripMenuItem editItem = new ToolStripMenuItem("Редактировать");
                        editItem.Click += (s, e) =>
                        {
                            editForm form = new(id);
                            form.Show();
                        };

                        menu.Items.Add(editItem);
                        
                        if (roleId == 1)
                        {
                            ToolStripMenuItem deleteItem = new ToolStripMenuItem("❌ Удалить");
                            deleteItem.Click += (s, e) =>
                            {
                                deleteItems(id);
                            };
                            menu.Items.Add(deleteItem);
                        }
                        card.ContextMenuStrip = menu;

                    }
                    
                    




                    


                    

                    itemList.Controls.Add(card); // Добавляем в сам контейнер карточку.
                        

                }

            }
            catch
            {
                MessageBox.Show("Похоже что вы не открыли соединение MySQL, или ошиблись в конфиге...\nПроверьте ваши данные, и соединение и попробуйте ещё раз!", "У-упс...", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error, defaultButton: MessageBoxDefaultButton.Button1);
                Environment.Exit(0);
            }
        }

        private void deleteItems(int itemId)
        {
            DB db = new();
            db.OpenConnection();
            DialogResult result = MessageBox.Show("Вы уверены?", "Удаление", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand delCommand = new("DELETE FROM tovar WHERE id = @id", db.GetConnection());
                    delCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = itemId;
                    delCommand.ExecuteNonQuery();
                    MessageBox.Show("OK!", "MySQL", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Asterisk);
                    LoadItems(_roleId);
                }
                catch
                {
                    MessageBox.Show("Произошла непредвиденная ошибка...", "MySQL", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            itemList.Visible = false;
            LoadItems(_roleId);
            itemList.Visible = true;
            this.Cursor = Cursors.Default;
        }
    }
}
