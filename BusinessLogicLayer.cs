using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public List<Contact> GetContacts() => _data.GetAllContacts();
    
    public void DeleteContact(int id)
    {
        _data.DeleteContact(id);
    }
}
