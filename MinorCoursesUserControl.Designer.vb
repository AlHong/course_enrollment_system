<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinorCoursesUserControl
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgressColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EligibleCreditsColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditsEarnedColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReqInMajorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumberColumn, Me.NameColumn, Me.ProgressColumn, Me.EligibleCreditsColumn, Me.CreditsEarnedColumn, Me.ReqInMajorColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(0, -1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(654, 106)
        Me.DataGridView1.TabIndex = 0
        '
        'NumberColumn
        '
        Me.NumberColumn.HeaderText = "Number"
        Me.NumberColumn.Name = "NumberColumn"
        Me.NumberColumn.ReadOnly = True
        '
        'NameColumn
        '
        Me.NameColumn.HeaderText = "Name"
        Me.NameColumn.Name = "NameColumn"
        Me.NameColumn.ReadOnly = True
        '
        'ProgressColumn
        '
        Me.ProgressColumn.HeaderText = "Progress"
        Me.ProgressColumn.Name = "ProgressColumn"
        Me.ProgressColumn.ReadOnly = True
        '
        'EligibleCreditsColumn
        '
        Me.EligibleCreditsColumn.HeaderText = "Eligible Credits"
        Me.EligibleCreditsColumn.Name = "EligibleCreditsColumn"
        Me.EligibleCreditsColumn.ReadOnly = True
        '
        'CreditsEarnedColumn
        '
        Me.CreditsEarnedColumn.HeaderText = "Credits Earned"
        Me.CreditsEarnedColumn.Name = "CreditsEarnedColumn"
        Me.CreditsEarnedColumn.ReadOnly = True
        '
        'ReqInMajorColumn
        '
        Me.ReqInMajorColumn.HeaderText = "In your major & counts towards minor"
        Me.ReqInMajorColumn.Name = "ReqInMajorColumn"
        Me.ReqInMajorColumn.ReadOnly = True
        '
        'MinorCoursesUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MinorCoursesUserControl"
        Me.Size = New System.Drawing.Size(673, 127)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumberColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgressColumn As DataGridViewTextBoxColumn
    Friend WithEvents EligibleCreditsColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreditsEarnedColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReqInMajorColumn As DataGridViewTextBoxColumn
End Class
