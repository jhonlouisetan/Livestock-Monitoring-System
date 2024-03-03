<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBook))
        Me.DGCow = New System.Windows.Forms.DataGridView()
        Me.gboxCow = New System.Windows.Forms.GroupBox()
        Me.txtOwner = New System.Windows.Forms.TextBox()
        Me.cboxInventoryStatus = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cboxAgeGroup = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboxGender = New System.Windows.Forms.ComboBox()
        Me.txtCowID = New System.Windows.Forms.TextBox()
        Me.dtpOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpRecorded = New System.Windows.Forms.DateTimePicker()
        Me.dtpInventory = New System.Windows.Forms.DateTimePicker()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.lblRecorded = New System.Windows.Forms.Label()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAgeGroup = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.lblCowID = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.DGCow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxCow.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGCow
        '
        Me.DGCow.AllowUserToAddRows = False
        Me.DGCow.AllowUserToDeleteRows = False
        Me.DGCow.AllowUserToResizeColumns = False
        Me.DGCow.AllowUserToResizeRows = False
        Me.DGCow.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.DGCow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCow.GridColor = System.Drawing.Color.Peru
        Me.DGCow.Location = New System.Drawing.Point(312, 12)
        Me.DGCow.Name = "DGCow"
        Me.DGCow.ReadOnly = True
        Me.DGCow.Size = New System.Drawing.Size(845, 556)
        Me.DGCow.TabIndex = 1
        '
        'gboxCow
        '
        Me.gboxCow.BackColor = System.Drawing.Color.Peru
        Me.gboxCow.Controls.Add(Me.txtOwner)
        Me.gboxCow.Controls.Add(Me.cboxInventoryStatus)
        Me.gboxCow.Controls.Add(Me.label1)
        Me.gboxCow.Controls.Add(Me.cboxAgeGroup)
        Me.gboxCow.Controls.Add(Me.txtSearch)
        Me.gboxCow.Controls.Add(Me.cboxGender)
        Me.gboxCow.Controls.Add(Me.txtCowID)
        Me.gboxCow.Controls.Add(Me.dtpOut)
        Me.gboxCow.Controls.Add(Me.dtpRecorded)
        Me.gboxCow.Controls.Add(Me.dtpInventory)
        Me.gboxCow.Controls.Add(Me.btnDelete)
        Me.gboxCow.Controls.Add(Me.btnUpdate)
        Me.gboxCow.Controls.Add(Me.btnAdd)
        Me.gboxCow.Controls.Add(Me.lblSearch)
        Me.gboxCow.Controls.Add(Me.lblOut)
        Me.gboxCow.Controls.Add(Me.lblRecorded)
        Me.gboxCow.Controls.Add(Me.lblInventory)
        Me.gboxCow.Controls.Add(Me.lblStatus)
        Me.gboxCow.Controls.Add(Me.lblAgeGroup)
        Me.gboxCow.Controls.Add(Me.lblGender)
        Me.gboxCow.Controls.Add(Me.lblOwner)
        Me.gboxCow.Controls.Add(Me.lblCowID)
        Me.gboxCow.Location = New System.Drawing.Point(12, 12)
        Me.gboxCow.Name = "gboxCow"
        Me.gboxCow.Size = New System.Drawing.Size(296, 556)
        Me.gboxCow.TabIndex = 2
        Me.gboxCow.TabStop = False
        '
        'txtOwner
        '
        Me.txtOwner.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwner.Location = New System.Drawing.Point(129, 48)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.Size = New System.Drawing.Size(149, 23)
        Me.txtOwner.TabIndex = 2
        '
        'cboxInventoryStatus
        '
        Me.cboxInventoryStatus.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxInventoryStatus.FormattingEnabled = True
        Me.cboxInventoryStatus.Location = New System.Drawing.Point(129, 154)
        Me.cboxInventoryStatus.Name = "cboxInventoryStatus"
        Me.cboxInventoryStatus.Size = New System.Drawing.Size(149, 23)
        Me.cboxInventoryStatus.TabIndex = 15
        Me.cboxInventoryStatus.Text = "Select Inventory Status"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(103, 434)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(155, 12)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Cow ID or Owner Initials"
        '
        'cboxAgeGroup
        '
        Me.cboxAgeGroup.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxAgeGroup.FormattingEnabled = True
        Me.cboxAgeGroup.Location = New System.Drawing.Point(129, 120)
        Me.cboxAgeGroup.Name = "cboxAgeGroup"
        Me.cboxAgeGroup.Size = New System.Drawing.Size(149, 23)
        Me.cboxAgeGroup.TabIndex = 14
        Me.cboxAgeGroup.Text = "Select Age Group"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(88, 449)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(191, 23)
        Me.txtSearch.TabIndex = 9
        '
        'cboxGender
        '
        Me.cboxGender.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxGender.FormattingEnabled = True
        Me.cboxGender.Location = New System.Drawing.Point(129, 83)
        Me.cboxGender.Name = "cboxGender"
        Me.cboxGender.Size = New System.Drawing.Size(149, 23)
        Me.cboxGender.TabIndex = 13
        Me.cboxGender.Text = "Select Gender"
        '
        'txtCowID
        '
        Me.txtCowID.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCowID.Location = New System.Drawing.Point(129, 16)
        Me.txtCowID.Name = "txtCowID"
        Me.txtCowID.Size = New System.Drawing.Size(149, 23)
        Me.txtCowID.TabIndex = 1
        '
        'dtpOut
        '
        Me.dtpOut.CustomFormat = "yyyy-MM-dd"
        Me.dtpOut.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOut.Location = New System.Drawing.Point(11, 355)
        Me.dtpOut.Name = "dtpOut"
        Me.dtpOut.Size = New System.Drawing.Size(200, 23)
        Me.dtpOut.TabIndex = 8
        Me.dtpOut.Tag = ""
        Me.dtpOut.Value = New Date(2023, 4, 19, 21, 52, 19, 0)
        '
        'dtpRecorded
        '
        Me.dtpRecorded.CustomFormat = "yyyy-MM-dd"
        Me.dtpRecorded.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRecorded.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRecorded.Location = New System.Drawing.Point(11, 289)
        Me.dtpRecorded.Name = "dtpRecorded"
        Me.dtpRecorded.Size = New System.Drawing.Size(200, 23)
        Me.dtpRecorded.TabIndex = 7
        Me.dtpRecorded.Tag = ""
        '
        'dtpInventory
        '
        Me.dtpInventory.CustomFormat = "yyyy-MM-dd"
        Me.dtpInventory.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInventory.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInventory.Location = New System.Drawing.Point(11, 222)
        Me.dtpInventory.Name = "dtpInventory"
        Me.dtpInventory.Size = New System.Drawing.Size(200, 23)
        Me.dtpInventory.TabIndex = 6
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Linen
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(204, 527)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Linen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(105, 527)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Linen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(6, 527)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(6, 450)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(76, 22)
        Me.lblSearch.TabIndex = 11
        Me.lblSearch.Text = "Search"
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOut.Location = New System.Drawing.Point(6, 330)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(47, 22)
        Me.lblOut.TabIndex = 10
        Me.lblOut.Text = "Out"
        '
        'lblRecorded
        '
        Me.lblRecorded.AutoSize = True
        Me.lblRecorded.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecorded.Location = New System.Drawing.Point(7, 264)
        Me.lblRecorded.Name = "lblRecorded"
        Me.lblRecorded.Size = New System.Drawing.Size(103, 22)
        Me.lblRecorded.TabIndex = 9
        Me.lblRecorded.Text = "Recorded"
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventory.Location = New System.Drawing.Point(6, 197)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(185, 22)
        Me.lblInventory.TabIndex = 8
        Me.lblInventory.Text = "Date of Inventory"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(6, 155)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(72, 22)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status"
        '
        'lblAgeGroup
        '
        Me.lblAgeGroup.AutoSize = True
        Me.lblAgeGroup.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeGroup.Location = New System.Drawing.Point(6, 121)
        Me.lblAgeGroup.Name = "lblAgeGroup"
        Me.lblAgeGroup.Size = New System.Drawing.Size(115, 22)
        Me.lblAgeGroup.TabIndex = 6
        Me.lblAgeGroup.Text = "Age Group"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(6, 84)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(81, 22)
        Me.lblGender.TabIndex = 5
        Me.lblGender.Text = "Gender"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwner.Location = New System.Drawing.Point(6, 49)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(75, 22)
        Me.lblOwner.TabIndex = 4
        Me.lblOwner.Text = "Owner"
        '
        'lblCowID
        '
        Me.lblCowID.AutoSize = True
        Me.lblCowID.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCowID.Location = New System.Drawing.Point(6, 17)
        Me.lblCowID.Name = "lblCowID"
        Me.lblCowID.Size = New System.Drawing.Size(81, 22)
        Me.lblCowID.TabIndex = 3
        Me.lblCowID.Text = "Cow ID"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Linen
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1076, 574)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1163, 603)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.gboxCow)
        Me.Controls.Add(Me.DGCow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomeleigh May Livestock (Bookkeeper)"
        CType(Me.DGCow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxCow.ResumeLayout(False)
        Me.gboxCow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGCow As System.Windows.Forms.DataGridView
    Friend WithEvents gboxCow As System.Windows.Forms.GroupBox
    Friend WithEvents dtpOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRecorded As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInventory As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblOut As System.Windows.Forms.Label
    Friend WithEvents lblRecorded As System.Windows.Forms.Label
    Friend WithEvents lblInventory As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblAgeGroup As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblCowID As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtCowID As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cboxInventoryStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboxAgeGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cboxGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtOwner As System.Windows.Forms.TextBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
