<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseFiles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChooseFiles))
        Me.Button2 = New System.Windows.Forms.Button()
        Me._cmbDataProvider = New System.Windows.Forms.ComboBox()
        Me.treeViewFolderBrowser1 = New Raccoom.Windows.Forms.TreeViewFolderBrowser()
        Me.LblTextSource = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(992, 11)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 38)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Process"
        Me.Button2.UseVisualStyleBackColor = True
        '
        '_cmbDataProvider
        '
        Me._cmbDataProvider.FormattingEnabled = True
        Me._cmbDataProvider.Location = New System.Drawing.Point(36, 11)
        Me._cmbDataProvider.Margin = New System.Windows.Forms.Padding(2)
        Me._cmbDataProvider.Name = "_cmbDataProvider"
        Me._cmbDataProvider.Size = New System.Drawing.Size(92, 21)
        Me._cmbDataProvider.TabIndex = 5
        Me._cmbDataProvider.Visible = False
        '
        'treeViewFolderBrowser1
        '
        Me.treeViewFolderBrowser1.DataSource = Nothing
        Me.treeViewFolderBrowser1.HideSelection = False
        Me.treeViewFolderBrowser1.Location = New System.Drawing.Point(36, 64)
        Me.treeViewFolderBrowser1.Margin = New System.Windows.Forms.Padding(2)
        Me.treeViewFolderBrowser1.Name = "treeViewFolderBrowser1"
        Me.treeViewFolderBrowser1.RootFolder = System.Environment.SpecialFolder.MyPictures
        Me.treeViewFolderBrowser1.SelectedDirectories = CType(resources.GetObject("treeViewFolderBrowser1.SelectedDirectories"), System.Collections.Specialized.StringCollection)
        Me.treeViewFolderBrowser1.Size = New System.Drawing.Size(1185, 434)
        Me.treeViewFolderBrowser1.TabIndex = 4
        '
        'LblTextSource
        '
        Me.LblTextSource.AutoSize = True
        Me.LblTextSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTextSource.Location = New System.Drawing.Point(33, 34)
        Me.LblTextSource.Name = "LblTextSource"
        Me.LblTextSource.Size = New System.Drawing.Size(319, 24)
        Me.LblTextSource.TabIndex = 8
        Me.LblTextSource.Text = "Select the QMD files from Source {0}:"
        '
        'ChooseFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 509)
        Me.Controls.Add(Me.LblTextSource)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me._cmbDataProvider)
        Me.Controls.Add(Me.treeViewFolderBrowser1)
        Me.Name = "ChooseFiles"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents _cmbDataProvider As System.Windows.Forms.ComboBox
    Private WithEvents treeViewFolderBrowser1 As Raccoom.Windows.Forms.TreeViewFolderBrowser
    Friend WithEvents LblTextSource As System.Windows.Forms.Label
End Class
