using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Agenda;

// Responsabilidad
//      Como acceder a los datos
//      Como ejecutar las consultas
public class DataAccessLayer
{
    // private SqlConnection _connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=ATP\\afernandez;Initial Catalog=Contacts;Data Source=DESARROLLO05\\SQLEXPRESS");
    private SqlConnection _connection = new SqlConnection("Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = Contacts; Data Source = Silver\\SQLEXPRESS");

    public void CreateContact(Contact contact)
    {
        try
        {
            _connection.Open();
            string query = @"
                                INSERT INTO Contacts(FirstName, LastName, Phone, Address) 
                                VALUES  (@FirstName,@LastName,@Phone,@Address)";
            SqlParameter firstName = new SqlParameter();
            firstName.ParameterName = "@FirstName";
            firstName.Value = contact.FirstName;
            firstName.DbType = System.Data.DbType.String;

            SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
            SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
            SqlParameter address = new SqlParameter("@Address", contact.Address);

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.Add(firstName);
            command.Parameters.Add(lastName);
            command.Parameters.Add(phone);
            command.Parameters.Add(address);

            command.ExecuteNonQuery();
        }
        catch
        {
        }
        finally { _connection.Close(); }
    }

    public List<Contact> GetAllContacts()
    {
        var contacts = new List<Contact>();
        try
        {
            _connection.Open();
            string query = @"select Id, FirstName, LastName, Phone, Address
                             from Contacts";

            SqlCommand command = new SqlCommand(query, _connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                contacts.Add(new Contact()
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    Phone = (string)reader["Phone"],
                    Address = (string)reader["Address"]
                });
            }
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            _connection.Close();
        }
        return contacts;
    }

    internal void UpdateContact(Contact contact) => throw new NotImplementedException();
}
