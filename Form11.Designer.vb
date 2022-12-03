<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBack3 = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnrefresh5 = New System.Windows.Forms.Button()
        Me.btnSearch5 = New System.Windows.Forms.Button()
        Me.txtsearch5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnBack3.TabIndex = 13
        Me.btnBack3.UseVisualStyleBackColor = True
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
        Me.DataGridView4.Location = New System.Drawing.Point(125, 184)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 29
        Me.DataGridView4.Size = New System.Drawing.Size(1355, 461)
        Me.DataGridView4.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(726, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 37)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Production"
        '
        'btnrefresh5
        '
        Me.btnrefresh5.AutoSize = True
        Me.btnrefresh5.BackColor = System.Drawing.Color.White
        Me.btnrefresh5.BackgroundImage = CType(resources.GetObject("btnrefresh5.BackgroundImage"), System.Drawing.Image)
        Me.btnrefresh5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnrefresh5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrefresh5.Location = New System.Drawing.Point(1510, 121)
        Me.btnrefresh5.Name = "btnrefresh5"
        Me.btnrefresh5.Size = New System.Drawing.Size(37, 29)
        Me.btnrefresh5.TabIndex = 28
        Me.btnrefresh5.UseVisualStyleBackColor = False
        '
        'btnSearch5
        '
        Me.btnSearch5.AutoSize = True
        Me.btnSearch5.BackColor = System.Drawing.Color.White
        Me.btnSearch5.BackgroundImage = CType(resources.GetObject("btnSearch5.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch5.Location = New System.Drawing.Point(1453, 122)
        Me.btnSearch5.Name = "btnSearch5"
        Me.btnSearch5.Size = New System.Drawing.Size(39, 27)
        Me.btnSearch5.TabIndex = 27
        Me.btnSearch5.UseVisualStyleBackColor = False
        '
        'txtsearch5
        '
        Me.txtsearch5.Location = New System.Drawing.Point(1221, 122)
        Me.txtsearch5.Name = "txtsearch5"
        Me.txtsearch5.Size = New System.Drawing.Size(205, 27)
        Me.txtsearch5.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(1126, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 28)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Search"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1601, 677)
        Me.Controls.Add(Me.btnrefresh5)
        Me.Controls.Add(Me.btnSearch5)
        Me.Controls.Add(Me.txtsearch5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.btnBack3)
        Me.DoubleBuffered = True
        Me.Name = "Form11"
        Me.Text = "Production"
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack3 As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnrefresh5 As Button
    Friend WithEvents btnSearch5 As Button
    Friend WithEvents txtsearch5 As TextBox
    Friend WithEvents Label9 As Label
End Class
