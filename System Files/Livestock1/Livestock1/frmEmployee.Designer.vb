<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.DGEmp = New System.Windows.Forms.DataGridView()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.lblEmpFName = New System.Windows.Forms.Label()
        Me.lblEmpMidInit = New System.Windows.Forms.Label()
        Me.lblEmpLName = New System.Windows.Forms.Label()
        Me.lblEmpGender = New System.Windows.Forms.Label()
        Me.lblEmpBirth = New System.Windows.Forms.Label()
        Me.lblEmpContact = New System.Windows.Forms.Label()
        Me.lblEmpHire = New System.Windows.Forms.Label()
        Me.lblEmpJob = New System.Windows.Forms.Label()
        Me.lblEmpPass = New System.Windows.Forms.Label()
        Me.lblEmpSearch = New System.Windows.Forms.Label()
        Me.btnEmpAdd = New System.Windows.Forms.Button()
        Me.btnEmpUpdate = New System.Windows.Forms.Button()
        Me.btnEmpDelete = New System.Windows.Forms.Button()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.txtEmpFName = New System.Windows.Forms.TextBox()
        Me.txtEmpMidInit = New System.Windows.Forms.TextBox()
        Me.txtEmpSearch = New System.Windows.Forms.TextBox()
        Me.dtpEmpBirth = New System.Windows.Forms.DateTimePicker()
        Me.dtpEmpHire = New System.Windows.Forms.DateTimePicker()
        Me.txtEmpLName = New System.Windows.Forms.TextBox()
        Me.txtEmpContact = New System.Windows.Forms.TextBox()
        Me.txtEmpGender = New System.Windows.Forms.TextBox()
        Me.txtEmpJob = New System.Windows.Forms.TextBox()
        Me.txtEmpPass = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGEmp
        '
        Me.DGEmp.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.DGEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmp.Location = New System.Drawing.Point(349, 12)
        Me.DGEmp.Name = "DGEmp"
        Me.DGEmp.Size = New System.Drawing.Size(622, 414)
        Me.DGEmp.TabIndex = 0
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpID.Location = New System.Drawing.Point(7, 15)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(32, 22)
        Me.lblEmpID.TabIndex = 1
        Me.lblEmpID.Text = "ID"
        '
        'lblEmpFName
        '
        Me.lblEmpFName.AutoSize = True
        Me.lblEmpFName.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpFName.Location = New System.Drawing.Point(6, 45)
        Me.lblEmpFName.Name = "lblEmpFName"
        Me.lblEmpFName.Size = New System.Drawing.Size(119, 22)
        Me.lblEmpFName.TabIndex = 2
        Me.lblEmpFName.Text = "First Name"
        '
        'lblEmpMidInit
        '
        Me.lblEmpMidInit.AutoSize = True
        Me.lblEmpMidInit.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpMidInit.Location = New System.Drawing.Point(6, 75)
        Me.lblEmpMidInit.Name = "lblEmpMidInit"
        Me.lblEmpMidInit.Size = New System.Drawing.Size(147, 22)
        Me.lblEmpMidInit.TabIndex = 3
        Me.lblEmpMidInit.Text = "Middle Initial"
        '
        'lblEmpLName
        '
        Me.lblEmpLName.AutoSize = True
        Me.lblEmpLName.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpLName.Location = New System.Drawing.Point(7, 105)
        Me.lblEmpLName.Name = "lblEmpLName"
        Me.lblEmpLName.Size = New System.Drawing.Size(114, 22)
        Me.lblEmpLName.TabIndex = 4
        Me.lblEmpLName.Text = "Last Name"
        '
        'lblEmpGender
        '
        Me.lblEmpGender.AutoSize = True
        Me.lblEmpGender.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpGender.Location = New System.Drawing.Point(7, 135)
        Me.lblEmpGender.Name = "lblEmpGender"
        Me.lblEmpGender.Size = New System.Drawing.Size(81, 22)
        Me.lblEmpGender.TabIndex = 5
        Me.lblEmpGender.Text = "Gender"
        '
        'lblEmpBirth
        '
        Me.lblEmpBirth.AutoSize = True
        Me.lblEmpBirth.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpBirth.Location = New System.Drawing.Point(8, 255)
        Me.lblEmpBirth.Name = "lblEmpBirth"
        Me.lblEmpBirth.Size = New System.Drawing.Size(103, 22)
        Me.lblEmpBirth.TabIndex = 6
        Me.lblEmpBirth.Text = "Birthdate"
        '
        'lblEmpContact
        '
        Me.lblEmpContact.AutoSize = True
        Me.lblEmpContact.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpContact.Location = New System.Drawing.Point(6, 165)
        Me.lblEmpContact.Name = "lblEmpContact"
        Me.lblEmpContact.Size = New System.Drawing.Size(174, 22)
        Me.lblEmpContact.TabIndex = 7
        Me.lblEmpContact.Text = "Contact Number"
        '
        'lblEmpHire
        '
        Me.lblEmpHire.AutoSize = True
        Me.lblEmpHire.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpHire.Location = New System.Drawing.Point(8, 285)
        Me.lblEmpHire.Name = "lblEmpHire"
        Me.lblEmpHire.Size = New System.Drawing.Size(117, 22)
        Me.lblEmpHire.TabIndex = 8
        Me.lblEmpHire.Text = "Date Hired"
        '
        'lblEmpJob
        '
        Me.lblEmpJob.AutoSize = True
        Me.lblEmpJob.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpJob.Location = New System.Drawing.Point(7, 195)
        Me.lblEmpJob.Name = "lblEmpJob"
        Me.lblEmpJob.Size = New System.Drawing.Size(44, 22)
        Me.lblEmpJob.TabIndex = 9
        Me.lblEmpJob.Text = "Job"
        '
        'lblEmpPass
        '
        Me.lblEmpPass.AutoSize = True
        Me.lblEmpPass.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpPass.Location = New System.Drawing.Point(6, 225)
        Me.lblEmpPass.Name = "lblEmpPass"
        Me.lblEmpPass.Size = New System.Drawing.Size(105, 22)
        Me.lblEmpPass.TabIndex = 10
        Me.lblEmpPass.Text = "Password"
        '
        'lblEmpSearch
        '
        Me.lblEmpSearch.AutoSize = True
        Me.lblEmpSearch.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpSearch.Location = New System.Drawing.Point(6, 336)
        Me.lblEmpSearch.Name = "lblEmpSearch"
        Me.lblEmpSearch.Size = New System.Drawing.Size(76, 22)
        Me.lblEmpSearch.TabIndex = 11
        Me.lblEmpSearch.Text = "Search"
        '
        'btnEmpAdd
        '
        Me.btnEmpAdd.BackColor = System.Drawing.Color.Linen
        Me.btnEmpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpAdd.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpAdd.Location = New System.Drawing.Point(5, 385)
        Me.btnEmpAdd.Name = "btnEmpAdd"
        Me.btnEmpAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnEmpAdd.TabIndex = 12
        Me.btnEmpAdd.Text = "Add"
        Me.btnEmpAdd.UseVisualStyleBackColor = False
        '
        'btnEmpUpdate
        '
        Me.btnEmpUpdate.BackColor = System.Drawing.Color.Linen
        Me.btnEmpUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpUpdate.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpUpdate.Location = New System.Drawing.Point(127, 385)
        Me.btnEmpUpdate.Name = "btnEmpUpdate"
        Me.btnEmpUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnEmpUpdate.TabIndex = 13
        Me.btnEmpUpdate.Text = "Update"
        Me.btnEmpUpdate.UseVisualStyleBackColor = False
        '
        'btnEmpDelete
        '
        Me.btnEmpDelete.BackColor = System.Drawing.Color.Linen
        Me.btnEmpDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpDelete.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpDelete.Location = New System.Drawing.Point(250, 385)
        Me.btnEmpDelete.Name = "btnEmpDelete"
        Me.btnEmpDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnEmpDelete.TabIndex = 14
        Me.btnEmpDelete.Text = "Delete"
        Me.btnEmpDelete.UseVisualStyleBackColor = False
        '
        'txtEmpID
        '
        Me.txtEmpID.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(188, 14)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(137, 23)
        Me.txtEmpID.TabIndex = 1
        '
        'txtEmpFName
        '
        Me.txtEmpFName.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpFName.Location = New System.Drawing.Point(188, 44)
        Me.txtEmpFName.Name = "txtEmpFName"
        Me.txtEmpFName.Size = New System.Drawing.Size(137, 23)
        Me.txtEmpFName.TabIndex = 2
        '
        'txtEmpMidInit
        '
        Me.txtEmpMidInit.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpMidInit.Location = New System.Drawing.Point(188, 74)
        Me.txtEmpMidInit.Name = "txtEmpMidInit"
        Me.txtEmpMidInit.Size = New System.Drawing.Size(137, 23)
        Me.txtEmpMidInit.TabIndex = 3
        '
        'txtEmpSearch
        '
        Me.txtEmpSearch.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpSearch.Location = New System.Drawing.Point(188, 335)
        Me.txtEmpSearch.Name = "txtEmpSearch"
        Me.txtEmpSearch.Size = New System.Drawing.Size(137, 23)
        Me.txtEmpSearch.TabIndex = 11
        '
        'dtpEmpBirth
        '
        Me.dtpEmpBirth.CustomFormat = "yyyy-MM-dd"
        Me.dtpEmpBirth.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEmpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEmpBirth.Location = New System.Drawing.Point(188, 254)
        Me.dtpEmpBirth.Name = "dtpEmpBirth"
        Me.dtpEmpBirth.Size = New System.Drawing.Size(137, 23)
        Me.dtpEmpBirth.TabIndex = 9
        '
        'dtpEmpHire
        '
        Me.dtpEmpHire.CustomFormat = "yyyy-MM-dd"
        Me.dtpEmpHire.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEmpHire.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEmpHire.Location = New System.Drawing.Point(188, 284)
        Me.dtpEmpHire.Name = "dtpEmpHire"
        Me.dtpEmpHire.Size = New System.Drawing.Size(137, 23)
        Me.dtpEmpHire.TabIndex = 10
        '
        'txtEmpLName
        '
        Me.txtEmpLName.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpLName.Location = New System.Drawing.Point(188, 104)
        Me.txtEmpLName.Name = "txtEmpLName"
        Me.txtEmpLName.Size = New System.Drawing.Size(137, 23)
        Me.txtEmpLName.TabIndex = 4
        '
        'txtEmpContact
        '
        Me.txtEmpContact.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpContact.Location = New System.Drawing.Point(188, 164)
        Me.txtEmpContact.Name = "txtEmpContact"
        Me.txtEmpContact.Size = New System.Drawing.Size(137, 23)
        Me.txtEmpContact.TabIndex = 6
        '
        'txtEmpGender
        '
        Me.txtEmpGender.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpGender.Location = New System.Drawing.Point(188, 134)
        Me.txtEmpGender.Name = "txtEmpGender"
        Me.txtEmpGender.Size = New System.Drawing.Size(137, 23)
        Me.txtEmpGender.TabIndex = 5
        '
        'txtEmpJob
        '
        Me.txtEmpJob.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpJob.Location = New System.Drawing.Point(188, 194)
        Me.txtEmpJob.Name = "txtEmpJob"
        Me.txtEmpJob.Size = New System.Drawing.Size(137, 23)
        Me.txtEmpJob.TabIndex = 7
        '
        'txtEmpPass
        '
        Me.txtEmpPass.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpPass.Location = New System.Drawing.Point(188, 224)
        Me.txtEmpPass.Name = "txtEmpPass"
        Me.txtEmpPass.Size = New System.Drawing.Size(137, 23)
        Me.txtEmpPass.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Peru
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblEmpID)
        Me.GroupBox1.Controls.Add(Me.txtEmpSearch)
        Me.GroupBox1.Controls.Add(Me.dtpEmpHire)
        Me.GroupBox1.Controls.Add(Me.txtEmpPass)
        Me.GroupBox1.Controls.Add(Me.dtpEmpBirth)
        Me.GroupBox1.Controls.Add(Me.lblEmpFName)
        Me.GroupBox1.Controls.Add(Me.txtEmpJob)
        Me.GroupBox1.Controls.Add(Me.lblEmpMidInit)
        Me.GroupBox1.Controls.Add(Me.txtEmpContact)
        Me.GroupBox1.Controls.Add(Me.txtEmpGender)
        Me.GroupBox1.Controls.Add(Me.lblEmpLName)
        Me.GroupBox1.Controls.Add(Me.lblEmpGender)
        Me.GroupBox1.Controls.Add(Me.txtEmpLName)
        Me.GroupBox1.Controls.Add(Me.lblEmpContact)
        Me.GroupBox1.Controls.Add(Me.lblEmpJob)
        Me.GroupBox1.Controls.Add(Me.lblEmpPass)
        Me.GroupBox1.Controls.Add(Me.lblEmpBirth)
        Me.GroupBox1.Controls.Add(Me.txtEmpMidInit)
        Me.GroupBox1.Controls.Add(Me.lblEmpHire)
        Me.GroupBox1.Controls.Add(Me.txtEmpFName)
        Me.GroupBox1.Controls.Add(Me.lblEmpSearch)
        Me.GroupBox1.Controls.Add(Me.txtEmpID)
        Me.GroupBox1.Controls.Add(Me.btnEmpAdd)
        Me.GroupBox1.Controls.Add(Me.btnEmpDelete)
        Me.GroupBox1.Controls.Add(Me.btnEmpUpdate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 414)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 12)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID or Last Name"
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(983, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGEmp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomeleigh May Livestock (Admin)"
        CType(Me.DGEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGEmp As System.Windows.Forms.DataGridView
    Friend WithEvents lblEmpID As System.Windows.Forms.Label
    Friend WithEvents lblEmpFName As System.Windows.Forms.Label
    Friend WithEvents lblEmpMidInit As System.Windows.Forms.Label
    Friend WithEvents lblEmpLName As System.Windows.Forms.Label
    Friend WithEvents lblEmpGender As System.Windows.Forms.Label
    Friend WithEvents lblEmpBirth As System.Windows.Forms.Label
    Friend WithEvents lblEmpContact As System.Windows.Forms.Label
    Friend WithEvents lblEmpHire As System.Windows.Forms.Label
    Friend WithEvents lblEmpJob As System.Windows.Forms.Label
    Friend WithEvents lblEmpPass As System.Windows.Forms.Label
    Friend WithEvents lblEmpSearch As System.Windows.Forms.Label
    Friend WithEvents btnEmpAdd As System.Windows.Forms.Button
    Friend WithEvents btnEmpUpdate As System.Windows.Forms.Button
    Friend WithEvents btnEmpDelete As System.Windows.Forms.Button
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpFName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpMidInit As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpSearch As System.Windows.Forms.TextBox
    Friend WithEvents dtpEmpBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEmpHire As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEmpLName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpContact As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpGender As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpJob As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpPass As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
