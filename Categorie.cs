using HY.LibraryDataSetTableAdapters;
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

namespace HY
{
    public partial class Categorie : UserControl
    {
        public Categorie()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-J9BA559\\MSSQLSERVER01;Initial Catalog=Library;Integrated Security=True");

        private void btnread_Click(object sender, EventArgs e)
        {
            DGV.Rows.Clear();// viderdata grid view  
            string Query = " SELECT * FROM Category ";
            // add la commande de sql in Query string 
            SqlCommand cmd = new SqlCommand(Query, con);
            // affecte la commande a la chaine 
            con.Open(); // Open data base 
            SqlDataReader dr = cmd.ExecuteReader();// Run Query 
            if (dr.HasRows)// si la table has rows pliener 

            {

                while (dr.Read())
                {
                    this.DGV.Rows.Add(dr[0], dr[1]);
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
            string insertQuery = "INSERT INTO Category ( category_name) VALUES ( @CategoryName)";

            try
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    // Set parameter values from the text boxes
                   
                    command.Parameters.AddWithValue("@CategoryName", categorytxt.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Données insérées avec succès.");
                        con.Close();
                        btnread_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Échec de l'insertion des données.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting data: " + ex.Message);
            }
            categorytxt.Text = string.Empty; 
        }

        private void Categorie_Load(object sender, EventArgs e)
        {
            btnread_Click(sender, e);
            categorytxt.Focus();
        }
        int position;
        int ADL;

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.DGV.CurrentRow.Index;
            ADL = int.Parse(this.DGV.Rows[position].Cells[0].Value.ToString());  
            categorytxt.Text = this.DGV.Rows[position].Cells[1].Value.ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            // Confirmation
            DialogResult dialog = MessageBox.Show("Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;

            try
            {
             
                // Delete the member
                SqlCommand deleteMemberCmd = new SqlCommand("DELETE FROM Category  WHERE category_id = @ID", con );
                deleteMemberCmd.Parameters.AddWithValue("@ID", ADL);
                int rowsAffected = deleteMemberCmd.ExecuteNonQuery();

            
                    MessageBox.Show("La Category a été supprimée avec succès.");
                    DGV.Rows.RemoveAt(position);
                
                
                 
                   con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE Category SET category_name = @CategoryName WHERE category_id = @CategoryId";

            try
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(updateQuery, con))
                {
                    // Set parameter values from the text boxes
                    command.Parameters.AddWithValue("@CategoryName", categorytxt.Text);
                    command.Parameters.AddWithValue("@CategoryId",ADL);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        btnread_Click(sender, e);
                        MessageBox.Show("Données mises à jour avec succès.");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Échec de la mise à jour des données.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour des données : " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
