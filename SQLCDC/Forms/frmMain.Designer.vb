<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbODBC = New System.Windows.Forms.GroupBox()
        Me.btnRefreshODBC = New System.Windows.Forms.Button()
        Me.cmbODBC = New System.Windows.Forms.ComboBox()
        Me.gbLogData = New System.Windows.Forms.GroupBox()
        Me.btnCapture2008 = New System.Windows.Forms.Button()
        Me.btnDBCC = New System.Windows.Forms.Button()
        Me.btndblog2000 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.gbChooseFile = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.gbODBC.SuspendLayout()
        Me.gbLogData.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.gbChooseFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbODBC
        '
        Me.gbODBC.Controls.Add(Me.btnRefreshODBC)
        Me.gbODBC.Controls.Add(Me.cmbODBC)
        Me.gbODBC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbODBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbODBC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbODBC.Location = New System.Drawing.Point(16, 15)
        Me.gbODBC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbODBC.Name = "gbODBC"
        Me.gbODBC.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbODBC.Size = New System.Drawing.Size(441, 52)
        Me.gbODBC.TabIndex = 0
        Me.gbODBC.TabStop = False
        Me.gbODBC.Text = "Choose ODBC SQLserver connection"
        '
        'btnRefreshODBC
        '
        Me.btnRefreshODBC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRefreshODBC.Location = New System.Drawing.Point(8, 21)
        Me.btnRefreshODBC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefreshODBC.Name = "btnRefreshODBC"
        Me.btnRefreshODBC.Size = New System.Drawing.Size(117, 28)
        Me.btnRefreshODBC.TabIndex = 2
        Me.btnRefreshODBC.Text = "Refresh List"
        Me.btnRefreshODBC.UseVisualStyleBackColor = True
        '
        'cmbODBC
        '
        Me.cmbODBC.FormattingEnabled = True
        Me.cmbODBC.Location = New System.Drawing.Point(133, 23)
        Me.cmbODBC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbODBC.Name = "cmbODBC"
        Me.cmbODBC.Size = New System.Drawing.Size(297, 25)
        Me.cmbODBC.TabIndex = 0
        '
        'gbLogData
        '
        Me.gbLogData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLogData.Controls.Add(Me.btnCapture2008)
        Me.gbLogData.Controls.Add(Me.btnDBCC)
        Me.gbLogData.Controls.Add(Me.btndblog2000)
        Me.gbLogData.Controls.Add(Me.DataGridView1)
        Me.gbLogData.Controls.Add(Me.btnCapture)
        Me.gbLogData.Location = New System.Drawing.Point(16, 159)
        Me.gbLogData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbLogData.Name = "gbLogData"
        Me.gbLogData.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbLogData.Size = New System.Drawing.Size(1435, 642)
        Me.gbLogData.TabIndex = 1
        Me.gbLogData.TabStop = False
        Me.gbLogData.Text = "Log Data"
        '
        'btnCapture2008
        '
        Me.btnCapture2008.Location = New System.Drawing.Point(8, 23)
        Me.btnCapture2008.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCapture2008.Name = "btnCapture2008"
        Me.btnCapture2008.Size = New System.Drawing.Size(259, 28)
        Me.btnCapture2008.TabIndex = 6
        Me.btnCapture2008.Text = "Capture Log Data 2008"
        Me.btnCapture2008.UseVisualStyleBackColor = True
        '
        'btnDBCC
        '
        Me.btnDBCC.Location = New System.Drawing.Point(723, 23)
        Me.btnDBCC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDBCC.Name = "btnDBCC"
        Me.btnDBCC.Size = New System.Drawing.Size(220, 28)
        Me.btnDBCC.TabIndex = 5
        Me.btnDBCC.Text = "Capture DBCC Log 2000"
        Me.btnDBCC.UseVisualStyleBackColor = True
        '
        'btndblog2000
        '
        Me.btndblog2000.Location = New System.Drawing.Point(497, 23)
        Me.btndblog2000.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btndblog2000.Name = "btndblog2000"
        Me.btndblog2000.Size = New System.Drawing.Size(216, 28)
        Me.btndblog2000.TabIndex = 4
        Me.btndblog2000.Text = "Capture Log Data 2000"
        Me.btndblog2000.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(8, 59)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1419, 576)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(113, 28)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(275, 23)
        Me.btnCapture.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(215, 28)
        Me.btnCapture.TabIndex = 3
        Me.btnCapture.Text = "Capture Log Data 2005"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 810)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1467, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(8, 23)
        Me.txtFileName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(325, 23)
        Me.txtFileName.TabIndex = 3
        '
        'gbChooseFile
        '
        Me.gbChooseFile.Controls.Add(Me.btnDelete)
        Me.gbChooseFile.Controls.Add(Me.btnUpdate)
        Me.gbChooseFile.Controls.Add(Me.btnInsert)
        Me.gbChooseFile.Controls.Add(Me.btnFile)
        Me.gbChooseFile.Controls.Add(Me.txtFileName)
        Me.gbChooseFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbChooseFile.Location = New System.Drawing.Point(465, 15)
        Me.gbChooseFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbChooseFile.Name = "gbChooseFile"
        Me.gbChooseFile.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbChooseFile.Size = New System.Drawing.Size(984, 52)
        Me.gbChooseFile.TabIndex = 4
        Me.gbChooseFile.TabStop = False
        Me.gbChooseFile.Text = "Choose Data File and Operation for table Test1"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(784, 21)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(185, 28)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete All"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(591, 21)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(185, 28)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(397, 21)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(185, 28)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(343, 21)
        Me.btnFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(47, 28)
        Me.btnFile.TabIndex = 4
        Me.btnFile.Text = "..."
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'OFD1
        '
        Me.OFD1.DefaultExt = "txt"
        Me.OFD1.FileName = "Input.txt"
        Me.OFD1.Filter = "Text Files|*.txt|All Files|*.*"
        Me.OFD1.InitialDirectory = "C:\Documents and Settings\tkarasc\My Documents\scott\CaptureSQLsvr\Log"
        '
        'gbSettings
        '
        Me.gbSettings.Location = New System.Drawing.Point(16, 74)
        Me.gbSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbSettings.Size = New System.Drawing.Size(1433, 78)
        Me.gbSettings.TabIndex = 5
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Log Data representation Settings"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 832)
        Me.Controls.Add(Me.gbSettings)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbChooseFile)
        Me.Controls.Add(Me.gbLogData)
        Me.Controls.Add(Me.gbODBC)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "SQLsvrCDC"
        Me.gbODBC.ResumeLayout(False)
        Me.gbLogData.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.gbChooseFile.ResumeLayout(False)
        Me.gbChooseFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbODBC As System.Windows.Forms.GroupBox
    Friend WithEvents cmbODBC As System.Windows.Forms.ComboBox
    Friend WithEvents gbLogData As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCapture As System.Windows.Forms.Button
    Friend WithEvents btnRefreshODBC As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents gbChooseFile As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents OFD1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnDBCC As System.Windows.Forms.Button
    Friend WithEvents btndblog2000 As System.Windows.Forms.Button
    Friend WithEvents btnCapture2008 As System.Windows.Forms.Button
    Friend WithEvents gbSettings As System.Windows.Forms.GroupBox

End Class
