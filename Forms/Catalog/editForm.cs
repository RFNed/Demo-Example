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
    public partial class editForm : Form
    {
        public editForm(int itemId)
        {
            InitializeComponent();
            DB db = new();
            db.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("select id, name, price, promo from tovar where id = @id", db.GetConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = itemId;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string id = reader["id"].ToString();
            string name = reader.GetString("name");
            int price = reader.GetInt32("price");
            int promo = reader.GetInt32("promo");
            db.CloseConnection();
            Text += $"[{id}] - {name}";
            priceBox.Text = price.ToString();
            promoBox.Text = promo.ToString();
            

        }
    }
}
