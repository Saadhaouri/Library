using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HY
{
    public partial class Livre : UserControl
    {
        public Livre()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-J9BA559\\MSSQLSERVER01;Initial Catalog=Library;Integrated Security=True");

        private void btnread_Click(object sender, EventArgs e)
        {
            DGV.Rows.Clear(); // Clear the DataGridView
            string query = "SELECT * FROM Book";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DGV.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]); // Assuming you want to display columns 0, 1, 2, 3, and 5
                }
            }
            else
            {
                MessageBox.Show("La table est vide .");
            }

            con.Close();

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

        private void Livre_Load(object sender, EventArgs e)
        {
            LoadCategories();
            btnread_Click(sender, e);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Book (title, author, publication_date, genre, availability_status,Quantite) VALUES (@title, @author, @publicationDate, @genre, @availabilityStatus,{Quantitetxt.Text})";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@title", titletxt.Text);
            cmd.Parameters.AddWithValue("@author", autheurtxt.Text);
            cmd.Parameters.AddWithValue("@publicationDate", dateP.Value.Date); // Utilisez .Value.Date pour obtenir seulement la date sélectionnée
            cmd.Parameters.AddWithValue("@genre", memberships.Text);
            cmd.Parameters.AddWithValue("@availabilityStatus", Disponibletxt.Text);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Livre inséré avec succès.");
                btnread_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Échec de l'insertion du livre.");
            }

        }
        int position;
        int ADL;
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.DGV.CurrentRow.Index;
            ADL = int.Parse(this.DGV.Rows[position].Cells[0].Value.ToString());


            this.idtxt.Text = this.DGV.Rows[position].Cells[0].Value.ToString();
            this.titletxt.Text = this.DGV.Rows[position].Cells[1].Value.ToString();
            this.autheurtxt.Text = this.DGV.Rows[position].Cells[2].Value.ToString();
            this.memberships.Text = this.DGV.Rows[position].Cells[4].Value.ToString();
            this.Disponibletxt.Text = this.DGV.Rows[position].Cells[5].Value.ToString();
            this.Quantitetxt.Text = this.DGV.Rows[position].Cells[6].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ///confirmation 
            DialogResult dialog = MessageBox.Show(" Sure ? ", " confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " DELETE FROM Book where book_id = @ID ";
            cmd.Parameters.AddWithValue("@ID", ADL);
            con.Open();
            cmd.ExecuteNonQuery();
            DGV.Rows.RemoveAt(position);
            MessageBox.Show("la personne a ete Suppremmer ");

            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Book SET title = @title, author = @author, publication_date = @publicationDate, "
                + "genre = @genre, availability_status = @availabilityStatus WHERE book_id = @bookId";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@title", titletxt.Text);
            cmd.Parameters.AddWithValue("@author", autheurtxt.Text);
            cmd.Parameters.AddWithValue("@publicationDate", dateP.Value.Date);
            cmd.Parameters.AddWithValue("@genre", memberships.Text);
            cmd.Parameters.AddWithValue("@availabilityStatus", Disponibletxt.Text);
            cmd.Parameters.AddWithValue("@bookId", idtxt.Text);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                btnread_Click(sender, e);
                MessageBox.Show("Livre mis à jour avec succès.");
            }
            else
            {
                MessageBox.Show("Échec de la mise à jour du livre.");
            }
        }
    }
}
