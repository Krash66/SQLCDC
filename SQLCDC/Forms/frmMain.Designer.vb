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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gbODBC = New System.Windows.Forms.GroupBox
        Me.btnRefreshODBC = New System.Windows.Forms.Button
        Me.cmbODBC = New System.Windows.Forms.ComboBox
        Me.gbLogData = New System.Windows.Forms.GroupBox
        Me.btnDBCC = New System.Windows.Forms.Button
        Me.btndblog2000 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnCapture = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.gbChooseFile = New System.Windows.Forms.GroupBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.btnFile = New System.Windows.Forms.Button
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog
        Me.btnCapture2008 = New System.Windows.Forms.Button
        Me.gbSettings = New System.Windows.Forms.GroupBox
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
        Me.gbODBC.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbODBC.Location = New System.Drawing.Point(12, 12)
        Me.gbODBC.Name = "gbODBC"
        Me.gbODBC.Size = New System.Drawing.Size(331, 42)
        Me.gbODBC.TabIndex = 0
        Me.gbODBC.TabStop = False
        Me.gbODBC.Text = "Choose ODBC SQLserver connection"
        '
        'btnRefreshODBC
        '
        Me.btnRefreshODBC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRefreshODBC.Location = New System.Drawing.Point(6, 17)
        Me.btnRefreshODBC.Name = "btnRefreshODBC"
        Me.btnRefreshODBC.Size = New System.Drawing.Size(88, 23)
        Me.btnRefreshODBC.TabIndex = 2
        Me.btnRefreshODBC.Text = "Refresh List"
        Me.btnRefreshODBC.UseVisualStyleBackColor = True
        '
        'cmbODBC
        '
        Me.cmbODBC.FormattingEnabled = True
        Me.cmbODBC.Location = New System.Drawing.Point(100, 19)
        Me.cmbODBC.Name = "cmbODBC"
        Me.cmbODBC.Size = New System.Drawing.Size(224, 21)
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
        Me.gbLogData.Location = New System.Drawing.Point(12, 129)
        Me.gbLogData.Name = "gbLogData"
        Me.gbLogData.Size = New System.Drawing.Size(1076, 522)
        Me.gbLogData.TabIndex = 1
        Me.gbLogData.TabStop = False
        Me.gbLogData.Text = "Log Data"
        '
        'btnDBCC
        '
        Me.btnDBCC.Location = New System.Drawing.Point(542, 19)
        Me.btnDBCC.Name = "btnDBCC"
        Me.btnDBCC.Size = New System.Drawing.Size(165, 23)
        Me.btnDBCC.TabIndex = 5
        Me.btnDBCC.Text = "Capture DBCC Log 2000"
        Me.btnDBCC.UseVisualStyleBackColor = True
        '
        'btndblog2000
        '
        Me.btndblog2000.Location = New System.Drawing.Point(373, 19)
        Me.btndblog2000.Name = "btndblog2000"
        Me.btndblog2000.Size = New System.Drawing.Size(162, 23)
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
        Me.DataGridView1.Location = New System.Drawing.Point(6, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1064, 468)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 26)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(206, 19)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(161, 23)
        Me.btnCapture.TabIndex = 3
        Me.btnCapture.Text = "Capture Log Data 2005"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 654)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1100, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(6, 19)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(245, 20)
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
        Me.gbChooseFile.Location = New System.Drawing.Point(349, 12)
        Me.gbChooseFile.Name = "gbChooseFile"
        Me.gbChooseFile.Size = New System.Drawing.Size(738, 42)
        Me.gbChooseFile.TabIndex = 4
        Me.gbChooseFile.TabStop = False
        Me.gbChooseFile.Text = "Choose Data File and Operation for table Test1"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(588, 17)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(139, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete All"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(443, 17)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(139, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(298, 17)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(139, 23)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(257, 17)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(35, 23)
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
        'btnCapture2008
        '
        Me.btnCapture2008.Location = New System.Drawing.Point(6, 19)
        Me.btnCapture2008.Name = "btnCapture2008"
        Me.btnCapture2008.Size = New System.Drawing.Size(194, 23)
        Me.btnCapture2008.TabIndex = 6
        Me.btnCapture2008.Text = "Capture Log Data 2008"
        Me.btnCapture2008.UseVisualStyleBackColor = True
        '
        'gbSettings
        '
        Me.gbSettings.Location = New System.Drawing.Point(12, 60)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(1075, 63)
        Me.gbSettings.TabIndex = 5
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Log Data representation Settings"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 676)
        Me.Controls.Add(Me.gbSettings)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbChooseFile)
        Me.Controls.Add(Me.gbLogData)
        Me.Controls.Add(Me.gbODBC)
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
