<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnrefresh4 = New System.Windows.Forms.Button()
        Me.btnSearch4 = New System.Windows.Forms.Button()
        Me.comproid3 = New System.Windows.Forms.ComboBox()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.txtsearch4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAQty = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.btnAdd3 = New System.Windows.Forms.Button()
        Me.btnClear4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(668, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sales and Inventory"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(39, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(39, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Product_ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(578, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sales"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(578, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Available Qty"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack4
        '
        Me.btnBack4.BackgroundImage = CType(resources.GetObject("btnBack4.BackgroundImage"), System.Drawing.Image)
        Me.btnBack4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack4.Location = New System.Drawing.Point(12, 12)
        Me.btnBack4.Name = "btnBack4"
        Me.btnBack4.Size = New System.Drawing.Size(51, 33)
        Me.btnBack4.TabIndex = 13
        Me.btnBack4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnrefresh4)
        Me.Panel1.Controls.Add(Me.btnSearch4)
        Me.Panel1.Controls.Add(Me.comproid3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtp2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtsearch4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAQty)
        Me.Panel1.Controls.Add(Me.txtSale)
        Me.Panel1.Location = New System.Drawing.Point(24, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1565, 176)
        Me.Panel1.TabIndex = 15
        '
        'btnrefresh4
        '
        Me.btnrefresh4.AutoSize = True
        Me.btnrefresh4.BackColor = System.Drawing.Color.White
        Me.btnrefresh4.BackgroundImage = CType(resources.GetObject("btnrefresh4.BackgroundImage"), System.Drawing.Image)
        Me.btnrefresh4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnrefresh4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrefresh4.Location = New System.Drawing.Point(1424, 80)
        Me.btnrefresh4.Name = "btnrefresh4"
        Me.btnrefresh4.Size = New System.Drawing.Size(42, 32)
        Me.btnrefresh4.TabIndex = 24
        Me.btnrefresh4.UseVisualStyleBackColor = False
        '
        'btnSearch4
        '
        Me.btnSearch4.AutoSize = True
        Me.btnSearch4.BackColor = System.Drawing.Color.White
        Me.btnSearch4.BackgroundImage = CType(resources.GetObject("btnSearch4.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch4.Location = New System.Drawing.Point(1424, 35)
        Me.btnSearch4.Name = "btnSearch4"
        Me.btnSearch4.Size = New System.Drawing.Size(42, 32)
        Me.btnSearch4.TabIndex = 23
        Me.btnSearch4.UseVisualStyleBackColor = False
        '
        'comproid3
        '
        Me.comproid3.FormattingEnabled = True
        Me.comproid3.Items.AddRange(New Object() {"001", "002", "003", "004", "005", "006"})
        Me.comproid3.Location = New System.Drawing.Point(200, 90)
        Me.comproid3.Name = "comproid3"
        Me.comproid3.Size = New System.Drawing.Size(297, 28)
        Me.comproid3.TabIndex = 22
        '
        'dtp2
        '
        Me.dtp2.Location = New System.Drawing.Point(200, 34)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(297, 27)
        Me.dtp2.TabIndex = 21
        '
        'txtsearch4
        '
        Me.txtsearch4.Location = New System.Drawing.Point(1201, 34)
        Me.txtsearch4.Name = "txtsearch4"
        Me.txtsearch4.Size = New System.Drawing.Size(205, 27)
        Me.txtsearch4.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(1096, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 28)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Search"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAQty
        '
        Me.txtAQty.Location = New System.Drawing.Point(751, 90)
        Me.txtAQty.Name = "txtAQty"
        Me.txtAQty.Size = New System.Drawing.Size(305, 27)
        Me.txtAQty.TabIndex = 13
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(751, 32)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(305, 27)
        Me.txtSale.TabIndex = 13
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView4.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView4.GridColor = System.Drawing.Color.White
        Me.DataGridView4.Location = New System.Drawing.Point(24, 375)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 29
        Me.DataGridView4.Size = New System.Drawing.Size(1392, 277)
        Me.DataGridView4.TabIndex = 16
        '
        'btnAdd3
        '
        Me.btnAdd3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd3.ForeColor = System.Drawing.Color.White
        Me.btnAdd3.Location = New System.Drawing.Point(1432, 426)
        Me.btnAdd3.Name = "btnAdd3"
        Me.btnAdd3.Size = New System.Drawing.Size(146, 44)
        Me.btnAdd3.TabIndex = 20
        Me.btnAdd3.Text = "Add"
        Me.btnAdd3.UseVisualStyleBackColor = False
        '
        'btnClear4
        '
        Me.btnClear4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear4.ForeColor = System.Drawing.Color.White
        Me.btnClear4.Location = New System.Drawing.Point(1432, 539)
        Me.btnClear4.Name = "btnClear4"
        Me.btnClear4.Size = New System.Drawing.Size(146, 44)
        Me.btnClear4.TabIndex = 21
        Me.btnClear4.Text = "Clear"
        Me.btnClear4.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1601, 677)
        Me.Controls.Add(Me.btnAdd3)
        Me.Controls.Add(Me.btnClear4)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack4)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form6"
        Me.Text = "Sales and Inventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBack4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents comproid3 As ComboBox
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents txtsearch4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAQty As TextBox
    Friend WithEvents txtSale As TextBox
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents btnAdd3 As Button
    Friend WithEvents btnClear4 As Button
    Friend WithEvents btnrefresh4 As Button
    Friend WithEvents btnSearch4 As Button
End Class
