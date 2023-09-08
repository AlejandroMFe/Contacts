namespace Agenda;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        gridContacts = new DataGridView();
        contactBindingSource = new BindingSource(components);
        labelSearch = new Label();
        txtSearch = new TextBox();
        btnSearch = new Button();
        btnAdd = new Button();
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        Edit = new DataGridViewLinkColumn();
        Delete = new DataGridViewLinkColumn();
        ((System.ComponentModel.ISupportInitialize)gridContacts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
        SuspendLayout();
        // 
        // gridContacts
        // 
        gridContacts.AutoGenerateColumns = false;
        gridContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridContacts.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, Edit, Delete });
        gridContacts.DataSource = contactBindingSource;
        gridContacts.Location = new Point(12, 73);
        gridContacts.Name = "gridContacts";
        gridContacts.RowTemplate.Height = 25;
        gridContacts.Size = new Size(776, 349);
        gridContacts.TabIndex = 0;
        gridContacts.CellContentClick += gridContacts_CellContentClick;
        // 
        // contactBindingSource
        // 
        contactBindingSource.DataSource = typeof(Contact);
        // 
        // labelSearch
        // 
        labelSearch.AutoSize = true;
        labelSearch.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        labelSearch.Location = new Point(14, 28);
        labelSearch.Name = "labelSearch";
        labelSearch.Size = new Size(70, 24);
        labelSearch.TabIndex = 1;
        labelSearch.Text = "Search";
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        txtSearch.Location = new Point(90, 25);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(505, 29);
        txtSearch.TabIndex = 2;
        // 
        // btnSearch
        // 
        btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnSearch.Location = new Point(601, 25);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(111, 29);
        btnSearch.TabIndex = 3;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // btnAdd
        // 
        btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnAdd.Location = new Point(718, 25);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(72, 29);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // idDataGridViewTextBoxColumn
        // 
        idDataGridViewTextBoxColumn.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn.HeaderText = "Id";
        idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
        // 
        // firstNameDataGridViewTextBoxColumn
        // 
        firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
        firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
        firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
        // 
        // lastNameDataGridViewTextBoxColumn
        // 
        lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
        lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
        lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
        // 
        // phoneDataGridViewTextBoxColumn
        // 
        phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
        phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
        phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
        // 
        // addressDataGridViewTextBoxColumn
        // 
        addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
        addressDataGridViewTextBoxColumn.HeaderText = "Address";
        addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
        // 
        // Edit
        // 
        Edit.HeaderText = "Edit";
        Edit.Name = "Edit";
        Edit.ReadOnly = true;
        Edit.Text = "Edit";
        Edit.UseColumnTextForLinkValue = true;
        // 
        // Delete
        // 
        Delete.HeaderText = "Delete";
        Delete.Name = "Delete";
        Delete.ReadOnly = true;
        Delete.Text = "Delete";
        Delete.UseColumnTextForLinkValue = true;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnAdd);
        Controls.Add(btnSearch);
        Controls.Add(txtSearch);
        Controls.Add(labelSearch);
        Controls.Add(gridContacts);
        Name = "Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Contacts";
        Load += Main_Load;
        ((System.ComponentModel.ISupportInitialize)gridContacts).EndInit();
        ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView gridContacts;
    private Label labelSearch;
    private TextBox txtSearch;
    private Button btnSearch;
    private Button btnAdd;
    private BindingSource contactBindingSource;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    private DataGridViewLinkColumn Edit;
    private DataGridViewLinkColumn Delete;
}
