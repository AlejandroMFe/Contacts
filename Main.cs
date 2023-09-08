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
        contactDetails.ShowDialog(this);
    }
    #endregion

    private void Main_Load(object sender, EventArgs e)
    {
        PopulateContacts();
    }

    public void PopulateContacts()
    {
        var contacts = _business.GetContacts();
        gridContacts.DataSource = contacts;
    }

    private void gridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

        if (cell.Value.ToString() == "Edit")
        {
            var contactDetails = new ContactDetails();
            contactDetails.LoadContact(new Contact()
            {
                Id = int.Parse(gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()),
                FirstName = gridContacts.Rows[e.RowIndex].Cells[1].Value.ToString() ?? string.Empty,
                LastName = gridContacts.Rows[e.RowIndex].Cells[2].Value.ToString() ?? string.Empty,
                Phone = gridContacts.Rows[e.RowIndex].Cells[3].Value.ToString() ?? string.Empty,
                Address = gridContacts.Rows[e.RowIndex].Cells[4].Value.ToString() ?? string.Empty,
            });
            contactDetails.ShowDialog(this);
        }
        else if (cell.Value.ToString() == "Delete")
        {
            int id = int.Parse(gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString());
            DeleteContact(id);
            PopulateContacts();
        }
    }

    private void DeleteContact(int id)
    {
        _business.DeleteContact(id);
    }
}
