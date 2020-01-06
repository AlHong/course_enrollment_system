<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoursesUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgressColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EligCreditsColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditsEarnedColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumberColumn, Me.NameColumn, Me.TypeColumn, Me.ProgressColumn, Me.EligCreditsColumn, Me.CreditsEarnedColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(-41, -3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(726, 124)
        Me.DataGridView1.TabIndex = 0
        '
        'NumberColumn
        '
        Me.NumberColumn.HeaderText = "Number"
        Me.NumberColumn.Name = "NumberColumn"
        '
        'NameColumn
        '
        Me.NameColumn.HeaderText = "Name"
        Me.NameColumn.Name = "NameColumn"
        '
        'TypeColumn
        '
        Me.TypeColumn.HeaderText = "Type"
        Me.TypeColumn.Name = "TypeColumn"
        '
        'ProgressColumn
        '
        Me.ProgressColumn.HeaderText = "Progress"
        Me.ProgressColumn.Name = "ProgressColumn"
        Me.ProgressColumn.Width = 150
        '
        'EligCreditsColumn
        '
        Me.EligCreditsColumn.HeaderText = "Eligible Credits"
        Me.EligCreditsColumn.Name = "EligCreditsColumn"
        '
        'CreditsEarnedColumn
        '
        Me.CreditsEarnedColumn.HeaderText = "Credits Earned"
        Me.CreditsEarnedColumn.Name = "CreditsEarnedColumn"
        '
        'CoursesUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CoursesUserControl"
        Me.Size = New System.Drawing.Size(685, 121)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumberColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgressColumn As DataGridViewTextBoxColumn
    Friend WithEvents EligCreditsColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreditsEarnedColumn As DataGridViewTextBoxColumn
End Class
