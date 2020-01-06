<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class schedule
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Monday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tuesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wednesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thursday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Friday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Monday, Me.Column1, Me.Tuesday, Me.Wednesday, Me.Thursday, Me.Friday})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 305)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1190, 410)
        Me.DataGridView1.TabIndex = 16
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.White
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 220)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 32)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "RAMSS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1038, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 33)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Change Term"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Monday
        '
        Me.Monday.HeaderText = ""
        Me.Monday.Name = "Monday"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Monday"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Tuesday
        '
        Me.Tuesday.HeaderText = "Tuesday"
        Me.Tuesday.Name = "Tuesday"
        Me.Tuesday.Width = 150
        '
        'Wednesday
        '
        Me.Wednesday.HeaderText = "Wednesday"
        Me.Wednesday.Name = "Wednesday"
        Me.Wednesday.Width = 150
        '
        'Thursday
        '
        Me.Thursday.HeaderText = "Thursday"
        Me.Thursday.Name = "Thursday"
        Me.Thursday.Width = 150
        '
        'Friday
        '
        Me.Friday.HeaderText = "Friday"
        Me.Friday.Name = "Friday"
        Me.Friday.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Label1"
        '
        'schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.A3orLedgersizeBrowserWindow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 977)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "schedule"
        Me.Text = "schedule"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Monday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tuesday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Wednesday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thursday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Friday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
