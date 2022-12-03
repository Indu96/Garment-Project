<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnrefresh3 = New System.Windows.Forms.Button()
        Me.btnSearch3 = New System.Windows.Forms.Button()
        Me.Dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.comproid2 = New System.Windows.Forms.ComboBox()
        Me.txtSearch3 = New System.Windows.Forms.TextBox()
        Me.txtQty2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAQty3 = New System.Windows.Forms.TextBox()
        Me.txtLabCost = New System.Windows.Forms.TextBox()
        Me.txtempid2 = New System.Windows.Forms.TextBox()
        Me.txtSA = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdt3 = New System.Windows.Forms.Button()
        Me.btnClear3 = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnShow = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(659, -84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Daily Production and Salary"
        '
        'btnBack3
        '
        Me.btnBack3.BackgroundImage = CType(resources.GetObject("btnBack3.BackgroundImage"), System.Drawing.Image)
        Me.btnBack3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack3.Location = New System.Drawing.Point(12, 12)
        Me.btnBack3.Name = "btnBack3"
        Me.btnBack3.Size = New System.Drawing.Size(51, 33)
        Me.btnBack3.TabIndex = 12
        Me.btnBack3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(539, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Salary Amount"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(539, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(37, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Product_ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(37, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Emp_ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnrefresh3)
        Me.Panel1.Controls.Add(Me.btnSearch3)
        Me.Panel1.Controls.Add(Me.Dtp1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.comproid2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtSearch3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtQty2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAQty3)
        Me.Panel1.Controls.Add(Me.txtLabCost)
        Me.Panel1.Controls.Add(Me.txtempid2)
        Me.Panel1.Controls.Add(Me.txtSA)
        Me.Panel1.Location = New System.Drawing.Point(25, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1547, 210)
        Me.Panel1.TabIndex = 14
        '
        'btnrefresh3
        '
        Me.btnrefresh3.AutoSize = True
        Me.btnrefresh3.BackColor = System.Drawing.Color.White
        Me.btnrefresh3.BackgroundImage = CType(resources.GetObject("btnrefresh3.BackgroundImage"), System.Drawing.Image)
        Me.btnrefresh3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnrefresh3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrefresh3.Location = New System.Drawing.Point(1458, 131)
        Me.btnrefresh3.Name = "btnrefresh3"
        Me.btnrefresh3.Size = New System.Drawing.Size(42, 32)
        Me.btnrefresh3.TabIndex = 18
        Me.btnrefresh3.UseVisualStyleBackColor = False
        '
        'btnSearch3
        '
        Me.btnSearch3.AutoSize = True
        Me.btnSearch3.BackColor = System.Drawing.Color.White
        Me.btnSearch3.BackgroundImage = CType(resources.GetObject("btnSearch3.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch3.Location = New System.Drawing.Point(1458, 86)
        Me.btnSearch3.Name = "btnSearch3"
        Me.btnSearch3.Size = New System.Drawing.Size(42, 32)
        Me.btnSearch3.TabIndex = 17
        Me.btnSearch3.UseVisualStyleBackColor = False
        '
        'Dtp1
        '
        Me.Dtp1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Dtp1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.Dtp1.Location = New System.Drawing.Point(183, 26)
        Me.Dtp1.Name = "Dtp1"
        Me.Dtp1.Size = New System.Drawing.Size(273, 27)
        Me.Dtp1.TabIndex = 16
        '
        'comproid2
        '
        Me.comproid2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comproid2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.comproid2.BackColor = System.Drawing.Color.White
        Me.comproid2.FormattingEnabled = True
        Me.comproid2.Items.AddRange(New Object() {"001", "002", "003", "004", "005"})
        Me.comproid2.Location = New System.Drawing.Point(183, 140)
        Me.comproid2.Name = "comproid2"
        Me.comproid2.Size = New System.Drawing.Size(273, 28)
        Me.comproid2.TabIndex = 14
        '
        'txtSearch3
        '
        Me.txtSearch3.Location = New System.Drawing.Point(1220, 86)
        Me.txtSearch3.Name = "txtSearch3"
        Me.txtSearch3.Size = New System.Drawing.Size(232, 27)
        Me.txtSearch3.TabIndex = 13
        '
        'txtQty2
        '
        Me.txtQty2.Location = New System.Drawing.Point(732, 86)
        Me.txtQty2.Name = "txtQty2"
        Me.txtQty2.Size = New System.Drawing.Size(336, 27)
        Me.txtQty2.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(1122, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 28)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Total Qty"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(539, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Laborer Cost"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(1122, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 28)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Search"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAQty3
        '
        Me.txtAQty3.Location = New System.Drawing.Point(1220, 26)
        Me.txtAQty3.Name = "txtAQty3"
        Me.txtAQty3.Size = New System.Drawing.Size(280, 27)
        Me.txtAQty3.TabIndex = 13
        '
        'txtLabCost
        '
        Me.txtLabCost.Location = New System.Drawing.Point(732, 27)
        Me.txtLabCost.Name = "txtLabCost"
        Me.txtLabCost.Size = New System.Drawing.Size(336, 27)
        Me.txtLabCost.TabIndex = 13
        '
        'txtempid2
        '
        Me.txtempid2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtempid2.Location = New System.Drawing.Point(183, 82)
        Me.txtempid2.Name = "txtempid2"
        Me.txtempid2.Size = New System.Drawing.Size(273, 27)
        Me.txtempid2.TabIndex = 13
        '
        'txtSA
        '
        Me.txtSA.Location = New System.Drawing.Point(732, 141)
        Me.txtSA.Name = "txtSA"
        Me.txtSA.Size = New System.Drawing.Size(336, 27)
        Me.txtSA.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1420, 374)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 36)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdt3
        '
        Me.btnUpdt3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdt3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdt3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdt3.ForeColor = System.Drawing.Color.White
        Me.btnUpdt3.Location = New System.Drawing.Point(1420, 457)
        Me.btnUpdt3.Name = "btnUpdt3"
        Me.btnUpdt3.Size = New System.Drawing.Size(152, 36)
        Me.btnUpdt3.TabIndex = 21
        Me.btnUpdt3.Text = "Update"
        Me.btnUpdt3.UseVisualStyleBackColor = False
        '
        'btnClear3
        '
        Me.btnClear3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear3.ForeColor = System.Drawing.Color.White
        Me.btnClear3.Location = New System.Drawing.Point(1417, 613)
        Me.btnClear3.Name = "btnClear3"
        Me.btnClear3.Size = New System.Drawing.Size(152, 36)
        Me.btnClear3.TabIndex = 23
        Me.btnClear3.Text = "Clear"
        Me.btnClear3.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DataGridView3.GridColor = System.Drawing.Color.White
        Me.DataGridView3.Location = New System.Drawing.Point(25, 374)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 29
        Me.DataGridView3.Size = New System.Drawing.Size(1386, 275)
        Me.DataGridView3.TabIndex = 24
        '
        'Column1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Date"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Emp_ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Product_ID"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.HeaderText = "Laborer Cost"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column5.HeaderText = "Quantity"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column6.HeaderText = "Salary Amount"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(672, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(404, 37)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Daily Production and Salary"
        '
        'BindingSource1
        '
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShow.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(1420, 532)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(152, 36)
        Me.btnShow.TabIndex = 26
        Me.btnShow.Text = "Show All"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1601, 677)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdt3)
        Me.Controls.Add(Me.btnClear3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack3)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form5"
        Me.Text = "Daily Production and Salary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dtp1 As DateTimePicker
    Friend WithEvents comproid2 As ComboBox
    Friend WithEvents txtSearch3 As TextBox
    Friend WithEvents txtQty2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtempid2 As TextBox
    Friend WithEvents txtSA As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdt3 As Button
    Friend WithEvents btnClear3 As Button
    Public WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLabCost As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnrefresh3 As Button
    Friend WithEvents btnSearch3 As Button
    Friend WithEvents txtalt As TextBox
    Friend WithEvents btnShow As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAQty3 As TextBox
End Class
