using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agenda;
public partial class ContactDetails : Form
{
    private BusinessLogicLayer _businessLogicLayer;
    public ContactDetails()
    {
        InitializeComponent();
        _businessLogicLayer = new BusinessLogicLayer();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        SaveContact();
        Close();
        ((Main)Owner).PopulateContacts();
    }

    private void SaveContact()
    {
        var contact = new Contact();
        contact.FirstName = txtFirstName.Text;
        contact.LastName = txtLastName.Text;
        contact.Phone = txtPhone.Text;
        contact.Address = txtAddress.Text;

        _businessLogicLayer.SaveContact(contact);
    }
}
