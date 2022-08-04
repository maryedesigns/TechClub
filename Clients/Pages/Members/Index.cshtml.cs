using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Clients.Pages.Members
{
    public class IndexModel : PageModel
    {
        //creating a list to store all members
        public List<MembersInfo> listMembers = new List<MembersInfo>();
        public void OnGet()
        {
            //filling the list with info
            try
            {
                String connectionString = "Data Source=localhost;Initial Catalog=clients;Integrated Security=True";

                //creating sqlconnection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //creating the sql query to read data from the table(members)
                    String sql = "SELECT * FROM members";

                    //creating the sql command
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MembersInfo membersinfo = new MembersInfo();
                                membersinfo.id = "" + reader.GetInt32(0);
                                membersinfo.name = reader.GetString(1);
                                membersinfo.email = reader.GetString(2);
                                membersinfo.phone = reader.GetString(3);
                                membersinfo.address = reader.GetString(4);
                                membersinfo.created_at = reader.GetDateTime(5).ToString();

                                listMembers.Add(membersinfo);
                            }   

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }

    //this stores only one member
    public class MembersInfo
    {
        public String id;
        public String name;
        public String email;
        public String phone;
        public String address;
        public String created_at;
    }
}
