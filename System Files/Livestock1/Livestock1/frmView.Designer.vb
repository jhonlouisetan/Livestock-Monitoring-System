<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmView))
        Me.DGViewCow = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblViewSearch = New System.Windows.Forms.Label()
        Me.txtViewSearch = New System.Windows.Forms.TextBox()
        CType(Me.DGViewCow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGViewCow
        '
        Me.DGViewCow.AllowUserToAddRows = False
        Me.DGViewCow.AllowUserToDeleteRows = False
        Me.DGViewCow.AllowUserToResizeColumns = False
        Me.DGViewCow.AllowUserToResizeRows = False
        Me.DGViewCow.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.DGViewCow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewCow.GridColor = System.Drawing.Color.Peru
        Me.DGViewCow.Location = New System.Drawing.Point(2, 1)
        Me.DGViewCow.Name = "DGViewCow"
        Me.DGViewCow.ReadOnly = True
        Me.DGViewCow.Size = New System.Drawing.Size(843, 379)
        Me.DGViewCow.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Linen
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(758, 386)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblViewSearch
        '
        Me.lblViewSearch.AutoSize = True
        Me.lblViewSearch.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewSearch.Location = New System.Drawing.Point(30, 389)
        Me.lblViewSearch.Name = "lblViewSearch"
        Me.lblViewSearch.Size = New System.Drawing.Size(208, 18)
        Me.lblViewSearch.TabIndex = 2
        Me.lblViewSearch.Text = "Search Cow ID or Initials"
        '
        'txtViewSearch
        '
        Me.txtViewSearch.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViewSearch.Location = New System.Drawing.Point(244, 383)
        Me.txtViewSearch.Name = "txtViewSearch"
        Me.txtViewSearch.Size = New System.Drawing.Size(100, 26)
        Me.txtViewSearch.TabIndex = 3
        '
        'frmView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(845, 413)
        Me.Controls.Add(Me.txtViewSearch)
        Me.Controls.Add(Me.lblViewSearch)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.DGViewCow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomeleigh May Livestock (View Only)"
        CType(Me.DGViewCow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGViewCow As System.Windows.Forms.DataGridView
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblViewSearch As System.Windows.Forms.Label
    Friend WithEvents txtViewSearch As System.Windows.Forms.TextBox
End Class
