using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreLibrary;
using StoreLibrary.Componets;

namespace Example4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            productComboBox1.Items.Add(new Product()
            {
                Name = "iphone 6s ",
                Price = 24500,
                Category = "手機",
                Status ="熱賣"
            });

            productComboBox1.Items.Add(new Product()
            {
                Name = "iphone 6s plus ",
                Price = 28500,
                Category = "手機",
                Status = "降價"
            });


            productComboBox1.Items.Add(new Product()
            {
                Name = "iphone  SE ",
                Price = 15500,
                Category = "手機",
                Status = "綠標"
            });

            productComboBox2.Items.Add(new Product()
            {
                Name = "iphone Lighting底座",
                Price = 1690,
                Category = "底座",
                Status = "降價"
            });

            productComboBox2.Items.Add(new Product()
            {
                Name = "Beats Solo2耳罩式耳機",
                Price = 11250,
                Category = "耳機",
                Status = "熱賣"
            });

            productComboBox2.Items.Add(new Product()
            {
                Name = "Beats Powerbeats2 無線耳機",
                Price = 7000,
                Category = "耳機",
                Status = "綠標"
            });

            productComboBox2.Items.Add(new Product()
            {
                Name = "Belkin Lightning 對 USB 連接線",
                Price = 740,
                Category = "連接線",
                Status = "熱賣"
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void productComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productComboBox1.SelectedItem != null) productComboBox2.Enabled=true;
            Product phone = productComboBox1.SelectedItem  as Product;
            Product phoneCase = productComboBox2.SelectedItem as Product;
            label4.Text = caculatedTotalPrice(phone, phoneCase).ToString();
        }

        private decimal caculatedTotalPrice(Product phone, Product phoneCase)
        {

            return ((phone == null) ? 0 : phone.Price) +
            ((phoneCase == null) ? 0 : phoneCase.Price);

        }

        private void productComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product phone = productComboBox1.SelectedItem as Product;
            Product phoneCase = productComboBox2.SelectedItem as Product;
            label4.Text = caculatedTotalPrice(phone, phoneCase).ToString();
        }

    }
}
