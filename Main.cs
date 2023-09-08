namespace Agenda;

public partial class Main : Form
{
    private BusinessLogicLayer _business;
    public Main()
    {
        InitializeComponent();
        _business = new BusinessLogicLayer();
    }

    #region Events
    private void Main_Load(object sender, EventArgs e)
    {
        PopulateContacts();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        OpenContactDetailsDialog();
    }

    private void gridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        var cell = (DataGridViewLinkCell)gridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

        if (cell.Value.ToString() == "Edit")
            EditContact(e);

        if (cell.Value.ToString() == "Delete")
            DeleteContact(e);
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        PopulateContacts(txtSearch.Text);
        txtSearch.Text = string.Empty;
    }
    #endregion

    #region Private Methods
    private void OpenContactDetailsDialog()
    {
        var contactDetails = new ContactDetails();
        contactDetails.ShowDialog(this);
    }

    private void EditContact(DataGridViewCellEventArgs e)
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

    private void DeleteContact(DataGridViewCellEventArgs e)
    {
        var id = int.Parse(gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString());
        _business.DeleteContact(id);
        PopulateContacts();
    }

    #endregion

    #region Public Methods
    public void PopulateContacts(string? searchText = null)
    {
        var contacts = _business.GetContacts(searchText);
        gridContacts.DataSource = contacts;
    }
    #endregion
}
