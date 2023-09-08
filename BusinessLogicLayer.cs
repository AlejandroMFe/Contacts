namespace Agenda;
public class BusinessLogicLayer
{
    private DataAccessLayer _data;

    public BusinessLogicLayer()
    {
        _data = new DataAccessLayer();
    }

    public Contact SaveContact(Contact contact)
    {
        if (contact.Id == 0)
            // new contact
            _data.CreateContact(contact);
        else
            _data.UpdateContact(contact);

        return contact;
    }

    public List<Contact> GetContacts(string? searchText) => _data.GetContacts(searchText);

    public void DeleteContact(int id)
    {
        _data.DeleteContact(id);
    }
}
