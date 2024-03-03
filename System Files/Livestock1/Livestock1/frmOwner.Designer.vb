<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOwner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOwner))
        Me.DGOwner = New System.Windows.Forms.DataGridView()
        Me.lblOwnerID = New System.Windows.Forms.Label()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.lblOwnerInitials = New System.Windows.Forms.Label()
        Me.lblOwnerContact = New System.Windows.Forms.Label()
        Me.txtOwnerID = New System.Windows.Forms.TextBox()
        Me.txtOwnerName = New System.Windows.Forms.TextBox()
        Me.txtOwnerInitials = New System.Windows.Forms.TextBox()
        Me.txtOwnerContact = New System.Windows.Forms.TextBox()
        Me.lblOwnerSearch = New System.Windows.Forms.Label()
        Me.txtOwnerSearch = New System.Windows.Forms.TextBox()
        Me.btnOwnerAdd = New System.Windows.Forms.Button()
        Me.btnOwnerUpdate = New System.Windows.Forms.Button()
        Me.btnOwnerDelete = New System.Windows.Forms.Button()
        Me.gboxOwner = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxOwner.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGOwner
        '
        Me.DGOwner.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.DGOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGOwner.GridColor = System.Drawing.Color.Peru
        Me.DGOwner.Location = New System.Drawing.Point(395, 6)
        Me.DGOwner.Name = "DGOwner"
        Me.DGOwner.Size = New System.Drawing.Size(440, 239)
        Me.DGOwner.TabIndex = 0
        '
        'lblOwnerID
        '
        Me.lblOwnerID.AutoSize = True
        Me.lblOwnerID.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerID.Location = New System.Drawing.Point(6, 13)
        Me.lblOwnerID.Name = "lblOwnerID"
        Me.lblOwnerID.Size = New System.Drawing.Size(34, 23)
        Me.lblOwnerID.TabIndex = 1
        Me.lblOwnerID.Text = "ID"
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerName.Location = New System.Drawing.Point(7, 47)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(72, 23)
        Me.lblOwnerName.TabIndex = 2
        Me.lblOwnerName.Text = "Name"
        '
        'lblOwnerInitials
        '
        Me.lblOwnerInitials.AutoSize = True
        Me.lblOwnerInitials.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerInitials.Location = New System.Drawing.Point(7, 82)
        Me.lblOwnerInitials.Name = "lblOwnerInitials"
        Me.lblOwnerInitials.Size = New System.Drawing.Size(86, 23)
        Me.lblOwnerInitials.TabIndex = 3
        Me.lblOwnerInitials.Text = "Initials"
        '
        'lblOwnerContact
        '
        Me.lblOwnerContact.AutoSize = True
        Me.lblOwnerContact.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerContact.Location = New System.Drawing.Point(6, 117)
        Me.lblOwnerContact.Name = "lblOwnerContact"
        Me.lblOwnerContact.Size = New System.Drawing.Size(174, 22)
        Me.lblOwnerContact.TabIndex = 4
        Me.lblOwnerContact.Text = "Contact Number"
        '
        'txtOwnerID
        '
        Me.txtOwnerID.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerID.Location = New System.Drawing.Point(188, 14)
        Me.txtOwnerID.Name = "txtOwnerID"
        Me.txtOwnerID.Size = New System.Drawing.Size(175, 23)
        Me.txtOwnerID.TabIndex = 5
        '
        'txtOwnerName
        '
        Me.txtOwnerName.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerName.Location = New System.Drawing.Point(188, 50)
        Me.txtOwnerName.Name = "txtOwnerName"
        Me.txtOwnerName.Size = New System.Drawing.Size(175, 23)
        Me.txtOwnerName.TabIndex = 6
        '
        'txtOwnerInitials
        '
        Me.txtOwnerInitials.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerInitials.Location = New System.Drawing.Point(188, 85)
        Me.txtOwnerInitials.Name = "txtOwnerInitials"
        Me.txtOwnerInitials.Size = New System.Drawing.Size(175, 23)
        Me.txtOwnerInitials.TabIndex = 7
        '
        'txtOwnerContact
        '
        Me.txtOwnerContact.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerContact.Location = New System.Drawing.Point(188, 117)
        Me.txtOwnerContact.Name = "txtOwnerContact"
        Me.txtOwnerContact.Size = New System.Drawing.Size(175, 23)
        Me.txtOwnerContact.TabIndex = 8
        '
        'lblOwnerSearch
        '
        Me.lblOwnerSearch.AutoSize = True
        Me.lblOwnerSearch.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerSearch.Location = New System.Drawing.Point(6, 170)
        Me.lblOwnerSearch.Name = "lblOwnerSearch"
        Me.lblOwnerSearch.Size = New System.Drawing.Size(81, 23)
        Me.lblOwnerSearch.TabIndex = 9
        Me.lblOwnerSearch.Text = "Search"
        '
        'txtOwnerSearch
        '
        Me.txtOwnerSearch.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerSearch.Location = New System.Drawing.Point(188, 171)
        Me.txtOwnerSearch.Name = "txtOwnerSearch"
        Me.txtOwnerSearch.Size = New System.Drawing.Size(175, 23)
        Me.txtOwnerSearch.TabIndex = 10
        '
        'btnOwnerAdd
        '
        Me.btnOwnerAdd.BackColor = System.Drawing.Color.Linen
        Me.btnOwnerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOwnerAdd.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOwnerAdd.Location = New System.Drawing.Point(12, 212)
        Me.btnOwnerAdd.Name = "btnOwnerAdd"
        Me.btnOwnerAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnOwnerAdd.TabIndex = 11
        Me.btnOwnerAdd.Text = "Add"
        Me.btnOwnerAdd.UseVisualStyleBackColor = False
        '
        'btnOwnerUpdate
        '
        Me.btnOwnerUpdate.BackColor = System.Drawing.Color.Linen
        Me.btnOwnerUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOwnerUpdate.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOwnerUpdate.Location = New System.Drawing.Point(151, 212)
        Me.btnOwnerUpdate.Name = "btnOwnerUpdate"
        Me.btnOwnerUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnOwnerUpdate.TabIndex = 12
        Me.btnOwnerUpdate.Text = "Update"
        Me.btnOwnerUpdate.UseVisualStyleBackColor = False
        '
        'btnOwnerDelete
        '
        Me.btnOwnerDelete.BackColor = System.Drawing.Color.Linen
        Me.btnOwnerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOwnerDelete.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOwnerDelete.Location = New System.Drawing.Point(288, 212)
        Me.btnOwnerDelete.Name = "btnOwnerDelete"
        Me.btnOwnerDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnOwnerDelete.TabIndex = 13
        Me.btnOwnerDelete.Text = "Delete"
        Me.btnOwnerDelete.UseVisualStyleBackColor = False
        '
        'gboxOwner
        '
        Me.gboxOwner.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.gboxOwner.BackColor = System.Drawing.Color.Peru
        Me.gboxOwner.Controls.Add(Me.Label1)
        Me.gboxOwner.Controls.Add(Me.lblOwnerID)
        Me.gboxOwner.Controls.Add(Me.btnOwnerDelete)
        Me.gboxOwner.Controls.Add(Me.lblOwnerName)
        Me.gboxOwner.Controls.Add(Me.btnOwnerUpdate)
        Me.gboxOwner.Controls.Add(Me.lblOwnerInitials)
        Me.gboxOwner.Controls.Add(Me.btnOwnerAdd)
        Me.gboxOwner.Controls.Add(Me.lblOwnerContact)
        Me.gboxOwner.Controls.Add(Me.txtOwnerSearch)
        Me.gboxOwner.Controls.Add(Me.txtOwnerID)
        Me.gboxOwner.Controls.Add(Me.lblOwnerSearch)
        Me.gboxOwner.Controls.Add(Me.txtOwnerName)
        Me.gboxOwner.Controls.Add(Me.txtOwnerContact)
        Me.gboxOwner.Controls.Add(Me.txtOwnerInitials)
        Me.gboxOwner.Location = New System.Drawing.Point(3, 6)
        Me.gboxOwner.Name = "gboxOwner"
        Me.gboxOwner.Size = New System.Drawing.Size(386, 239)
        Me.gboxOwner.TabIndex = 14
        Me.gboxOwner.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 12)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Name or Initials"
        '
        'frmOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(835, 251)
        Me.Controls.Add(Me.gboxOwner)
        Me.Controls.Add(Me.DGOwner)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOwner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomeleigh May Livestock (Admin)"
        CType(Me.DGOwner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxOwner.ResumeLayout(False)
        Me.gboxOwner.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGOwner As System.Windows.Forms.DataGridView
    Friend WithEvents lblOwnerID As System.Windows.Forms.Label
    Friend WithEvents lblOwnerName As System.Windows.Forms.Label
    Friend WithEvents lblOwnerInitials As System.Windows.Forms.Label
    Friend WithEvents lblOwnerContact As System.Windows.Forms.Label
    Friend WithEvents txtOwnerID As System.Windows.Forms.TextBox
    Friend WithEvents txtOwnerName As System.Windows.Forms.TextBox
    Friend WithEvents txtOwnerInitials As System.Windows.Forms.TextBox
    Friend WithEvents txtOwnerContact As System.Windows.Forms.TextBox
    Friend WithEvents lblOwnerSearch As System.Windows.Forms.Label
    Friend WithEvents txtOwnerSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnOwnerAdd As System.Windows.Forms.Button
    Friend WithEvents btnOwnerUpdate As System.Windows.Forms.Button
    Friend WithEvents btnOwnerDelete As System.Windows.Forms.Button
    Friend WithEvents gboxOwner As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
