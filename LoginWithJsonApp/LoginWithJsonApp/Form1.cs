using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.DataFormats;

namespace LoginWithJsonApp
{
    public partial class Form1 : Form
    {
        private List<User> users;

        public Form1()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            string json = File.ReadAllText("users.json");
            users = JsonConvert.DeserializeObject<List<User>>(json);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = users.FirstOrDefault(u => u.username == username && u.password == password);

            if (user != null)
            {
                MessageBox.Show("Login successful!");

                Form2 dashboard = new Form2();

               
                dashboard.FormClosed += (s, args) => this.Close();

                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

    }

}
