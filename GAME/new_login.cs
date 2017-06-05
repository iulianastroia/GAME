using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GAME
{
    public partial class new_login : Form
    {
        public new_login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Corina\Documents\loginappdatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();//deschide conexiunea

            string str = "select * from logintable where username= '" + uname.Text + "'and password='"+pass.Text +"'";
            SqlCommand cmd = new SqlCommand(str,con);//paseaza conexiunea unui obiect de comanda
            SqlDataReader dr = cmd.ExecuteReader();//primire rezultate comenzi
            if(dr.HasRows)          //login reusit
            {
                this.Hide();
                Aeroplanes_game frm = new Aeroplanes_game();
                frm.Show();
            }
            else                    //eroare login
            {
                MessageBox.Show("Please enter valid Username and Password");
            }
            con.Close();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Corina\Documents\loginappdatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string str = "Insert into logintable (username,password) values ('"+uname.Text+"','"+pass.Text+"')";
            SqlCommand cmd = new SqlCommand(str, con);
            int t = cmd.ExecuteNonQuery();
            if(t==1)            //inregistrare nou user
            {
                MessageBox.Show("Registered a new user");
            }
            con.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
