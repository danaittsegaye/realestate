using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace WindowsFormsApp1.Forms
{
    public partial class FormSignUp : Form
    {
        // Used to make panel draggable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
        }

        private void signUp()
        {
            DatabaseCore core = new DatabaseCore();
            //DatabaseCore.closeConnecton();
            DatabaseCore.connectToDB("p", "p");

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@first_name", textBoxFirstName.Text));
            parameters.Add(new SqlParameter("@last_name", textBoxLastName.Text));
            parameters.Add(new SqlParameter("@phone", textBoxPhone.Text));
            parameters.Add(new SqlParameter("@address", textBoxAddress.Text));
            //this should be removed in the future
            parameters.Add(new SqlParameter("@id", new Random().Next()));
            parameters.Add(new SqlParameter("@email", textBoxEmail.Text));
            parameters.Add(new SqlParameter("@password", textBoxPassword.Text));
            //this should be removed in the future
            parameters.Add(new SqlParameter("@role", "user"));

            core.RunStored_Procedure("[SP_addEmployee]", parameters);
        }

        private bool checkIfEmpty()
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxPhone.Text == "" ||
                textBoxAddress.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("please enter all the fields to sign up");
                return true;
            }

            return false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!checkIfEmpty())
            {
                if (textBoxPassword.Text == textBoxConfirmPaasword.Text)
                {
                    try
                    {
                        signUp();
                        new MainWindow(textBoxFirstName.Text + " " + textBoxLastName.Text).Show();
                        this.Hide();
                    }
                    catch (SqlException exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("this email is already in use");
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
        }
    }
}
