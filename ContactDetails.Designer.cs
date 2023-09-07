namespace Agenda;

partial class ContactDetails
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        txtFirstName = new TextBox();
        txtLastName = new TextBox();
        label2 = new Label();
        txtPhone = new TextBox();
        label3 = new Label();
        txtAddress = new TextBox();
        label4 = new Label();
        btnSave = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(45, 63);
        label1.Name = "label1";
        label1.Size = new Size(102, 25);
        label1.TabIndex = 0;
        label1.Text = "First Name";
        // 
        // txtFirstName
        // 
        txtFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        txtFirstName.Location = new Point(153, 60);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(177, 32);
        txtFirstName.TabIndex = 1;
        // 
        // txtLastName
        // 
        txtLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        txtLastName.Location = new Point(153, 113);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(177, 32);
        txtLastName.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(45, 116);
        label2.Name = "label2";
        label2.Size = new Size(100, 25);
        label2.TabIndex = 2;
        label2.Text = "Last Name";
        // 
        // txtPhone
        // 
        txtPhone.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        txtPhone.Location = new Point(153, 168);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(177, 32);
        txtPhone.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(45, 171);
        label3.Name = "label3";
        label3.Size = new Size(66, 25);
        label3.TabIndex = 4;
        label3.Text = "Phone";
        // 
        // txtAddress
        // 
        txtAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        txtAddress.Location = new Point(153, 220);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(177, 32);
        txtAddress.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(45, 223);
        label4.Name = "label4";
        label4.Size = new Size(79, 25);
        label4.TabIndex = 6;
        label4.Text = "Address";
        // 
        // btnSave
        // 
        btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnSave.Location = new Point(79, 285);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(109, 34);
        btnSave.TabIndex = 8;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnCancel.Location = new Point(194, 285);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(109, 34);
        btnCancel.TabIndex = 9;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // ContactDetails
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(387, 367);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        Controls.Add(txtAddress);
        Controls.Add(label4);
        Controls.Add(txtPhone);
        Controls.Add(label3);
        Controls.Add(txtLastName);
        Controls.Add(label2);
        Controls.Add(txtFirstName);
        Controls.Add(label1);
        Name = "ContactDetails";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ContactDetails";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtFirstName;
    private TextBox txtLastName;
    private Label label2;
    private TextBox txtPhone;
    private Label label3;
    private TextBox txtAddress;
    private Label label4;
    private Button btnSave;
    private Button btnCancel;
}