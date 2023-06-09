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
using System.Xml.Linq;

namespace HY
{
    public partial class Membre : UserControl
    {
        public Membre()
        {
            InitializeComponent();
        }

       SqlConnection con = new SqlConnection("Data Source=DESKTOP-J9BA559\\MSSQLSERVER01;Initial Catalog=Library;Integrated Security=True");

        private void Membre_Load(object sender, EventArgs e)
        {
            LoadCategories();
            btnread_Click(sender, e);

        }
        private void LoadCategories()
        {
            // Assuming you have a SqlConnection object named 'connection' to connect to the database


            try
            {
                // Open the connection
                con.Open();

                // Prepare the SQL SELECT statement
                string selectQuery = "SELECT category_id, category_name FROM Category";

                // Create a SqlCommand object with the select query and connection
                SqlCommand command = new SqlCommand(selectQuery, con);

                // Create a SqlDataReader to retrieve the data
                SqlDataReader reader = command.ExecuteReader();

                // Create a DataTable to hold the category data
                DataTable dataTable = new DataTable();

                // Load the data from the reader into the DataTable
                dataTable.Load(reader);

                // Set the ComboBox DataSource to the DataTable
                memberships.DataSource = dataTable;

                // Set the DisplayMember and ValueMember properties
                memberships.DisplayMember = "category_name";
                memberships.ValueMember = "category_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {

            DGV.Rows.Clear();// viderdata grid view  
            string Query = " SELECT * FROM Member ";
            // add la commande de sql in Query string 
            SqlCommand cmd = new SqlCommand(Query, con);
            // affecte la commande a la chaine 
            con.Open(); // Open data base 
            SqlDataReader dr = cmd.ExecuteReader();// Run Query 
            if (dr.HasRows)// si la table has rows pliener 

            {

                while (dr.Read())
                {
                    this.DGV.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                    // planier les Rows par dataadapter  

                }

            }
            else // si non les zone est vide 
            {
                MessageBox.Show("la table est vide ");
            }
            con.Close();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {


            if (!checkinfo())
            {
                MessageBox.Show(" Veuillez entrer Touot Les donnes", "Checkinfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int memberId = Convert.ToInt32(IDtxt.Text);
            string name = Member.Text;
            string contactInfo = Phone.Text;
            string membershipId = memberships.Text;

            // Prepare the SQL INSERT statement with parameterized query
            string insertQuery = "INSERT INTO Member (member_id, name, contact_info, membership_id) VALUES (@memberId, @name, @contactInfo, @membershipId)";

            // Create a SqlCommand object with the insert query and connection
            SqlCommand command = new SqlCommand(insertQuery, con);

            // Add parameter values to the SqlCommand
            command.Parameters.AddWithValue("@memberId", memberId);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@contactInfo", contactInfo);
            command.Parameters.AddWithValue("@membershipId", membershipId);

            // Open the connection
            con.Open();

            // Execute the insert query
            int rowsAffected = command.ExecuteNonQuery();

            // Close the connection
            con.Close();

            // Check if the insert was successful
            if (rowsAffected > 0)
            {
                MessageBox.Show("Member data inserted successfully.");
            }
            else
            {
                MessageBox.Show("Failed to insert member data.");

            }
            btnread_Click(sender, e);
        }

            int position;
            int ADL;
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.DGV.CurrentRow.Index;
            ADL = int.Parse(this.DGV.Rows[position].Cells[0].Value.ToString());

            this.IDtxt.Text = this.DGV.Rows[position].Cells[0].Value.ToString(); 
            this.Member.Text = this.DGV.Rows[position].Cells[1].Value.ToString();
            this.Phone.Text= this.DGV.Rows[position].Cells[2].Value.ToString();
            this.memberships.Text = this.DGV.Rows[position].Cells[3].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Confirmation
            DialogResult dialog = MessageBox.Show("Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;

            try
            {
                // Delete associated reservations
                SqlCommand deleteReservationsCmd = new SqlCommand("DELETE FROM Reservation WHERE member_id = @ID", con);
                deleteReservationsCmd.Parameters.AddWithValue("@ID", ADL);
                con.Open();
                deleteReservationsCmd.ExecuteNonQuery();

                // Delete the member
                SqlCommand deleteMemberCmd = new SqlCommand("DELETE FROM Member WHERE member_id = @ID", con);
                deleteMemberCmd.Parameters.AddWithValue("@ID", ADL);
                int rowsAffected = deleteMemberCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("La personne a été supprimée avec succès.");
                    DGV.Rows.RemoveAt(position);
                }
                else
                {
                    MessageBox.Show("Échec de la suppression de la personne.");
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have a SqlConnection object named 'connection' to connect to the database

                // Open the connection
                con.Open();

                // Prepare the SQL UPDATE statement
                string updateQuery = "UPDATE Member SET name = @name, contact_info = @contactInfo WHERE member_id = @memberId";

                // Create a SqlCommand object with the update query and connection
                SqlCommand command = new SqlCommand(updateQuery, con);

                // Add parameters to the command
                command.Parameters.AddWithValue("@name", Member.Text);
                command.Parameters.AddWithValue("@contactInfo", Phone.Text);
                command.Parameters.AddWithValue("@memberId", ADL);

                // Execute the update command
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Member updated successfully.");
                }
                else
                {
                    MessageBox.Show("No rows were updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating member: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
            btnread_Click(sender, e);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            IDtxt.Clear();
            Member.Clear(); 
            Phone.Clear();  
            memberships.SelectedItem = null;
        }

        private bool checkinfo()
        {
            if (IDtxt.Equals(string.Empty) || Member.Text.Equals(string.Empty) || Phone.Text.ToString().Equals(string.Empty)  )

                return false;

            return true;

        }

    }
}
