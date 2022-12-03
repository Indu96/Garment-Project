<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnDailyPro = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(405, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME !"
        '
        'btnEmployees
        '
        Me.btnEmployees.AutoSize = True
        Me.btnEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmployees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEmployees.ForeColor = System.Drawing.Color.White
        Me.btnEmployees.Location = New System.Drawing.Point(134, 205)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(217, 53)
        Me.btnEmployees.TabIndex = 1
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.UseVisualStyleBackColor = False
        '
        'btnProducts
        '
        Me.btnProducts.AutoSize = True
        Me.btnProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProducts.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProducts.ForeColor = System.Drawing.Color.White
        Me.btnProducts.Location = New System.Drawing.Point(666, 205)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(217, 53)
        Me.btnProducts.TabIndex = 1
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = False
        '
        'btnDailyPro
        '
        Me.btnDailyPro.AutoSize = True
        Me.btnDailyPro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDailyPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDailyPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDailyPro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDailyPro.ForeColor = System.Drawing.Color.White
        Me.btnDailyPro.Location = New System.Drawing.Point(54, 362)
        Me.btnDailyPro.Name = "btnDailyPro"
        Me.btnDailyPro.Size = New System.Drawing.Size(373, 53)
        Me.btnDailyPro.TabIndex = 1
        Me.btnDailyPro.Text = "Daily Production and Salary"
        Me.btnDailyPro.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.AutoSize = True
        Me.btnSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Location = New System.Drawing.Point(589, 362)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(373, 53)
        Me.btnSales.TabIndex = 2
        Me.btnSales.Text = "Sales and Inventory"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1033, 507)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnDailyPro)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.btnEmployees)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnDailyPro As Button
    Friend WithEvents btnSales As Button
End Class
