using MetroFramework.Forms;
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

namespace LibrarySystem
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }



        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool isNewUsersTable;

            Console.WriteLine(usernameBox.Text);
            Console.WriteLine(passwordBox.Text);

            // Create user table if not exist
            isNewUsersTable = tryCreateUserTable();
            
            // Create new admin account if users table is new
            if (isNewUsersTable == true)
            {

            } else
            {
                // TODO: Implement authentication with database
                if (usernameBox.Text == "admin" && passwordBox.Text == "admin")
                {
                    Main mainForm = new Main();
                    mainForm.Show();

                    // Hide the login form
                    this.Hide();
                }
            }



        } // end of loginBtn_Click

        /* Insert new user in users table */
        private static void createUser(string username, string password, bool isAdmin)
        {

        } // end of createUser

        /* If users table is not already created, create one */
        private static bool tryCreateUserTable()
        {
            using (SqlConnection con = new SqlConnection(
                Properties.Settings.Default.librarydbConnectionString))
            {
                // Open connection
                Console.WriteLine("Openning connection...");
                con.Open();


                try
                {
                    using (SqlCommand command = new SqlCommand(
                        "CREATE TABLE [dbo].[users] (" +
                        "[Id] INT NOT NULL," +
                        "[username] NCHAR(20) NULL," +
                        "[password] NCHAR(20) NULL," +
                        "[is_admin] INT DEFAULT((0))"))
                    {
                        // Execute the command
                        Console.WriteLine("Creating users table...");
                        command.ExecuteNonQuery();
                        
                        // return true indicating that we are just created a new users table
                        return true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Already have users table");
                    
                    // we already have a users table
                    return false;
                } // end of try catch

            } // end of using SqlConnection
        } // end of createUserTable


    }
}
