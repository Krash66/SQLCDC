'Imports iqry
Public Class frmQuery
    Inherits SQDStudio.frmBlank

    '/*****************************************************
    '/******** Still in building and testing Phase ********
    '/*****************************************************

    Dim QueryDS As New clsDatastore
    Dim QuerySelection As New clsDSSelection

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEditFieldASCII As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClrFieldASCII As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelRowASCII As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEditFieldHEX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClrFieldHEX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelRowHEX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents chkOnTop As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textboxStruct As System.Windows.Forms.TextBox
    Friend WithEvents SaveFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtNumRecords As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents AcsiiTab As System.Windows.Forms.TabPage
    Friend WithEvents HexTab As System.Windows.Forms.TabPage
    Friend WithEvents btnSaveToFileASCII As System.Windows.Forms.Button
    Friend WithEvents btnSaveToDBASCII As System.Windows.Forms.Button
    Friend WithEvents btnSaveToDBhex As System.Windows.Forms.Button
    Friend WithEvents btnSaveToFilehex As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuEditFieldASCII = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuClrFieldASCII = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelRowASCII = New System.Windows.Forms.ToolStripMenuItem
        Me.txtNumRecords = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnQuery = New System.Windows.Forms.Button
        Me.chkOnTop = New System.Windows.Forms.CheckBox
        Me.TextBoxDS = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.textboxStruct = New System.Windows.Forms.TextBox
        Me.SaveFD = New System.Windows.Forms.SaveFileDialog
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnSaveToFileASCII = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.AcsiiTab = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnSaveToDBASCII = New System.Windows.Forms.Button
        Me.HexTab = New System.Windows.Forms.TabPage
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuEditFieldHEX = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuClrFieldHEX = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelRowHEX = New System.Windows.Forms.ToolStripMenuItem
        Me.btnSaveToFilehex = New System.Windows.Forms.Button
        Me.btnSaveToDBhex = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.AcsiiTab.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HexTab.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Size = New System.Drawing.Size(768, 68)
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(1, 504)
        Me.GroupBox1.Size = New System.Drawing.Size(770, 7)
        '
        'cmdOk
        '
        Me.cmdOk.AccessibleName = ""
        Me.cmdOk.Enabled = False
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdOk.Location = New System.Drawing.Point(448, 528)
        Me.cmdOk.Size = New System.Drawing.Size(96, 23)
        Me.cmdOk.TabIndex = 11
        Me.cmdOk.Text = "Save to DB"
        Me.cmdOk.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(552, 528)
        Me.cmdCancel.Size = New System.Drawing.Size(96, 23)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Text = "Close"
        '
        'cmdHelp
        '
        Me.cmdHelp.AccessibleDescription = CType(configurationAppSettings.GetValue("HelpProvider1.HelpNamespace", GetType(String)), String)
        Me.cmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdHelp.Location = New System.Drawing.Point(656, 527)
        Me.cmdHelp.Size = New System.Drawing.Size(96, 23)
        Me.cmdHelp.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Text = "Query Tool"
        '
        'Label2
        '
        Me.Label2.Size = New System.Drawing.Size(692, 39)
        Me.Label2.Text = "This window allows you to work with the data in a data store. The data in this wi" & _
            "ndow can be displayed in both ASCII and HEX.  Please note that no Group Item fie" & _
            "lds are displayed"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditFieldASCII, Me.mnuClrFieldASCII, Me.mnuDelRowASCII})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 70)
        '
        'mnuEditFieldASCII
        '
        Me.mnuEditFieldASCII.Name = "mnuEditFieldASCII"
        Me.mnuEditFieldASCII.Size = New System.Drawing.Size(140, 22)
        Me.mnuEditFieldASCII.Text = "Edit Field"
        '
        'mnuClrFieldASCII
        '
        Me.mnuClrFieldASCII.Name = "mnuClrFieldASCII"
        Me.mnuClrFieldASCII.Size = New System.Drawing.Size(140, 22)
        Me.mnuClrFieldASCII.Text = "Clear Field"
        '
        'mnuDelRowASCII
        '
        Me.mnuDelRowASCII.Name = "mnuDelRowASCII"
        Me.mnuDelRowASCII.Size = New System.Drawing.Size(140, 22)
        Me.mnuDelRowASCII.Text = "Delete Row"
        '
        'txtNumRecords
        '
        Me.txtNumRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumRecords.Location = New System.Drawing.Point(680, 104)
        Me.txtNumRecords.Name = "txtNumRecords"
        Me.txtNumRecords.Size = New System.Drawing.Size(72, 20)
        Me.txtNumRecords.TabIndex = 2
        Me.txtNumRecords.Text = "100"
        Me.txtNumRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(482, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Number of Records per Query"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnQuery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuery.Location = New System.Drawing.Point(16, 528)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(176, 23)
        Me.btnQuery.TabIndex = 4
        Me.btnQuery.Text = "Query"
        '
        'chkOnTop
        '
        Me.chkOnTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkOnTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnTop.Location = New System.Drawing.Point(572, 132)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkOnTop.Size = New System.Drawing.Size(180, 16)
        Me.chkOnTop.TabIndex = 3
        Me.chkOnTop.Text = "Query Tool Always On Top"
        '
        'TextBoxDS
        '
        Me.TextBoxDS.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBoxDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDS.Location = New System.Drawing.Point(80, 76)
        Me.TextBoxDS.Name = "TextBoxDS"
        Me.TextBoxDS.ReadOnly = True
        Me.TextBoxDS.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxDS.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Datastore"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Structure"
        '
        'textboxStruct
        '
        Me.textboxStruct.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.textboxStruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxStruct.Location = New System.Drawing.Point(80, 104)
        Me.textboxStruct.Name = "textboxStruct"
        Me.textboxStruct.ReadOnly = True
        Me.textboxStruct.Size = New System.Drawing.Size(224, 20)
        Me.textboxStruct.TabIndex = 67
        '
        'SaveFD
        '
        Me.SaveFD.DefaultExt = "*.csv"
        Me.SaveFD.FileName = "Query1"
        Me.SaveFD.Filter = "comma delimited text files|*.csv|All files|*.*"
        Me.SaveFD.Title = "Save as a delimited text file"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(680, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "1"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(540, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "First Record Number"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSaveToFileASCII
        '
        Me.btnSaveToFileASCII.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveToFileASCII.Location = New System.Drawing.Point(528, 288)
        Me.btnSaveToFileASCII.Name = "btnSaveToFileASCII"
        Me.btnSaveToFileASCII.Size = New System.Drawing.Size(96, 23)
        Me.btnSaveToFileASCII.TabIndex = 6
        Me.btnSaveToFileASCII.Text = "Export"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.AcsiiTab)
        Me.TabControl1.Controls.Add(Me.HexTab)
        Me.TabControl1.ItemSize = New System.Drawing.Size(42, 18)
        Me.TabControl1.Location = New System.Drawing.Point(8, 160)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(752, 344)
        Me.TabControl1.TabIndex = 8
        '
        'AcsiiTab
        '
        Me.AcsiiTab.Controls.Add(Me.DataGridView1)
        Me.AcsiiTab.Controls.Add(Me.btnSaveToDBASCII)
        Me.AcsiiTab.Controls.Add(Me.btnSaveToFileASCII)
        Me.AcsiiTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcsiiTab.Location = New System.Drawing.Point(4, 22)
        Me.AcsiiTab.Name = "AcsiiTab"
        Me.AcsiiTab.Size = New System.Drawing.Size(744, 318)
        Me.AcsiiTab.TabIndex = 0
        Me.AcsiiTab.Text = "ASCII"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Desktop
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(744, 282)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 60
        '
        'btnSaveToDBASCII
        '
        Me.btnSaveToDBASCII.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveToDBASCII.Location = New System.Drawing.Point(632, 288)
        Me.btnSaveToDBASCII.Name = "btnSaveToDBASCII"
        Me.btnSaveToDBASCII.Size = New System.Drawing.Size(96, 23)
        Me.btnSaveToDBASCII.TabIndex = 7
        Me.btnSaveToDBASCII.Text = "Update"
        '
        'HexTab
        '
        Me.HexTab.Controls.Add(Me.DataGridView2)
        Me.HexTab.Controls.Add(Me.btnSaveToFilehex)
        Me.HexTab.Controls.Add(Me.btnSaveToDBhex)
        Me.HexTab.Location = New System.Drawing.Point(4, 22)
        Me.HexTab.Name = "HexTab"
        Me.HexTab.Size = New System.Drawing.Size(744, 318)
        Me.HexTab.TabIndex = 1
        Me.HexTab.Text = "Hex"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Desktop
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ContextMenuStrip = Me.ContextMenuStrip2
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.Desktop
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(744, 282)
        Me.DataGridView2.TabIndex = 3
        Me.DataGridView2.VirtualMode = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditFieldHEX, Me.mnuClrFieldHEX, Me.mnuDelRowHEX})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(141, 70)
        '
        'mnuEditFieldHEX
        '
        Me.mnuEditFieldHEX.Name = "mnuEditFieldHEX"
        Me.mnuEditFieldHEX.Size = New System.Drawing.Size(140, 22)
        Me.mnuEditFieldHEX.Text = "Edit Field"
        '
        'mnuClrFieldHEX
        '
        Me.mnuClrFieldHEX.Name = "mnuClrFieldHEX"
        Me.mnuClrFieldHEX.Size = New System.Drawing.Size(140, 22)
        Me.mnuClrFieldHEX.Text = "Clear Field"
        '
        'mnuDelRowHEX
        '
        Me.mnuDelRowHEX.Name = "mnuDelRowHEX"
        Me.mnuDelRowHEX.Size = New System.Drawing.Size(140, 22)
        Me.mnuDelRowHEX.Text = "Delete Row"
        '
        'btnSaveToFilehex
        '
        Me.btnSaveToFilehex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveToFilehex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveToFilehex.Location = New System.Drawing.Point(528, 288)
        Me.btnSaveToFilehex.Name = "btnSaveToFilehex"
        Me.btnSaveToFilehex.Size = New System.Drawing.Size(96, 23)
        Me.btnSaveToFilehex.TabIndex = 9
        Me.btnSaveToFilehex.Text = "Export"
        '
        'btnSaveToDBhex
        '
        Me.btnSaveToDBhex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveToDBhex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveToDBhex.Location = New System.Drawing.Point(632, 288)
        Me.btnSaveToDBhex.Name = "btnSaveToDBhex"
        Me.btnSaveToDBhex.Size = New System.Drawing.Size(96, 23)
        Me.btnSaveToDBhex.TabIndex = 10
        Me.btnSaveToDBhex.Text = "Update"
        '
        'frmQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(768, 566)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.textboxStruct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxDS)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNumRecords)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkOnTop)
        Me.MinimumSize = New System.Drawing.Size(632, 448)
        Me.Name = "frmQuery"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Text = "SQDStudio Query Tool v1.0"
        Me.Controls.SetChildIndex(Me.chkOnTop, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtNumRecords, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.btnQuery, 0)
        Me.Controls.SetChildIndex(Me.TextBoxDS, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.textboxStruct, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.cmdOk, 0)
        Me.Controls.SetChildIndex(Me.cmdCancel, 0)
        'Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.cmdHelp, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.AcsiiTab.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HexTab.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    '/// all clicks, check boxes, and text boxes
#Region "form events"

    Public Overrides Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

        ActiveQueryDSlist.Remove(QueryDS)
        Me.Close()

    End Sub

    Private Sub btnSaveToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveToFileASCII.Click
        Dim i, j, k As Integer
        Dim FieldCountASCII As Integer = DataGridView1.ColumnCount
        Dim RowCountASCII As Integer = DataGridView1.RowCount
        Dim currentfield As String = ""
        Dim HeaderFldObj As clsField
        Dim HeaderFldCnt As Integer = QuerySelection.DSSelectionFields.Count

        SaveFD.InitialDirectory = QueryFolderPath()
        SaveFD.ShowDialog()
        ' If the file name is not an empty string open it for saving.
        If SaveFD.FileName <> "" Then
            ' Saves the Query File via a FileStream created by the OpenFile method.
            Dim fs As System.IO.FileStream = CType _
               (SaveFD.OpenFile(), System.IO.FileStream)
            Dim objWriter As New System.IO.StreamWriter(fs)
            '/// first write the Table Name
            objWriter.WriteLine(DataGridView1.Name)
            objWriter.WriteLine()

            '/// Now write all the column headers

            For k = 0 To HeaderFldCnt - 2
                HeaderFldObj = QuerySelection.DSSelectionFields(k)
                If Not GetQfldType(HeaderFldObj) = QConstants.QFLD_Types.GROUPITEM Then
                    objWriter.Write(HeaderFldObj.FieldName & "  ,  ")
                End If
            Next
            HeaderFldObj = QuerySelection.DSSelectionFields(HeaderFldCnt - 1)
            If Not GetQfldType(HeaderFldObj) = QConstants.QFLD_Types.GROUPITEM Then
                objWriter.Write(HeaderFldObj.FieldName)
            End If
            objWriter.WriteLine()
            objWriter.WriteLine()

            '/// now write the data
            For i = 1 To DataGridView1.RowCount - 2
                For j = 1 To DataGridView1.ColumnCount - 2
                    If Not DataGridView1.Item(j, i) Is System.DBNull.Value Then
                        currentfield = DataGridView1.Item(j, i).Value.ToString
                        objWriter.Write(currentfield & ",")
                    Else
                        objWriter.Write("Null" & ",")
                    End If
                Next
                If Not DataGridView1.Item(FieldCountASCII - 1, i) Is System.DBNull.Value Then
                    currentfield = DataGridView1.Item(FieldCountASCII - 1, i).Value.ToString
                    objWriter.Write(currentfield)
                Else
                    objWriter.Write("Null")
                End If
                objWriter.WriteLine()
            Next
            objWriter.Close()
        End If
    End Sub

    Private Sub btnSaveToDBASCII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveToDBASCII.Click

    End Sub

    Private Sub btnSaveToFilehex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveToFilehex.Click
        Dim i, j, k As Integer
        Dim FieldCounthex As Integer = DataGridView2.ColumnCount
        Dim RowCounthex As Integer = DataGridView2.RowCount
        Dim currentfield As String = ""
        Dim HeaderFldObj As clsField
        Dim HeaderFldCnt As Integer = QuerySelection.DSSelectionFields.Count

        SaveFD.InitialDirectory = QueryFolderPath()
        SaveFD.ShowDialog()
        ' If the file name is not an empty string open it for saving.
        If SaveFD.FileName <> "" Then
            ' Saves the Query File via a FileStream created by the OpenFile method.
            Dim fs As System.IO.FileStream = CType _
               (SaveFD.OpenFile(), System.IO.FileStream)
            Dim objWriter As New System.IO.StreamWriter(fs)
            objWriter.WriteLine(DataGridView2.Name)
            objWriter.WriteLine()

            '/// Now write all the column headers
            For k = 0 To HeaderFldCnt - 2
                HeaderFldObj = QuerySelection.DSSelectionFields(k)
                If Not GetQfldType(HeaderFldObj) = QConstants.QFLD_Types.GROUPITEM Then
                    objWriter.Write(HeaderFldObj.FieldName & ",")
                End If
            Next
            HeaderFldObj = QuerySelection.DSSelectionFields(HeaderFldCnt - 1)
            If Not GetQfldType(HeaderFldObj) = QConstants.QFLD_Types.GROUPITEM Then
                objWriter.Write(HeaderFldObj.FieldName)
            End If
            objWriter.WriteLine()
            objWriter.WriteLine()

            '/// now write the data
            For i = 1 To DataGridView2.RowCount - 2
                For j = 1 To DataGridView2.ColumnCount - 2
                    If Not DataGridView2.Item(j, i) Is System.DBNull.Value Then
                        currentfield = DataGridView2.Item(j, i).Value.ToString
                        objWriter.Write(currentfield & ",")
                    Else
                        objWriter.Write("Null" & ",")
                    End If
                Next
                If Not DataGridView1.Item(FieldCounthex - 1, i) Is System.DBNull.Value Then
                    currentfield = DataGridView2.Item(FieldCounthex - 1, i).Value.ToString
                    objWriter.Write(currentfield)
                Else
                    objWriter.Write("Null")
                End If
                objWriter.WriteLine()
            Next
            objWriter.Close()
        End If
    End Sub

    Private Sub btnSaveToDBhex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveToDBhex.Click

    End Sub

    '/// This button isn't used and has been disabled Must remain to inherit frmBlank
    Private Overloads Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

        Me.Close()

    End Sub

    Public Overrides Sub cmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp.Click

        ShowHelp(modHelp.HHId.H_Query_Tool)

    End Sub

    Private Sub frmQuery_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            cmdOk_Click(sender, New EventArgs)
        ElseIf e.KeyCode = Keys.F1 Then
            '/// show help
            cmdHelp_Click(sender, New EventArgs)
        End If

    End Sub

    Private Sub chkOnTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOnTop.CheckedChanged
        Try
            If chkOnTop.CheckState = CheckState.Unchecked Then
                chkOnTop.Checked = False
                Me.TopMost = False
            Else
                chkOnTop.Checked = True
                Me.TopMost = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumRecords.TextChanged

    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click

        DataGridView1.Name = "Please wait while query is being built ....."
        DataGridView2.Name = "Please wait while query is being built ....."
        DoSelectionQuery(QueryDS, QuerySelection)

    End Sub

    Private Sub frmQuery_closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        ' removes this query from the collection of active queries
        ActiveQueryDSlist.Remove(QueryDS)

    End Sub

#End Region

    '/// Datagrid events and field editing
#Region "datagridview events"

    Sub datagridview1_click(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right
                ContextMenuStrip1.Show(e.X, e.Y)
            Case Windows.Forms.MouseButtons.Left

        End Select
    End Sub

    Private Sub mnuEditFieldASCII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditFieldASCII.Click

    End Sub

    Private Sub mnuClrFieldASCII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClrFieldASCII.Click

    End Sub

    Private Sub mnuDelRowASCII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelRowASCII.Click

    End Sub

    Sub datagridview2_click(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right
                ContextMenuStrip2.Show(e.X, e.Y)
            Case Windows.Forms.MouseButtons.Left

        End Select
    End Sub

    Private Sub mnuEditFieldHEX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditFieldHEX.Click

    End Sub

    Private Sub mnuClrFieldHEX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClrFieldHEX.Click

    End Sub

    Private Sub mnuDelRowHEX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelRowHEX.Click

    End Sub

#End Region

    '/// Translation of SQStudio Class properties to SQData class properties
#Region "Translation Functions"

    Private Function GetDsTransport(ByVal DS As clsDatastore) As QConstants.QDS_Transports

        Dim TransportIn As String

        TransportIn = DS.DsAccessMethod

        Select Case TransportIn
            Case DS_ACCESSMETHOD_FILE
                Return QDS_Transports.FILE
            Case DS_ACCESSMETHOD_IP
                Return QDS_Transports.TCP
            Case DS_ACCESSMETHOD_MQSERIES
                Return QDS_Transports.MQS
            Case Else
                Return QDS_Transports.FTP
        End Select

    End Function

    Private Function GetDSType(ByVal DS As clsDatastore) As QDS_Types

        Dim DSTypeIn As modDeclares.enumDatastore
        DSTypeIn = DS.DatastoreType

        'For testing purposes only
        Return QConstants.QDS_Types.BINARY

        '//// Provisions for all datastore types ////

        'Select Case DSTypeIn
        '    Case modDeclares.enumDatastore.DS_BINARY
        '        Return iqry.QConstants.QDS_Types.BINARY
        '    Case modDeclares.enumDatastore.DS_DB2CDC
        '        Return QConstants.QDS_Types.DB2CDC
        '    Case modDeclares.enumDatastore.DS_DB2LOAD
        '        Return QConstants.QDS_Types.DB2LOAD
        '    Case modDeclares.enumDatastore.DS_DELIMITED
        '        Return QConstants.QDS_Types.DELIMITED
        '    Case modDeclares.enumDatastore.DS_HSSUNLOAD
        '        Return QConstants.QDS_Types.HSSUNLOAD
        '    Case modDeclares.enumDatastore.DS_IBMEVENT
        '        Return QConstants.QDS_Types.IBMEVENT
        '    Case modDeclares.enumDatastore.DS_IMSCDC
        '        Return QConstants.QDS_Types.IMSCDC
        '    Case modDeclares.enumDatastore.DS_IMSDB
        '        Return QConstants.QDS_Types.IMSDB
        '    Case modDeclares.enumDatastore.DS_RELATIONAL
        '        Return
        '    Case modDeclares.enumDatastore.DS_TEXT
        '        Return QConstants.QDS_Types.TEXT
        '    Case modDeclares.enumDatastore.DS_TRBCDC
        '        Return
        '    Case modDeclares.enumDatastore.DS_UNKNOWN
        '        Return 0
        '    Case modDeclares.enumDatastore.DS_VSAM
        '        Return QConstants.QDS_Types.VSAM
        '    Case modDeclares.enumDatastore.DS_VSAMCDC
        '        Return QConstants.QDS_Types.VSAMCDC
        '    Case modDeclares.enumDatastore.DS_XML
        '        Return QConstants.QDS_Types.XML
        '    Case modDeclares.enumDatastore.DS_XMLCDC
        '        Return QConstants.QDS_Types.XMLCDC
        '    Case Else
        '        Return
        'End Select
    End Function

    Private Function GetDSEncoding(ByVal DS As clsDatastore) As QDS_Encodings
        Dim dsEncodingIn As String

        dsEncodingIn = DS.DsCharacterCode

        Select Case dsEncodingIn
            Case DS_CHARACTERCODE_EBCDIC
                Return QConstants.QDS_Encodings.BENDIAN_EBCDIC
            Case DS_CHARACTERCODE_ASCII
                Return QConstants.QDS_Encodings.BENDIAN_ASCII
            Case DS_CHARACTERCODE_SYSTEM
                Return QConstants.QDS_Encodings.LENDIAN_ASCII
        End Select

    End Function

    Private Function GetQfldName(ByVal selFld As clsField) As String

        Return selFld.FieldName

    End Function

    Private Function GetQfldType(ByVal selFld As clsField) As QFLD_Types

        Dim tempFldType As String
        tempFldType = CType(selFld.GetFieldAttr(modDeclares.enumFieldAttributes.ATTR_DATATYPE), String)
        Select Case tempFldType
            Case "CHAR"
                Return QConstants.QFLD_Types.FCHAR
            Case "TEXTNUM"
                Return QConstants.QFLD_Types.TEXTNUM
            Case "DATE"
                Return QConstants.QFLD_Types.SQD_DATE
            Case "TIME"
                Return QConstants.QFLD_Types.TIME
            Case "TIMESTAMP"
                Return QConstants.QFLD_Types.TIMESTAMP
            Case "VARCHAR2"
                Return QConstants.QFLD_Types.VCHAR2
            Case "DECIMAL"
                Return QConstants.QFLD_Types.PACKED
            Case "INTEGER"
                Return QConstants.QFLD_Types.FULLW
            Case "SMALLINT"
                Return QConstants.QFLD_Types.HALFW
            Case "ZONE"
                Return QConstants.QFLD_Types.ZONE
            Case "VARCHAR"
                Return QConstants.QFLD_Types.VCHAR
            Case "BINARY"
                Return QConstants.QFLD_Types.BINARY
            Case "MMDDYY"
                Return QConstants.QFLD_Types.MMDDYY
            Case "DDMMYY"
                Return QConstants.QFLD_Types.DDMMYY
            Case "YYDDMM"
                Return QConstants.QFLD_Types.YYDDMM
            Case "YYMMDD"
                Return QConstants.QFLD_Types.YYMMDD
            Case "YYYYDDMM"
                Return QConstants.QFLD_Types.YYYYDDMM
            Case "YYYYMMDD"
                Return QConstants.QFLD_Types.YYYYMMDD
            Case "MMDDYYYY"
                Return QConstants.QFLD_Types.MMDDYYYY
            Case "CIYYMMDD"
                Return QConstants.QFLD_Types.CIYYMMDD
            Case "XMLCDATA"
                Return QConstants.QFLD_Types.XMLCDATA
            Case "XMLPCDATA"
                Return QConstants.QFLD_Types.XMLPCDATA
            Case "XMLATTC"
                Return QConstants.QFLD_Types.XMLATTC
            Case "XMLATTPC"
                Return QConstants.QFLD_Types.XMLATTPC
            Case "GROUPITEM"
                Return QConstants.QFLD_Types.GROUPITEM
            Case ""
                Return 0
        End Select
    End Function

    Private Function GetQfldLen(ByVal selFld As clsField) As Integer

        Return CType(selFld.GetFieldAttr(modDeclares.enumFieldAttributes.ATTR_LENGTH), Integer)

    End Function

    Private Function GetQfldScale(ByVal selFld As clsField) As Integer

        Return CType(selFld.GetFieldAttr(modDeclares.enumFieldAttributes.ATTR_SCALE), Integer)

    End Function

    Private Function GetQfldOffset(ByVal selFld As clsField) As Integer

        Return CType(selFld.GetFieldAttr(modDeclares.enumFieldAttributes.ATTR_OFFSET), Integer)

    End Function

#End Region

    Public Function Query(ByVal DS As clsDatastore, ByVal Selection As clsDSSelection) As frmQuery
        Try
            QueryDS = DS
            QuerySelection = Selection
            If Not QueryDS Is Nothing Then
                TextBoxDS.Text = QueryDS.Text
                textboxStruct.Text = QuerySelection.Text
            Else
                Query = Nothing
                Exit Function
            End If
        Catch ex As Exception
            Query = Nothing
            Exit Function
        End Try
        Me.WindowState = FormWindowState.Normal
        Me.Show()
        Query = Me

    End Function

    Private Function DoSelectionQuery(ByVal QueryDS As clsDatastore, ByVal QuerySelection As clsDSSelection) As Boolean

        Dim fieldcount As Integer = QuerySelection.DSSelectionFields.Count
        Dim i, j, k, x, NumRecValue, startingRecord, endRecord As Integer
        Dim DSselFld As clsField

        ' Create new DataTable in memory.
        Dim ASCIIDataTable As DataTable = New DataTable
        Dim HEXDataTable As DataTable = New DataTable

        ' Declare DataColumn and DataRow variables.
        Dim ASCIIDataColumn As DataColumn
        Dim ASCIIDataRow As DataRow
        Dim HexDataColumn As DataColumn
        Dim HexDataRow As DataRow

        '/// Now define all the query objects
        Dim Q_Job As QSession
        Dim Q_Record As QDescription
        Dim Q_Field As QField
        Dim Q_Datastore As QDatastore = Nothing
        Dim QfieldName As String
        Dim QfieldType As QFLD_Types
        Dim Qfieldoffset As Integer
        Dim QfieldLength As Integer
        Dim QfieldScale As Integer

        Try
            '// Initialize Tables and variables
            ASCIIDataTable.Clear()
            HEXDataTable.Clear()

            startingRecord = GetVal(TextBox1.Text)
            NumRecValue = CInt(CType(txtNumRecords.Text, String))
            endRecord = startingRecord + NumRecValue - 1

            '/// Define the fields/columns for the DataTable
            '// first we add the record number column
            ASCIIDataColumn = New DataColumn   'define new columns
            HexDataColumn = New DataColumn
            ASCIIDataColumn.DataType = GetType(Integer)   'define type for columns
            HexDataColumn.DataType = GetType(Integer)
            ASCIIDataColumn.ColumnName = "Rec Number"    'name the columns
            HexDataColumn.ColumnName = "Rec Number"
            ASCIIDataTable.Columns.Add(ASCIIDataColumn)     'add the columns to the tables
            HEXDataTable.Columns.Add(HexDataColumn)

            '// now we add the datastore selection columns
            ' For each field in the datastore selection
            ' Create new DataColumn, set DataType, ColumnName and add to DataTable.
            For i = 0 To fieldcount - 1
                Dim currentField As clsField = QuerySelection.DSSelectionFields(i)
                If Not GetQfldType(currentField) = QConstants.QFLD_Types.GROUPITEM Then
                    ASCIIDataColumn = New DataColumn   'define new columns
                    HexDataColumn = New DataColumn
                    ASCIIDataColumn.DataType = GetType(String)   'define type for columns
                    HexDataColumn.DataType = GetType(String)
                    ASCIIDataColumn.ColumnName = currentField.FieldName    'name the columns
                    HexDataColumn.ColumnName = currentField.FieldName
                    ASCIIDataTable.Columns.Add(ASCIIDataColumn)  'add the columns to the tables
                    HEXDataTable.Columns.Add(HexDataColumn)
                End If
            Next

        Catch ex As Exception
            LogError(ex, "Occured while initializing Tables in DoSelectionQuery")
        End Try

        Try
            '/// set properties of query objects from GUI object Values
            Q_Job = New QSession
            Q_Datastore = Q_Job.NewDatastore("Q_" & QueryDS.Text)

            '********* access method, charCode, and type must be translated from GUI to SQDATA
            Q_Datastore.Transport = GetDsTransport(QueryDS)
            Q_Datastore.Type = GetDSType(QueryDS)
            Q_Datastore.Encoding = GetDSEncoding(QueryDS)

            '******** this must also be defined dynamically
            Q_Datastore.Name = GetAppPath() & "base.bin"

            Q_Datastore.StartAt = startingRecord

            '/// Now define the Record Object description for the query
            Q_Record = Q_Job.NewDescription("Q_" & QuerySelection.Text)

            '/// Now add the Field descriptions to the Record object
            For j = 0 To fieldcount - 1
                DSselFld = QuerySelection.DSSelectionFields(j)
                QfieldName = GetQfldName(DSselFld)
                QfieldType = GetQfldType(DSselFld)
                Qfieldoffset = GetQfldOffset(DSselFld)
                QfieldLength = GetQfldLen(DSselFld)
                QfieldScale = GetQfldScale(DSselFld)
                If Not QfieldType = QConstants.QFLD_Types.GROUPITEM Then
                    Q_Record.Fields.Add(QfieldName, QfieldType, Qfieldoffset, QfieldLength, QfieldScale)
                End If
            Next

            '/// add the record to the datastore
            Q_Datastore.Descriptions.Add(Q_Record)

        Catch ex As Exception
            LogError(ex, "Occured at DoSelectionQuery setting up Q_datastore and it's records and fields")
        End Try

        Try
            '/// open the Datastore
            Q_Datastore.Open()

            '/// Main Read Loop until number of records is reached or EOF
            x = startingRecord
            While x <= endRecord
                Application.DoEvents()
                Try

                    Q_Datastore.Read()    '/// read a record
                    ASCIIDataRow = ASCIIDataTable.NewRow     '/// create new row for each record
                    HexDataRow = HEXDataTable.NewRow         '/// create new row for each record

                    ASCIIDataRow(0) = x
                    HexDataRow(0) = x

                    For k = 1 To Q_Datastore.Description.Fields.Count
                        Q_Field = Q_Datastore.Description.Fields(k) '/get data from each field 
                        ASCIIDataRow(k) = Q_Field.Data  '/add ASCII field data to ASCII-row
                        HexDataRow(k) = Q_Field.Hex   '/add Hex field Data to Hex-row
                    Next
                    ASCIIDataTable.Rows.Add(ASCIIDataRow) '/// add the ASCII row to the table
                    HEXDataTable.Rows.Add(HexDataRow)   '/// add the Hex row to the table

                    x += 1   '/// keep track of how many records are read
                Catch ex As SQD_IQRY_EOF
                    Exit While
                End Try
            End While

        Catch ex As Exception
            LogError(ex, "Occured during DoQuerySelection Read")
        Finally
            Q_Datastore.Close()
        End Try

        Try
            '/// Now display all the Data
            '// first add name so that Title appears when written to a file
            DataGridView1.Name = "Query of Structure: " & QuerySelection.Text & "  In Datastore: " & QueryDS.Text & "   Displayed as ASCII"
            DataGridView2.Name = "Query of Structure: " & QuerySelection.Text & "  In Datastore: " & QueryDS.Text & "   Displayed as HEX"
            '// now bind the datasources to the datagrids
            DataGridView1.DataSource = ASCIIDataTable
            DataGridView2.DataSource = HEXDataTable
            '// add contraints
            DataGridView1.ReadOnly() = False
            DataGridView2.ReadOnly() = False
            DataGridView1.AllowDrop = False
            DataGridView2.AllowDrop = False
            DataGridView1.RowHeadersVisible = True
            DataGridView2.RowHeadersVisible = True
            DataGridView1.ColumnHeadersVisible = True
            DataGridView2.ColumnHeadersVisible = True
            DataGridView1.AllowUserToOrderColumns = False
            DataGridView2.AllowUserToOrderColumns = False
            '// enable and show the datagrids
            DataGridView1.Enabled() = True
            DataGridView2.Enabled() = True
            DataGridView1.Show()
            DataGridView2.Show()

        Catch ex As Exception
            LogError(ex, "Occured during DoQuerySelection display datagridviews")
        End Try

    End Function

End Class