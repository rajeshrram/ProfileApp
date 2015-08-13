using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string UpdateProfileInformation(Profile profile)
    {
        ///TODO: server validations for profile data.
        try
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["localDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Profile (Name,Email, PhoneNumber, Message) VALUES (@Name, @Email, @PhoneNumber, @Message)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Name", profile.Name);
                cmd.Parameters.AddWithValue("@Email", profile.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", profile.PhoneNo);
                cmd.Parameters.AddWithValue("@Message", profile.Message);
                connection.Open();
                cmd.ExecuteNonQuery();
                return "Profile information saved successfully.";
            }
        }
        catch
        {
            return "Profile information not saved.";
        }
        
    }

}