using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;

namespace Clients.Pages.Members
{
    public class EditModel : PageModel
    {
        public MembersInfo membersInfo = new MembersInfo();
        public String errorMessage = "";
        public String successMessage = "";
        public void OnGet()
        {
            String id = Request.Query["id"];

            try
            {
                String connectionString = "Data Source=localhost;Initial Catalog=clients;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM members WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                membersInfo.id = "" + reader.GetInt32(0);
                                membersInfo.name = reader.GetString(1);
                                membersInfo.email = reader.GetString(2);
                                membersInfo.phone = reader.GetString(3);
                                membersInfo.address = reader.GetString(4);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
        }

        public void OnPost()
        {
            membersInfo.id = Request.Form["id"];
            membersInfo.name = Request.Form["name"];
            membersInfo.email = Request.Form["email"];
            membersInfo.phone = Request.Form["phone"];
            membersInfo.address = Request.Form["address"];

            if (membersInfo.name.Length == 0 || membersInfo.email.Length == 0 ||
                membersInfo.phone.Length == 0 || membersInfo.address.Length == 0)
            {
                errorMessage = "All the fields are required";
                return;
            }

            try
            {
                String connectionString = "Data Source=localhost;Initial Catalog=clients;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "UPDATE members " +
                        "SET name=@name, email=@email, phone=@phone, address=@address);" +
                        "WHERE id=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", membersInfo.name);
                        command.Parameters.AddWithValue("@email", membersInfo.email);
                        command.Parameters.AddWithValue("@phone", membersInfo.phone);
                        command.Parameters.AddWithValue("@address", membersInfo.address);
                        command.Parameters.AddWithValue("@id", membersInfo.id);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            Response.Redirect("/Members/Index");
        }
    }
}
