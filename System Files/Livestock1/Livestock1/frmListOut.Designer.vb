<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListOut))
        Me.DGCow = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOutSearch = New System.Windows.Forms.TextBox()
        Me.btnOutLogout = New System.Windows.Forms.Button()
        CType(Me.DGCow, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DGCow.Location = New System.Drawing.Point(1, 4)
        Me.DGCow.Name = "DGCow"
        Me.DGCow.ReadOnly = True
        Me.DGCow.Size = New System.Drawing.Size(843, 379)
        Me.DGCow.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Cow ID or Initials"
        '
        'txtOutSearch
        '
        Me.txtOutSearch.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutSearch.Location = New System.Drawing.Point(247, 384)
        Me.txtOutSearch.Name = "txtOutSearch"
        Me.txtOutSearch.Size = New System.Drawing.Size(100, 26)
        Me.txtOutSearch.TabIndex = 4
        '
        'btnOutLogout
        '
        Me.btnOutLogout.BackColor = System.Drawing.Color.Linen
        Me.btnOutLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOutLogout.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOutLogout.Location = New System.Drawing.Point(758, 387)
        Me.btnOutLogout.Name = "btnOutLogout"
        Me.btnOutLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnOutLogout.TabIndex = 5
        Me.btnOutLogout.Text = "Logout"
        Me.btnOutLogout.UseVisualStyleBackColor = False
        '
        'frmListOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(845, 413)
        Me.Controls.Add(Me.btnOutLogout)
        Me.Controls.Add(Me.txtOutSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGCow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomeleigh May Livestock (Admin)"
        CType(Me.DGCow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGCow As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOutSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnOutLogout As System.Windows.Forms.Button
End Class
