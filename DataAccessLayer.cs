using System.Data.SqlClient;

namespace Agenda;

// Responsabilidad
//      Como acceder a los datos
//      Como ejecutar las consultas
public class DataAccessLayer
{
    private SqlConnection _connection = new("Integrated Security=SSPI;Persist Security Info=False;User ID=ATP\\afernandez;Initial Catalog=Contacts;Data Source=DESARROLLO05\\SQLEXPRESS");
    //private SqlConnection _connection = new SqlConnection("Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = Contacts; Data Source = Silver\\SQLEXPRESS");

    public void CreateContact(Contact contact)
    {
        try
        {
            _connection.Open();
            var query = @"
                                INSERT INTO Contacts(FirstName, LastName, Phone, Address) 
                                VALUES  (@FirstName,@LastName,@Phone,@Address)";
            var firstName = new SqlParameter();
            firstName.ParameterName = "@FirstName";
            firstName.Value = contact.FirstName;
            firstName.DbType = System.Data.DbType.String;

            var lastName = new SqlParameter("@LastName", contact.LastName);
            var phone = new SqlParameter("@Phone", contact.Phone);
            var address = new SqlParameter("@Address", contact.Address);

            var command = new SqlCommand(query, _connection);

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

    public List<Contact> GetContacts(string? searchText = null)
    {
        var contacts = new List<Contact>();
        try
        {
            _connection.Open();

            var query = @"select Id, FirstName, LastName, Phone, Address
                          from Contacts ";

            var command = new SqlCommand();

            if (!string.IsNullOrEmpty(searchText))
            {
                // with filter
                query += @" WHERE FirstName LIKE @searchText  OR LastName LIKE @searchText OR  Address LIKE @searchText";
                command.Parameters.Add(new SqlParameter("@searchText", $"%{searchText}%"));
            }

            command.CommandText = query;
            command.Connection = _connection;

            var reader = command.ExecuteReader();

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

    public void UpdateContact(Contact contact)
    {
        try
        {
            _connection.Open();
            var query = @"update Contacts
                                 set FirstName = @FirstName,    
                                     LastName = @LastName,
                                     Phone = @Phone,
                                     Address = @Address
                            where Id = @Id";

            var id = new SqlParameter("@Id", contact.Id);
            var firstName = new SqlParameter("@FirstName", contact.FirstName);
            var lastName = new SqlParameter("@LastName", contact.LastName);
            var phone = new SqlParameter("@Phone", contact.Phone);
            var address = new SqlParameter("@Address", contact.Address);

            var command = new SqlCommand(query, _connection);
            command.Parameters.Add(id);
            command.Parameters.Add(firstName);
            command.Parameters.Add(lastName);
            command.Parameters.Add(phone);
            command.Parameters.Add(address);

            command.ExecuteNonQuery();
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            _connection.Close();
        }
    }

    public void DeleteContact(int id)
    {
        try
        {
            // 1° Open the connection with the Data Base
            _connection.Open();

            // 2° Create the query
            var query = @"delete from Contacts where Id = @Id";

            // 3° Pass the parameters to the query
            var command = new SqlCommand(query, _connection);
            command.Parameters.Add(new SqlParameter("@Id", id));

            // 4° Excecute the query
            command.ExecuteNonQuery();
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            // 5° Close the connection with the Data Base
            _connection.Close();
        }
    }
}
