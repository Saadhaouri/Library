using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HY
{
    public partial class Reservation : UserControl
    {
        public Reservation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-J9BA559\\MSSQLSERVER01;Initial Catalog=Library;Integrated Security=True");

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
        private void Reservation_Load(object sender, EventArgs e)
        {
            LoadMember();
            LoadLivre();
            btnread_Click(sender, e);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Reservation (member_id, book_id, reservation_date, status) " +
                  "VALUES (@memberId, @bookId, @reservationDate, @status)";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@memberId", MemberBox.SelectedValue);
            command.Parameters.AddWithValue("@bookId", LivreBox.SelectedValue);
            command.Parameters.AddWithValue("@reservationDate", DateR.Value.Date);
            command.Parameters.AddWithValue("@status", StatusBox.Text);

            
                con.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Réservation insérée avec succès.");
               
                }
                else
                {
                    MessageBox.Show("Échec de l'insertion de la réservation.");
                }
            
          
               
           
           
                con.Close();  
            btnread_Click(sender, e);
            
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            DGV.Rows.Clear(); // Vider le DataGridView

            string query = "SELECT r.reservation_id, m.name, b.title, r.reservation_date, r.status " +
                           "FROM Reservation r " +
                           "JOIN Member m ON r.member_id = m.member_id " +
                           "JOIN Book b ON r.book_id = b.book_id";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DGV.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
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

            this.MemberBox.Text  = this.DGV.Rows[position].Cells[1].Value.ToString(); 
            this.LivreBox.Text = this.DGV.Rows[position].Cells[2].Value.ToString();
            this.StatusBox.Text = this.DGV.Rows[position].Cells[4].Value.ToString();

        }
        
        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Êtes-vous sûr ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Reservation WHERE reservation_id = @ID";
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
           
                con.Close();
            


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Reservation SET member_id = @memberId, book_id = @bookId, reservation_date = @reservationDate, status = @status WHERE reservation_id = @reservationId";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@memberId", MemberBox.SelectedValue);
            command.Parameters.AddWithValue("@bookId", LivreBox.SelectedValue);
            command.Parameters.AddWithValue("@reservationDate", DateR.Value.Date);
            command.Parameters.AddWithValue("@status", StatusBox.Text);
            command.Parameters.AddWithValue("@reservationId", ADL);

            try
            {
                con.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Réservation mise à jour avec succès.");
                    btnread_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Échec de la mise à jour de la réservation.");
                }
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
