using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HY
{
    public partial class Prete : UserControl
    {
        public Prete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-J9BA559\\MSSQLSERVER01;Initial Catalog=Library;Integrated Security=True");

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Loan ( book_id, member_id, loan_date, due_date, return_status, fines) " +
                               "VALUES ( @bookId, @memberId, @loanDate, @dueDate, @returnStatus, @fines)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@memberId", MemberBox.SelectedValue);
                command.Parameters.AddWithValue("@bookId", LivreBox.SelectedValue);
                command.Parameters.AddWithValue("@loanDate", loanDate.Value.Date);
                command.Parameters.AddWithValue("@dueDate", dueDate.Value.Date);
                command.Parameters.AddWithValue("@returnStatus", returnStatus.Text);
                command.Parameters.AddWithValue("@fines", fines.Text);

                con.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Prêt ajouté avec succès.");
                }
                else
                {
                    MessageBox.Show("Échec de l'ajout du prêt.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            con.Close();

        }
        private void LoadMember()
        {
            // Assuming you have a SqlConnection object named 'connection' to connect to the database


            try
            {
                // Open the connection
                con.Open();

                // Prepare the SQL SELECT statement
                string selectQuery = "SELECT member_id, name FROM Member";

                // Create a SqlCommand object with the select query and connection
                SqlCommand command = new SqlCommand(selectQuery, con);

                // Create a SqlDataReader to retrieve the data
                SqlDataReader reader = command.ExecuteReader();

                // Create a DataTable to hold the category data
                DataTable dataTable = new DataTable();

                // Load the data from the reader into the DataTable
                dataTable.Load(reader);

                // Set the ComboBox DataSource to the DataTable
                MemberBox.DataSource = dataTable;

                // Set the DisplayMember and ValueMember properties
                MemberBox.DisplayMember = "name";
                MemberBox.ValueMember = "Member_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Members: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }
        private void LoadLivre()
        {
            // Assuming you have a SqlConnection object named 'connection' to connect to the database


            try
            {
                // Open the connection
                con.Open();

                // Prepare the SQL SELECT statement
                string selectQuery = "SELECT book_id, title FROM Book";

                // Create a SqlCommand object with the select query and connection
                SqlCommand command = new SqlCommand(selectQuery, con);

                // Create a SqlDataReader to retrieve the data
                SqlDataReader reader = command.ExecuteReader();

                // Create a DataTable to hold the category data
                DataTable dataTable = new DataTable();

                // Load the data from the reader into the DataTable
                dataTable.Load(reader);

                // Set the ComboBox DataSource to the DataTable
                LivreBox.DataSource = dataTable;

                // Set the DisplayMember and ValueMember properties
                LivreBox.DisplayMember = "title";
                LivreBox.ValueMember = "book_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Members: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }
        private void Prete_Load(object sender, EventArgs e)
        {
            LoadLivre();
            LoadMember();
            btnread_Click(sender, e);   
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            
                DGV.Rows.Clear(); // Clear the DataGridView

                string query = "SELECT l.loan_id, m.name, b.title, l.loan_date, l.due_date, l.return_status, l.fines " +
                               "FROM Loan l " +
                               "JOIN Member m ON l.member_id = m.member_id " +
                               "JOIN Book b ON l.book_id = b.book_id";

                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            DGV.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La table est vide");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                }
               
                    con.Close();
               
            

        }
        int position;
        int ADL;

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.DGV.CurrentRow.Index;
            ADL = int.Parse(this.DGV.Rows[position].Cells[0].Value.ToString());
       
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
          
                DialogResult dialog = MessageBox.Show("Êtes-vous sûr ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                    return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Loan WHERE Loan_id = @ID";
                cmd.Parameters.AddWithValue("@ID", ADL);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DGV.Rows.RemoveAt(position);
                    MessageBox.Show("La réservation a été supprimée avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            

        }
    }
}
