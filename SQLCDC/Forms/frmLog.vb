Public Class frmLog
    Inherits SQDStudio.frmBlank

    Dim objThis As clsLogging

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
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents cmdClearLog As System.Windows.Forms.Button
    Friend WithEvents chkWordWrap As System.Windows.Forms.CheckBox
    Friend WithEvents SqlLog As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkEnableLogging As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtLog = New System.Windows.Forms.TextBox
        Me.cmdClearLog = New System.Windows.Forms.Button
        Me.chkWordWrap = New System.Windows.Forms.CheckBox
        Me.chkEnableLogging = New System.Windows.Forms.CheckBox
        Me.SqlLog = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Size = New System.Drawing.Size(704, 68)
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(1, 391)
        Me.GroupBox1.Size = New System.Drawing.Size(706, 7)
        '
        'cmdOk
        '
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdOk.Location = New System.Drawing.Point(424, 416)
        Me.cmdOk.TabIndex = 2
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(520, 416)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Visible = False
        '
        'cmdHelp
        '
        Me.cmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdHelp.Location = New System.Drawing.Point(616, 416)
        '
        'Label1
        '
        Me.Label1.Text = "Log Window"
        '
        'Label2
        '
        Me.Label2.Size = New System.Drawing.Size(628, 39)
        Me.Label2.Text = "You can view detailed log of database activities and application errors. You can " & _
            "also start/stop logging using this window."
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(8, 96)
        Me.txtLog.MaxLength = 100000
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(686, 163)
        Me.txtLog.TabIndex = 1
        Me.txtLog.WordWrap = False
        '
        'cmdClearLog
        '
        Me.cmdClearLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdClearLog.Location = New System.Drawing.Point(8, 414)
        Me.cmdClearLog.Name = "cmdClearLog"
        Me.cmdClearLog.Size = New System.Drawing.Size(120, 24)
        Me.cmdClearLog.TabIndex = 4
        Me.cmdClearLog.Text = "Clear Log"
        '
        'chkWordWrap
        '
        Me.chkWordWrap.Location = New System.Drawing.Point(8, 72)
        Me.chkWordWrap.Name = "chkWordWrap"
        Me.chkWordWrap.Size = New System.Drawing.Size(104, 24)
        Me.chkWordWrap.TabIndex = 6
        Me.chkWordWrap.Text = "Word Wrap"
        '
        'chkEnableLogging
        '
        Me.chkEnableLogging.Checked = True
        Me.chkEnableLogging.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnableLogging.Location = New System.Drawing.Point(120, 72)
        Me.chkEnableLogging.Name = "chkEnableLogging"
        Me.chkEnableLogging.Size = New System.Drawing.Size(104, 24)
        Me.chkEnableLogging.TabIndex = 7
        Me.chkEnableLogging.Text = "Enable Logging"
        '
        'SqlLog
        '
        Me.SqlLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SqlLog.Location = New System.Drawing.Point(8, 282)
        Me.SqlLog.Multiline = True
        Me.SqlLog.Name = "SqlLog"
        Me.SqlLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SqlLog.Size = New System.Drawing.Size(686, 103)
        Me.SqlLog.TabIndex = 58
        Me.SqlLog.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "SQL Log"
        '
        'frmLog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 453)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SqlLog)
        Me.Controls.Add(Me.chkEnableLogging)
        Me.Controls.Add(Me.chkWordWrap)
        Me.Controls.Add(Me.cmdClearLog)
        Me.Controls.Add(Me.txtLog)
        Me.Name = "frmLog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.cmdHelp, 0)
        Me.Controls.SetChildIndex(Me.txtLog, 0)
        Me.Controls.SetChildIndex(Me.cmdClearLog, 0)
        Me.Controls.SetChildIndex(Me.chkWordWrap, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.cmdOk, 0)
        Me.Controls.SetChildIndex(Me.cmdCancel, 0)
        Me.Controls.SetChildIndex(Me.chkEnableLogging, 0)
        Me.Controls.SetChildIndex(Me.SqlLog, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        EnableLogging = chkEnableLogging.Checked
        AddHandler objThis.OnEvent, AddressOf OnNewEvent

    End Sub

    Public Function ShowLog() As Boolean

        Try
            If IO.File.Exists(GetAppTemp() & "\" & errorTrace) Then
                txtLog.Text = LoadTextFile(GetAppTemp() & "\" & errorTrace)
            End If
            If IO.File.Exists(GetAppTemp() & "\" & TraceFile) Then
                SqlLog.Text = LoadTextFile(GetAppTemp() & "\" & TraceFile)
            End If
        Catch ex As Exception
        End Try

        Me.WindowState = FormWindowState.Normal
        Me.Show()

    End Function

    Private Sub OnNewEvent(ByVal Msg As String)

        txtLog.Text = txtLog.Text & Msg

    End Sub

    Private Sub cmdClearLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearLog.Click

        Try
            IO.File.Delete(GetAppTemp() & "\" & errorTrace)
            txtLog.Text = ""
            IO.File.Delete(GetAppTemp() & "\" & TraceFile)
            SqlLog.Text = ""
        Catch ex As Exception
        End Try

    End Sub

    Public Overrides Sub cmdOk_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub chkWordWrap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWordWrap.CheckedChanged

        txtLog.WordWrap = chkWordWrap.Checked
        SqlLog.WordWrap = chkWordWrap.Checked

    End Sub

    Private Sub chkEnableLogging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnableLogging.CheckedChanged

        EnableLogging = chkEnableLogging.Checked

    End Sub

    Public Overrides Sub cmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp.Click

        ShowHelp(modHelp.HHId.H_Welcome_to_SQData_Studio)
    End Sub

End Class
