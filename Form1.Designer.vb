<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database3DataSet = New MobileManagentSystem.Database3DataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustDetailBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewCustomerDataSet = New MobileManagentSystem.NewCustomerDataSet()
        Me.CustDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustDetailTableAdapter = New MobileManagentSystem.NewCustomerDataSetTableAdapters.CustDetailTableAdapter()
        Me.CustDetailBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New MobileManagentSystem.Database3DataSetTableAdapters.Table1TableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustDetailBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewCustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustDetailBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(39, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Customer Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnReset)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.TxtNumber)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(10, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 390)
        Me.Panel1.TabIndex = 2
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAdd.Location = New System.Drawing.Point(287, 211)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(64, 26)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.Location = New System.Drawing.Point(255, 288)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(64, 26)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnReset.Location = New System.Drawing.Point(130, 288)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(64, 26)
        Me.BtnReset.TabIndex = 10
        Me.BtnReset.Text = "DELETE"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Problem Discription", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 211)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(278, 57)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database3DataSet
        '
        'Database3DataSet
        '
        Me.Database3DataSet.DataSetName = "Database3DataSet"
        Me.Database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 21)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "PROBLEM DISCRIPTION "
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Device Model", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Galaxy S25 Ultra", "Galaxy S25", "Galaxy A54", "Galaxy S24 Ultra", "iPhone 15 Pro Max", "iPhone 15 Pro", "iPhone 15", "Redmi Note 14 Pro+", "Mi 13 Ultra", "Mi 13", "OnePlus 13", "OnePlus Nord 4", "OnePlus 13R", "P60 Pro", "Mate 50 Pro", "Nova 11", "Find X6 Pro", "Reno 10 Pro", "A98", "Xperia 1 V", "Xperia 5 V", "Xperia 10 V", "Nokia X50", "Nokia G60", "Nokia C40"})
        Me.ComboBox2.Location = New System.Drawing.Point(128, 153)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(224, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'TxtNumber
        '
        Me.TxtNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Number", True))
        Me.TxtNumber.Location = New System.Drawing.Point(85, 79)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(270, 20)
        Me.TxtNumber.TabIndex = 6
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.Location = New System.Drawing.Point(5, 288)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(64, 26)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DEVICE MODEL :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Brand Name", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Apple", "Samsung", "Xiaomi", "OnePlus", "Google", "Huawei", "Oppo", "Vivo", "Sony", "Nokia", "Asus Rog"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 114)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "BRAND NAME :"
        '
        'TxtName
        '
        Me.TxtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Name", True))
        Me.TxtName.Location = New System.Drawing.Point(87, 45)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(270, 20)
        Me.TxtName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NUMBER :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NAME :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 21)
        Me.Label2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(161, 530)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(258, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Mobile Repair Management System"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.NumberDataGridViewTextBoxColumn, Me.BrandNameDataGridViewTextBoxColumn, Me.DeviceModelDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(373, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(561, 164)
        Me.DataGridView1.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'NumberDataGridViewTextBoxColumn
        '
        Me.NumberDataGridViewTextBoxColumn.DataPropertyName = "Number"
        Me.NumberDataGridViewTextBoxColumn.HeaderText = "Number"
        Me.NumberDataGridViewTextBoxColumn.Name = "NumberDataGridViewTextBoxColumn"
        '
        'BrandNameDataGridViewTextBoxColumn
        '
        Me.BrandNameDataGridViewTextBoxColumn.DataPropertyName = "Brand Name"
        Me.BrandNameDataGridViewTextBoxColumn.HeaderText = "Brand Name"
        Me.BrandNameDataGridViewTextBoxColumn.Name = "BrandNameDataGridViewTextBoxColumn"
        '
        'DeviceModelDataGridViewTextBoxColumn
        '
        Me.DeviceModelDataGridViewTextBoxColumn.DataPropertyName = "Device Model"
        Me.DeviceModelDataGridViewTextBoxColumn.HeaderText = "Device Model"
        Me.DeviceModelDataGridViewTextBoxColumn.Name = "DeviceModelDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Problem Discription"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Problem Discription"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'CustDetailBindingSource1
        '
        Me.CustDetailBindingSource1.DataMember = "CustDetail"
        Me.CustDetailBindingSource1.DataSource = Me.NewCustomerDataSet
        '
        'NewCustomerDataSet
        '
        Me.NewCustomerDataSet.DataSetName = "NewCustomerDataSet"
        Me.NewCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustDetailBindingSource
        '
        Me.CustDetailBindingSource.DataMember = "CustDetail"
        Me.CustDetailBindingSource.DataSource = Me.NewCustomerDataSet
        '
        'CustDetailTableAdapter
        '
        Me.CustDetailTableAdapter.ClearBeforeFill = True
        '
        'CustDetailBindingSource2
        '
        Me.CustDetailBindingSource2.DataMember = "CustDetail"
        Me.CustDetailBindingSource2.DataSource = Me.NewCustomerDataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(945, 625)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "CustomerDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustDetailBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewCustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustDetailBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NewCustomerDataSet As NewCustomerDataSet
    Friend WithEvents CustDetailBindingSource As BindingSource
    Friend WithEvents CustDetailTableAdapter As NewCustomerDataSetTableAdapters.CustDetailTableAdapter
    Friend WithEvents CustDetailBindingSource1 As BindingSource
    Friend WithEvents CustDetailBindingSource2 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database3DataSet As Database3DataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As Database3DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
