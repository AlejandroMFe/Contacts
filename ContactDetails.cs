namespace Agenda;
public partial class ContactDetails : Form
{
    private BusinessLogicLayer _businessLogicLayer;
    private Contact _contact;
    public ContactDetails()
    {
        InitializeComponent();
        _businessLogicLayer = new BusinessLogicLayer();
    }

    #region Events
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
    #endregion

    #region Private Methods
    private void SaveContact()
    {
        var contact = new Contact();
        contact.FirstName = txtFirstName.Text;
        contact.LastName = txtLastName.Text;
        contact.Phone = txtPhone.Text;
        contact.Address = txtAddress.Text;

        contact.Id = _contact is not null ? _contact.Id : 0;

        _businessLogicLayer.SaveContact(contact);
    }

    public void LoadContact(Contact contact)
    {
        _contact = contact;
        if (contact is not null)
        {
            ClearForms();

            txtFirstName.Text = contact.FirstName;
            txtLastName.Text = contact.LastName;
            txtPhone.Text = contact.Phone;
            txtAddress.Text = contact.Address;
        }
    }

    private void ClearForms()
    {
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
        txtPhone.Text = string.Empty;
        txtAddress.Text = string.Empty;
    }
    #endregion
}
