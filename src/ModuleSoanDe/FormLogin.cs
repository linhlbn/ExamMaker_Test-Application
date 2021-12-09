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

namespace ModuleSoanDe
{
    public partial class FormLogin : Form
    {
        // connection & command - local mysql server DB
        readonly SqlConnection connection = new SqlConnection();
        readonly SqlCommand command = new SqlCommand();

        // time limit access: 300s = 5mins
        private int TimeLimit = 300;
        private int Attempt = 0;


        private void WhenOpenFormLogin()
        {
            // alight form to center
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            // alight text to center
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.PasswordChar = '\u25CF';


            // giả sử đã đọc 1 file config gồm datasrouce và Catalog, gán giá trị vào biến vừa đọc được. 
            string DataSource = "DELLDELLDELL";
            string Catalog = "ItecAuth";
            connection.ConnectionString = $"Data Source={DataSource};Integrated Security=SSPI;Initial Catalog={Catalog}";

            // label
            //lbInfo.TextAlign = ContentAlignment.MiddleCenter;
            lbInfo.Left = (this.ClientSize.Width - lbInfo.Size.Width) / 4;
            

  

        }

        private void ShowTimerLogin()
        {
            // timer
            this.timerLogIn.Enabled = true;

        }

        private void timerLogIn_Tick(object sender, EventArgs e)
        {
            if (TimeLimit > 0)
            {
                TimeLimit--;
                int min = TimeLimit / 60;
                int sec = TimeLimit - (min * 60);
                lbInfo.Text = "Sign in time remaining.. " + min.ToString() + ":" + sec.ToString();
            }
            else
            {
                this.timerLogIn.Stop();
                MessageBox.Show("Out of logging in time. The application close.");
                Application.Exit();
            }
        }

        public FormLogin()
        {
            InitializeComponent();

            WhenOpenFormLogin();

            ShowTimerLogin();



        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            // MySQL server Command:
            /* 
            create database ItecAuth
            use ItecAuth
            create table AdminInfo(
	            username VARCHAR(50),
	            password VARCHAR(50)
            )

            insert into AdminInfo values ('ThayKhoa', 'AOOPKhoa')
            insert into AdminInfo values ('ThayHuy', 'AOOPHuy')

            select * from AdminInfo
             
             */
            try   // ---------------------- THIS FEATURE WORKS WELL ON MY LOCAL MACHINE ------------------------
                  // ---------------------- BECAUSE IT FITS WITH MY CONFIG LOCAL DB - MYSQL SERVER -------------
            {        
                //connection.Open();

                //command.Connection = connection;

                //command.CommandText = "select * from AdminInfo";
                //SqlDataReader reader = command.ExecuteReader();

                //if (reader.Read())
                //{
                //    if ((txtUsername.Text.Equals(reader["username"].ToString()) && txtPassword.Text.Equals(reader["password"].ToString())) || (txtUsername.Text.Equals("t") && txtPassword.Text.Equals("t")))
                //    {
                //        MessageBox.Show("Login Successfully", "Congratulation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //        FormExaminationMaker formExaminationMaker = new FormExaminationMaker { UserName = txtUsername.Text };
                //        this.timerLogIn.Stop();
                //        this.Hide();
                //        formExaminationMaker.ShowDialog();
                //    }
                //    else
                //    {
                //        Attempt++;
                //        MessageBox.Show($"Username or Password Incorrect!\n{Attempt} attempt(s)!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        txtUsername.Text = "Enter Username";
                //        txtPassword.Text = "Enter Password";
                //    }
                //}

                //connection.Close();

                // -----------------------------------------------------------------------------------------------------------
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //MessageBox.Show("Server not found");
            }
            finally
            {
                if ((txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("admin")))
                {
                    MessageBox.Show("Login Successfully", "Congratulation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormExaminationMaker formExaminationMaker = new FormExaminationMaker { UserName = txtUsername.Text };
                    this.timerLogIn.Stop();
                    this.Hide();
                    formExaminationMaker.ShowDialog();
                }
                else
                {
                    Attempt++;
                    MessageBox.Show($"Username or Password Incorrect!\n{Attempt} attempt(s)!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "Enter Username";
                    txtPassword.Text = "Enter Password";
                }
            }

        }


    }
}
