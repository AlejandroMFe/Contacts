namespace Agenda;

public partial class Main : Form
{
    private BusinessLogicLayer _business;
    public Main()
    {
        InitializeComponent();
        _business = new BusinessLogicLayer();
    }

    #region EVENTS
    private void btnAdd_Click(object sender, EventArgs e)
    {
        OpenContactDetailsDialog();
    }
    #endregion

    #region PRIVATE METHODS
    private void OpenContactDetailsDialog()
    {
        var contactDetails = new ContactDetails();
        contactDetails.ShowDialog();
    }
    #endregion

    private void Main_Load(object sender, EventArgs e)
    {
        PopulateContacts();
    }

    private void PopulateContacts()
    {
        var contacts = _business.GetContacts();
    }
}
