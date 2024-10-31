using DemoLib;
using System;
using System.IO;
using System.Windows.Forms;

namespace Demo
{
    public partial class ClientInfo : Form
    {
        public ClientInfo()
        {
            InitializeComponent();
        }

        public void SetClient(Client client)
        {
            CompanyNameTextBox.Text = client.Type + " " + client.Name;
            PhoneNumberTextBox.Text = client.PhoneNumber;
            DirectorTextBox.Text = client.Director;
            RatingTextBox.Text = client.Rating.ToString();
            DiscountTextTextBox.Text = client.Discount.ToString();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void ClientInfo_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
