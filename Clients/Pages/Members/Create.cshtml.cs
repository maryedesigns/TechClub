using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;

namespace Clients.Pages.Members
{
    public class CreateModel : PageModel
    {
        public MembersInfo membersInfo = new MembersInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
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

            //saving data(new member) into the database
            try
            {
                String connectionString = "Data Source=localhost;Initial Catalog=clients;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO members " +
                        "(name, email, phone, address) VALUES " +
                        "(@name, @email, @phone, @address);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", membersInfo.name);
                        command.Parameters.AddWithValue("@email", membersInfo.email);
                        command.Parameters.AddWithValue("@phone", membersInfo.phone);
                        command.Parameters.AddWithValue("@address", membersInfo.address);

                        command.ExecuteNonQuery();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            membersInfo.name = "";
            membersInfo.email = "";
            membersInfo.phone = "";
            membersInfo.address = "";
            successMessage = "New member added succesfully";

            Response.Redirect("/Members/Index");
        }
    }
}
