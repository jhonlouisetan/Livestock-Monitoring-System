<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.btnCow = New System.Windows.Forms.Button()
        Me.btnListOut = New System.Windows.Forms.Button()
        Me.btnOwner = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCow
        '
        Me.btnCow.BackColor = System.Drawing.Color.Linen
        Me.btnCow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCow.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCow.Location = New System.Drawing.Point(118, 27)
        Me.btnCow.Name = "btnCow"
        Me.btnCow.Size = New System.Drawing.Size(202, 36)
        Me.btnCow.TabIndex = 0
        Me.btnCow.Text = "Cow"
        Me.btnCow.UseVisualStyleBackColor = False
        '
        'btnListOut
        '
        Me.btnListOut.BackColor = System.Drawing.Color.Linen
        Me.btnListOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListOut.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListOut.Location = New System.Drawing.Point(118, 69)
        Me.btnListOut.Name = "btnListOut"
        Me.btnListOut.Size = New System.Drawing.Size(202, 36)
        Me.btnListOut.TabIndex = 1
        Me.btnListOut.Text = "List of Out"
        Me.btnListOut.UseVisualStyleBackColor = False
        '
        'btnOwner
        '
        Me.btnOwner.BackColor = System.Drawing.Color.Linen
        Me.btnOwner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOwner.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOwner.Location = New System.Drawing.Point(118, 111)
        Me.btnOwner.Name = "btnOwner"
        Me.btnOwner.Size = New System.Drawing.Size(202, 36)
        Me.btnOwner.TabIndex = 2
        Me.btnOwner.Text = "Owner"
        Me.btnOwner.UseVisualStyleBackColor = False
        '
        'btnEmployee
        '
        Me.btnEmployee.BackColor = System.Drawing.Color.Linen
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmployee.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.Location = New System.Drawing.Point(118, 153)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(202, 36)
        Me.btnEmployee.TabIndex = 3
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Linen
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerate.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(118, 195)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(202, 36)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Linen
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(171, 237)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 36)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(429, 291)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnOwner)
        Me.Controls.Add(Me.btnListOut)
        Me.Controls.Add(Me.btnCow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomeleigh May Livestock (Admin)"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCow As System.Windows.Forms.Button
    Friend WithEvents btnListOut As System.Windows.Forms.Button
    Friend WithEvents btnOwner As System.Windows.Forms.Button
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
