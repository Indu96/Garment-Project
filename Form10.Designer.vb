<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.btndbconnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btndbconnect
        '
        Me.btndbconnect.Location = New System.Drawing.Point(402, 122)
        Me.btndbconnect.Name = "btndbconnect"
        Me.btndbconnect.Size = New System.Drawing.Size(94, 29)
        Me.btndbconnect.TabIndex = 0
        Me.btndbconnect.Text = "Connect"
        Me.btndbconnect.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btndbconnect)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btndbconnect As Button
End Class
