Public Class frmMain

    Dim ODBCsource As New ClsODBCinfo
    Private ODBCHelper As New CRODBCHelper()
    Dim objProj As New ClsCDCproj

    Dim DSNname As String
    Dim DSNdesc As String
    Dim DSNtype As EnumODBCtype
    Dim RecArr As New ArrayList
    Dim RecArr2 As New ArrayList
    Private Ulogin As clsLogin

    Dim mDSNTable As System.Data.DataTable


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQDmetaDataSet.Test1' table. You can move, or remove it, as needed.
        'If Application.CommonAppDataRegistry.GetValue("WinState") IsNot Nothing Then
        '    Dim winStr As String = Application.CommonAppDataRegistry.GetValue("WinState")
        '    Select Case winStr
        '        Case "Maximized"
        '            Me.WindowState = FormWindowState.Maximized
        '        Case "Normal"
        '            Me.WindowState = FormWindowState.Normal
        '        Case Else
        '            Me.WindowState = FormWindowState.Normal
        '    End Select

        'End If
        LoadGlobalValues()
        btnRefreshODBC.PerformClick()

    End Sub

    Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        '/// Save Window State
        'Application.CommonAppDataRegistry.SetValue("WinState", Me.WindowState)

    End Sub

    Private Sub btnRefreshODBC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshODBC.Click
        SetComboODBC()

    End Sub

    Private Function getDSNlist() As Boolean
        'GET THE DSN LIST
        Dim ret As Boolean

        ret = ODBCHelper.BuildDSNDataTable()
        If ret = True Then
            mDSNTable = ODBCHelper.DSNDataTable
            Return True
        Else
            Return False
        End If

    End Function

    Function SetComboODBC() As Boolean

        Dim tempDBName As String

        Try
            cmbODBC.Items.Clear()
            cmbODBC.Items.Add(New Mylist("", ""))
            If getDSNlist() = True Then
                For Each dr As DataRow In mDSNTable.Rows
                    If dr(0).ToString.Trim <> "" Then
                        If dr.Item("DSN_DESCRIPTION").ToString.Contains("SQL") Then
                            tempDBName = dr(0).ToString
                            cmbODBC.Items.Add(New Mylist(tempDBName, tempDBName))
                        End If
                    End If
                Next
            End If

            cmbODBC.SelectedIndex = 0

            Return True

        Catch ex As Exception
            LogError(ex, "frmMain SetComboODBC")
            Return False
        End Try

    End Function

    Private Sub cmbODBC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbODBC.SelectedIndexChanged

        Try
            objProj.ProjectDSN = cmbODBC.SelectedItem.ToString

        Catch ex As Exception
            LogError(ex, "frmMain cmbODBC_SelectedIndexChanged")
        End Try

    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click

    End Sub

    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click

        Try
            OFD1.ShowDialog()

        Catch ex As Exception
            LogError(ex, "frmMain btnFile_Click")
        End Try

    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        Dim cmd As Odbc.OdbcCommand
        Dim tran As Odbc.OdbcTransaction = Nothing
        Try
            Dim frmL As frmODBCLogin
            '/// Login
            frmL = New frmODBCLogin
            Ulogin = frmL.getLogin()
            If Ulogin IsNot Nothing Then
                objProj.ProjectDSNUID = Ulogin.UID
                objProj.ProjectDSNPWD = Ulogin.PWD
            End If

            Dim cnn As New System.Data.Odbc.OdbcConnection(objProj.ConnectionString)
            cnn.Open()
            cmd = New Odbc.OdbcCommand
            cmd.Connection = cnn
            tran = cnn.BeginTransaction()
            cmd.Transaction = tran

            For Each rec As Array In RecArr
                Dim Sql As String = "INSERT INTO Test1 " & _
                "([EmplNumber]" & _
                ",[SerNo]" & _
                ",[LastName]" & _
                ",[FirstName]" & _
                ",[Salary]" & _
                ",[BonusSmall]" & _
                ",[BigDate]" & _
                ",[SmallDate]" & _
                ",[Bit1]" & _
                ",[Tinyint1]" & _
                ",[SmallInt1]" & _
                ",[Int1]" & _
                ",[BigInt1]" & _
                ",[Float1]" & _
                ",[Real1]" & _
                ",[Char1]" & _
                ",[Text1]" & _
                ",[Nchar1]" & _
                ",[Nvarchar1]" & _
                ",[Bin1]" & _
                ",[Varbin1])" & _
                " VALUES " & _
                "(NEWID()" & _
                "," & rec(0) & _
                "," & Quote(rec(1)) & _
                "," & Quote(rec(2)) & _
                "," & rec(3) & _
                "," & rec(4) & _
                "," & rec(5) & _
                "," & rec(6) & _
                "," & rec(7) & _
                "," & rec(8) & _
                "," & rec(9) & _
                "," & rec(10) & _
                "," & rec(11) & _
                "," & rec(12) & _
                "," & rec(13) & _
                "," & Quote(rec(14)) & _
                "," & Quote(rec(15)) & _
                "," & Quote(rec(16)) & _
                "," & Quote(rec(17)) & _
                "," & rec(18) & _
                "," & rec(19) & ")"

                cmd.CommandText = Sql
                Log(Sql)
                cmd.ExecuteNonQuery()
            Next

            tran.Commit()
            cnn.Close()
            MsgBox("Insert Succeeded", MsgBoxStyle.Information, "Result")

        Catch ex As Exception
            tran.Rollback()
            LogError(ex, "frmMain btnInsert_Click")
        End Try

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim cmd As Odbc.OdbcCommand
        Dim tran As Odbc.OdbcTransaction = Nothing
        Try
            Dim frmL As frmODBCLogin
            '/// Login
            frmL = New frmODBCLogin
            Ulogin = frmL.getLogin()
            If Ulogin IsNot Nothing Then
                objProj.ProjectDSNUID = Ulogin.UID
                objProj.ProjectDSNPWD = Ulogin.PWD
            End If

            Dim cnn As New System.Data.Odbc.OdbcConnection(objProj.ConnectionString)
            cnn.Open()
            cmd = New Odbc.OdbcCommand
            cmd.Connection = cnn
            'tran = cnn.BeginTransaction()
            'cmd.Transaction = tran

            For Each rec As Array In RecArr
                Dim sql As String = "Update Test1 Set " & _
                            "[Salary]=" & rec(3) & _
                            ",[BonusSmall]=" & rec(4) & _
                            ",[BigDate]=" & rec(5) & _
                            ",[SmallDate]=" & rec(6) & _
                            ",[Bit1]=" & rec(7) & _
                            ",[Tinyint1]=" & rec(8) & _
                            ",[SmallInt1]=" & rec(9) & _
                            ",[Int1]=" & rec(10) & _
                            ",[BigInt1]=" & rec(11) & _
                            ",[Float1]=" & rec(12) & _
                            ",[Real1]=" & rec(13) & _
                            ",[Char1]=" & Quote(rec(14)) & _
                            ",[Text1]=" & Quote(rec(15)) & _
                            ",[Nchar1]=" & Quote(rec(16)) & _
                            ",[Nvarchar1]=" & Quote(rec(17)) & _
                            ",[Bin1]=" & rec(18) & _
                            ",[Varbin1]=" & rec(19) & _
                            " WHERE [SerNo]=" & rec(0)


                cmd.CommandText = Sql
                Log(Sql)
                cmd.ExecuteNonQuery()
            Next

            'tran.Commit()
            cnn.Close()
            MsgBox("Update Succeeded", MsgBoxStyle.Information, "Result")

        Catch ex As Exception
            'tran.Rollback()
            LogError(ex, "frmMain btnUpdate_Click")
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim cmd As New Odbc.OdbcCommand
        Dim tran As Odbc.OdbcTransaction = Nothing

        Try
            Dim frmL As frmODBCLogin
            '/// Login
            frmL = New frmODBCLogin
            Ulogin = frmL.getLogin()
            If Ulogin IsNot Nothing Then
                objProj.ProjectDSNUID = Ulogin.UID
                objProj.ProjectDSNPWD = Ulogin.PWD
            End If
            Dim cnn As New System.Data.Odbc.OdbcConnection(objProj.ConnectionString)
            cnn.Open()

            cmd.Connection = cnn
            '//We need to put in transaction because we will add structure and 
            '//fields in two steps so if one fails rollback all
            tran = cnn.BeginTransaction()
            cmd.Transaction = tran

            Dim sql As String = "Delete from Test1"
            Log(sql)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            tran.Commit()
            cnn.Close()
            MsgBox("Delete Succeeded", MsgBoxStyle.Information, "Result")

        Catch ex As Exception
            tran.Rollback()
            LogError(ex, "frmMain btnDelete_Click")
        End Try

    End Sub

    Private Sub OFD1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OFD1.FileOk

        Try
            Dim FS1 As IO.FileStream
            Dim strArr As String()


            txtFileName.Text = OFD1.FileName
            RecArr.Clear()

            If System.IO.File.Exists(OFD1.FileName) = True Then
                FS1 = OFD1.OpenFile()
            Else
                MsgBox("File does not exist or cannot be opened", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            Dim ObjReader As New System.IO.StreamReader(FS1)

            While (ObjReader.Peek() > -1)
                'Array.Clear(strArr, 0, strArr.Length)

                strArr = Strings.Split(ObjReader.ReadLine(), ",")
                If strArr IsNot Nothing Then
                    RecArr.Add(strArr)
                End If
            End While

            ObjReader.Close()
            FS1.Close()


        Catch ex As Exception
            LogError(ex, "frmMain OFD1_FileOk")
        End Try

    End Sub

    '/// Capture 2005 Log
    Private Sub btnCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click

        Try
            Dim frmL As frmODBCLogin

            '/// Login
            frmL = New frmODBCLogin
            Ulogin = frmL.getLogin()
            If Ulogin IsNot Nothing Then
                objProj.ProjectDSNUID = Ulogin.UID
                objProj.ProjectDSNPWD = Ulogin.PWD
            End If

            Dim dt As New System.Data.DataTable("temp1")
            Dim TempTable As New System.Data.DataTable("TempTable1")
            '//// Setup Datagridview results table 
            For i As Integer = 1 To 17
                Dim newItem As New DataColumn
                Dim newItem2 As New DataColumn
                Select Case i
                    Case 1
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Current LSN"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Current LSN"
                    Case 2
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Operation"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Operation"
                    Case 3
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Transaction ID"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Transaction ID"
                    Case 4
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Log Record Fixed Length"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Log Record Fixed Length"
                    Case 5
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Log Record Length"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Log Record Length"
                    Case 6
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "AllocUnitID"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "AllocUnitID"
                    Case 7
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "AllocUnitName"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "AllocUnitName"
                    Case 8
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Num Elements"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Num Elements"
                    Case 9
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "Flag Bits"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Flag Bits"
                    Case 10
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Transaction Name"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Transaction Name"
                    Case 11
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Description"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Description"
                    Case 12
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "RowLog Contents 0"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "RowLog Contents 0"
                    Case 13
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "RowLog Contents 1"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "RowLog Contents 1"
                    Case 14
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "RowLog Contents 2"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "RowLog Contents 2"
                    Case 15
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "RowLog Contents 3"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "RowLog Contents 3"
                    Case 16
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "RowLog Contents 4"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "RowLog Contents 4"
                    Case 17
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "Log Record"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Log Record"
                End Select
                dt.Columns.Add(newItem)
                TempTable.Columns.Add(newItem2)
            Next


            Dim da As System.Data.Odbc.OdbcDataAdapter

            Dim cnn As New System.Data.Odbc.OdbcConnection(objProj.ConnectionString)

            dt.Clear() '

            cnn.Open()

            Dim sql As String = "select [Current LSN],Operation, [Transaction ID],[Log Record Fixed Length],[Log Record Length],AllocUnitID,AllocUnitName,[Num Elements],[Flag Bits],[Transaction Name], Description, [RowLog Contents 0],[RowLog Contents 1],[RowLog Contents 2],[RowLog Contents 3],[RowLog Contents 4], [Log Record] from ::fn_dblog(null,null)"

            da = New System.Data.Odbc.OdbcDataAdapter(sql, cnn)
            Log(sql)

            If da.Fill(dt) > 0 Then
                For Each row As DataRow In dt.Rows
                    'For Each itm As Object In row.ItemArray
                    '    MsgBox("item = " & itm.ToString)
                    'Next
                    Dim newrow As DataRow
                    newrow = TempTable.NewRow
                    Dim count As Integer = 0
                    Dim FixLen As Integer
                    Dim h As String = ""

                    For Each Val As Object In row.ItemArray
                        If count < 11 Then

                            If count = 3 Then
                                Dim d As Decimal = Convert.ToDecimal(Val)
                                FixLen = CInt(d)
                                newrow.Item(count) = FixLen.ToString
                            ElseIf count = 8 Then
                                If GetVal(Val) IsNot Nothing Then
                                    Dim sb As New System.Text.StringBuilder

                                    For Each b As Byte In Val
                                        If b > -1 Then
                                            h = Microsoft.VisualBasic.Conversion.Hex(b)

                                            sb.Append("~" & b.ToString)
                                            'sb.Append(Chr(b))
                                        End If
                                    Next
                                    newrow.Item(count) = sb.ToString
                                End If
                            Else
                                newrow.Item(count) = Val
                            End If

                        ElseIf count = 11 Then
                            '****** Row Log Contents 0
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count8 As Integer = 1

                                For Each b As Byte In Val
                                    'If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)
                                    'sb.Append(h)
                                    'sb.Append(Chr(b))
                                    'Else
                                    'sb.Append(b)
                                    'End If
                                    'If count4 > 63 And count4 < 262 Then '
                                    If count8 < 85 Then
                                        sb.Append("~" & b.ToString)
                                    Else
                                        sb.Append(Chr(b))
                                    End If
                                    'Else
                                    '    If count4 <= 63 Then
                                    '        sb.Append("~" & h)
                                    '    Else
                                    '        sb.Append("~" & b.ToString)
                                    '    End If
                                    'End If
                                    count8 += 1
                                Next
                                newrow.Item(count) = sb.ToString
                            End If

                        ElseIf count = 12 Then
                            '****** Row Log Contents 1
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count7 As Integer = 1

                                For Each b As Byte In Val
                                    'If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)
                                    'sb.Append(h)
                                    'sb.Append(Chr(b))
                                    'Else
                                    'sb.Append(b)
                                    'End If
                                    'If count4 > 63 And count4 < 262 Then '
                                    If count7 < 100 Then
                                        sb.Append("~" & b.ToString)
                                    Else
                                        sb.Append(Chr(b))
                                    End If
                                    'Else
                                    '    If count4 <= 63 Then
                                    '        sb.Append("~" & h)
                                    '    Else
                                    '        sb.Append("~" & b.ToString)
                                    '    End If
                                    'End If
                                    count7 += 1
                                Next
                                newrow.Item(count) = sb.ToString
                            End If

                        ElseIf count = 13 Then
                            '****** Row Log Contents 2
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count6 As Integer = 1

                                For Each b As Byte In Val
                                    'If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)
                                    'sb.Append(h)
                                    'sb.Append(Chr(b))
                                    'Else
                                    'sb.Append(b)
                                    'End If
                                    'If count4 > 63 And count4 < 262 Then '
                                    If count6 < 100 Then
                                        sb.Append("~" & b.ToString)
                                    Else
                                        sb.Append(Chr(b))
                                    End If
                                    'Else
                                    '    If count4 <= 63 Then
                                    '        sb.Append("~" & h)
                                    '    Else
                                    '        sb.Append("~" & b.ToString)
                                    '    End If
                                    'End If
                                    count6 += 1
                                Next
                                newrow.Item(count) = sb.ToString
                            End If

                        ElseIf count = 14 Then
                            '****** Row Log Contents 3
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count5 As Integer = 1

                                For Each b As Byte In Val
                                    'If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)
                                    'sb.Append(h)
                                    'sb.Append(Chr(b))
                                    'Else
                                    'sb.Append(b)
                                    'End If
                                    'If count4 > 63 And count4 < 262 Then '
                                    If count5 < 100 Then
                                        sb.Append("~" & b.ToString)
                                    Else
                                        sb.Append(Chr(b))
                                    End If
                                    'Else
                                    '    If count4 <= 63 Then
                                    '        sb.Append("~" & h)
                                    '    Else
                                    '        sb.Append("~" & b.ToString)
                                    '    End If
                                    'End If
                                    count5 += 1
                                Next
                                newrow.Item(count) = sb.ToString
                            End If

                        ElseIf count = 15 Then
                            '****** Row Log Contents 4
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count4 As Integer = 1

                                For Each b As Byte In Val
                                    'If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)
                                    'sb.Append(h)
                                    'sb.Append(Chr(b))
                                    'Else
                                    'sb.Append(b)
                                    'End If
                                    'If count4 > 63 And count4 < 262 Then '
                                    If count4 < 100 Then
                                        sb.Append("~" & b.ToString)
                                    Else
                                        sb.Append(Chr(b))
                                    End If
                                    'Else
                                    '    If count4 <= 63 Then
                                    '        sb.Append("~" & h)
                                    '    Else
                                    '        sb.Append("~" & b.ToString)
                                    '    End If
                                    'End If
                                    count4 += 1
                                Next
                                newrow.Item(count) = sb.ToString
                            End If

                        Else
                            '***** Log Record ******
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count3 As Integer = 1

                                For Each b As Byte In Val

                                    If b > -1 Then
                                        h = Microsoft.VisualBasic.Conversion.Hex(b)

                                        If count3 = 65 Then
                                            sb.Append(" <65>>> ")
                                        End If
                                        If count3 = 74 Then
                                            sb.Append(" <74>>> ")
                                        End If
                                        If count3 = 80 Then
                                            sb.Append(" <80>>> ")
                                        End If
                                        If count3 = 88 Then
                                            sb.Append(" <88>>> ")
                                        End If
                                        If count3 = 90 Then
                                            sb.Append(" <90>>> ")
                                        End If
                                        If count3 = 100 Then
                                            sb.Append(" <100>>> ")
                                        End If
                                        If count3 = 131 Then
                                            sb.Append(" <131>>> ")
                                        End If
                                        If count3 = 157 Then
                                            sb.Append(" <157>>> ")
                                        End If

                                        'sb.Append("~" & b.ToString)
                                        'sb.Append(Chr(b)) '"~" & 
                                        'sb.Append("~" & h)
                                        'sb.Append("~" & b)

                                        If count3 > 63 And count3 < 238 Then '
                                            If count3 < 200 Then
                                                sb.Append("~" & b.ToString)
                                            Else
                                                sb.Append(Chr(b))
                                            End If
                                        Else
                                            If count3 <= 63 Then
                                                sb.Append("~" & h)
                                            Else
                                                sb.Append("~" & b.ToString)
                                            End If
                                        End If

                                        If count3 = 62 Then
                                            sb.Append(" <<<62> ")
                                        End If

                                        'If count3 = 70 Then
                                        '    sb.Append(" <<<70> ")
                                        'End If

                                        'If count3 = 78 Then
                                        '    sb.Append(" <<<78> ")
                                        'End If

                                        'If count3 = 132 Then
                                        '    sb.Append(" <<<132> ")
                                        'End If

                                        'If count3 = 136 Then
                                        '    sb.Append(" <<<136> ")
                                        'End If

                                        'If count3 = 140 Then
                                        '    sb.Append(" <<<140> ")
                                        'End If

                                        ''If b > -1 Then
                                        'sb.Append(Chr(b))

                                        count3 += 1

                                    Else
                                        'sb.Append(b)
                                        'End If
                                        'If b < 33 Or b > 126 Then
                                        'If b < 47 Or (b > 57 And b < 64) Or (b > 122 And b < 176) Then  'Or (b > 90 And b < 97)
                                        '    sb.Append(CInt(b.ToString)) 'sb.Append(b)
                                        'Else
                                        '    sb.Append(Chr(b))
                                        'End If

                                    End If
                                Next
                                newrow.Item(count) = sb.ToString
                            End If
                        End If
                        count += 1
                    Next
                    TempTable.Rows.Add(newrow)
                Next
                'DataGridView1.DataSource = dt

                DataGridView1.DataSource = TempTable
                '    DataGridView1.Rows.Add(newrow)

                DataGridView1.Visible = True
                DataGridView1.Enabled = True
                DataGridView1.Show()
                DataGridView1.ClearSelection()
            End If


        Catch ex As Exception
            LogError(ex, "frmMain btnCapture_Click")
        End Try

    End Sub

    '/// Capture 2000 Log
    Private Sub btndblog2000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndblog2000.Click

        Try
            Dim frmL As frmODBCLogin
            '/// Login
            frmL = New frmODBCLogin
            Ulogin = frmL.getLogin()
            If Ulogin IsNot Nothing Then
                objProj.ProjectDSNUID = Ulogin.UID
                objProj.ProjectDSNPWD = Ulogin.PWD
            End If

            Dim dt As New System.Data.DataTable("temp1")
            Dim TempTable As New System.Data.DataTable("TempTable1")
            '//// Setup Datagridview results table 
            For i As Integer = 1 To 15
                Dim newItem As New DataColumn
                Dim newItem2 As New DataColumn
                Select Case i
                    Case 1
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Current LSN"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Current LSN"
                    Case 2
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Operation"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Operation"
                    Case 3
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Context"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Context"
                    Case 4
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Transaction ID"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Transaction ID"
                    Case 5
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "Tag Bits"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Tag Bits"
                    Case 6
                        newItem.DataType = GetType(Short)
                        newItem.ColumnName = "Log Record Length"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Log Record Length"
                    Case 7
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "Flag Bits"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Flag Bits"
                    Case 8
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Object Name"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Object Name"
                    Case 9
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Index Name"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Index Name"
                    Case 10
                        newItem.DataType = GetType(Short)
                        newItem.ColumnName = "Offset in Row"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Offset in Row"
                    Case 11
                        newItem.DataType = GetType(Short)
                        newItem.ColumnName = "Num Elements"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Num Elements"
                    Case 12
                        newItem.DataType = GetType(Short)
                        newItem.ColumnName = "Element"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Element"
                    Case 13
                        newItem.DataType = GetType(Integer)
                        newItem.ColumnName = "Element Length"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Element Length"
                    Case 14
                        newItem.DataType = GetType(Short)
                        newItem.ColumnName = "Offset"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Offset"
                    Case 15
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "Row Data"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Row Data"
                End Select
                dt.Columns.Add(newItem)
                TempTable.Columns.Add(newItem2)
            Next


            Dim da As System.Data.Odbc.OdbcDataAdapter

            Dim cnn As New System.Data.Odbc.OdbcConnection(objProj.ConnectionString)
            'Dim cmd As New System.Data.Odbc.OdbcCommand
            'Dim dr As System.Data.Odbc.OdbcDataReader

            dt.Clear() '
            TempTable.Clear()

            cnn.Open()

            Dim sql As String = "select * from ::fn_dblog(null,null)"
            Log(sql)

            da = New System.Data.Odbc.OdbcDataAdapter(sql, cnn)

            If da.Fill(dt) > 0 Then
                For Each row As DataRow In dt.Rows
                    'For Each itm As Object In row.ItemArray
                    '    MsgBox("item = " & itm.ToString)
                    'Next
                    Dim newrow As DataRow
                    newrow = TempTable.NewRow

                    Dim count As Integer = 0
                    Dim h As String = ""

                    For Each Val As Object In row.ItemArray
                        Select Case count
                            'String original
                            Case 0, 1, 2, 3, 7, 8
                                newrow.Item(count) = Val

                                'Byte Array Original
                            Case 4, 6, 14
                                If GetVal(Val) IsNot Nothing Then
                                    Dim sb As New System.Text.StringBuilder

                                    For Each b As Byte In Val
                                        If b > -1 Then
                                            'h = Microsoft.VisualBasic.Conversion.Hex(b)

                                            sb.Append("~" & b.ToString)
                                            'sb.Append(Chr(b))
                                        End If
                                    Next
                                    newrow.Item(count) = sb.ToString
                                Else
                                    newrow.Item(count) = "null"
                                End If

                                'Short Original
                            Case 5, 9, 10, 11, 13
                                newrow.Item(count) = Val.ToString

                                'Integer Original
                            Case 12
                                newrow.Item(count) = Val.ToString

                        End Select

                        count += 1
                    Next
                    TempTable.Rows.Add(newrow)
                Next
                'DataGridView1.DataSource = dt

                DataGridView1.DataSource = TempTable
                'DataGridView1.Rows.Add(newrow)

                DataGridView1.Visible = True
                DataGridView1.Enabled = True
                DataGridView1.Show()
                DataGridView1.ClearSelection()
            End If

        Catch OE As Odbc.OdbcException
            LogError(OE, "frmMain btnCapture_Click")

        Catch ex As Exception
            LogError(ex, "frmMain btnCapture_Click")
        End Try

    End Sub

    '/// Capture DBCC 2000 Log
    Private Sub btnDBCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDBCC.Click
       
        Try
            Dim frmL As frmODBCLogin

            '/// Login
            frmL = New frmODBCLogin
            Ulogin = frmL.getLogin()
            If Ulogin IsNot Nothing Then
                objProj.ProjectDSNUID = Ulogin.UID
                objProj.ProjectDSNPWD = Ulogin.PWD
            End If


            Dim TempTable As New System.Data.DataTable("TempTable1")

            '//// Setup Datagridview results table 
            For i As Integer = 1 To 11

                Dim newItem2 As New DataColumn
                Select Case i
                    Case 1
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Current LSN"
                    Case 2
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Operation"
                    Case 3
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Context"
                    Case 4
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Transaction ID"
                    Case 5
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Tag Bits"
                    Case 6
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Log Record Length"
                    Case 7
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Previous LSN"
                    Case 8
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Flag Bits"
                    Case 9
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Data Offset"
                    Case 10
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Record Data"
                    Case 11
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Description"
                End Select
                TempTable.Columns.Add(newItem2)
            Next

            Dim cnn As New System.Data.Odbc.OdbcConnection(objProj.ConnectionString)
            Dim cmd As New System.Data.Odbc.OdbcCommand
            Dim dr As System.Data.Odbc.OdbcDataReader

            TempTable.Clear()

            cnn.Open()

            Dim sql As String = "dbcc log(SQDmeta,4)"

            cmd = cnn.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sql
            Log(sql)
            dr = cmd.ExecuteReader

            Dim Param(10) As Object

            While dr.Read
                Dim newrow As DataRow

                newrow = TempTable.NewRow()

                Dim count As Integer = 0
                Array.Clear(Param, 0, 10)

                Param.SetValue(GetVal(dr("Current LSN")), 0)
                Param.SetValue(GetVal(dr("Operation")), 1)
                Param.SetValue(GetVal(dr("Context")), 2)
                Param.SetValue(GetVal(dr("Transaction ID")), 3)
                Param.SetValue(GetVal(dr("Tag Bits")), 4)
                Param.SetValue(GetVal(dr("Log Record Length")), 5)
                Param.SetValue(GetVal(dr("Previous LSN")), 6)
                Param.SetValue(GetVal(dr("Flag Bits")), 7)
                Param.SetValue(GetVal(dr("Data Offset")), 8)
                Param.SetValue(GetVal(dr("Record Data")), 9)
                Param.SetValue(GetVal(dr("Description")), 10)

                For Each Val As Object In Param

                    Dim h As String = ""
                    If count = 4 Or count = 7 Then
                        If Val IsNot Nothing Then
                            Dim sb As New System.Text.StringBuilder
                            For Each b As Byte In Val
                                Dim d As Decimal = Convert.ToDecimal(b)
                                sb.Append(d.ToString)
                                'If b > 32 Then
                                '    sb.Append(Chr(b))
                                '    'End If
                                '    'If b < 33 Or b > 126 Then
                                '    '    'b < 47 Or (b > 57 And b < 64) Or (b > 90 And b < 97) Or b > 122
                                '    '    sb.Append(b)
                                'Else
                                '    sb.Append(Chr(b))
                                'End If
                            Next
                            Param(count) = sb.ToString
                        End If
                    ElseIf count = 9 Then
                        If Val IsNot Nothing Then
                            Dim sb As New System.Text.StringBuilder
                            'For Each b As Byte In Val
                            '    If b > 32 Then
                            '        sb.Append(Chr(b))
                            '    End If
                            '    'If b < 33 Or b > 126 Then
                            '    '    'b < 47 Or (b > 57 And b < 64) Or (b > 90 And b < 97) Or b > 122
                            '    '    sb.Append(b)
                            '    'Else
                            '    'sb.Append(Chr(b))
                            '    'End If
                            Dim count3 As Integer = 1

                            For Each b As Byte In Val

                                If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)

                                    If count3 = 65 Then
                                        sb.Append(" <65>>> ")
                                    End If
                                    If count3 = 74 Then
                                        sb.Append(" <74>>> ")
                                    End If
                                    If count3 = 80 Then
                                        sb.Append(" <80>>> ")
                                    End If
                                    If count3 = 88 Then
                                        sb.Append(" <88>>> ")
                                    End If
                                    If count3 = 90 Then
                                        sb.Append(" <90>>> ")
                                    End If
                                    If count3 = 100 Then
                                        sb.Append(" <100>>> ")
                                    End If
                                    If count3 = 131 Then
                                        sb.Append(" <131>>> ")
                                    End If
                                    If count3 = 157 Then
                                        sb.Append(" <157>>> ")
                                    End If

                                    'sb.Append("~" & b.ToString)
                                    'sb.Append(Chr(b)) '"~" & 
                                    'sb.Append("~" & h)
                                    'sb.Append("~" & b)

                                    If count3 > 63 And count3 < 126 Then '
                                        'If count3 < 126 Then
                                        '    sb.Append("~" & b.ToString)
                                        'Else
                                        sb.Append(Chr(b))
                                        'End If
                                    Else
                                        If count3 <= 63 Then
                                            'sb.Append("~" & h)
                                            sb.Append("~" & b.ToString)
                                        Else
                                            sb.Append("~" & b.ToString)
                                        End If
                                    End If

                                    If count3 = 62 Then
                                        sb.Append(" <<<62> ")
                                    End If

                                    'If count3 = 70 Then
                                    '    sb.Append(" <<<70> ")
                                    'End If

                                    'If count3 = 78 Then
                                    '    sb.Append(" <<<78> ")
                                    'End If

                                    'If count3 = 132 Then
                                    '    sb.Append(" <<<132> ")
                                    'End If

                                    'If count3 = 136 Then
                                    '    sb.Append(" <<<136> ")
                                    'End If

                                    'If count3 = 140 Then
                                    '    sb.Append(" <<<140> ")
                                    'End If

                                    ''If b > -1 Then
                                    'sb.Append(Chr(b))

                                    count3 += 1

                                Else
                                    'sb.Append(b)
                                    'End If
                                    'If b < 33 Or b > 126 Then
                                    'If b < 47 Or (b > 57 And b < 64) Or (b > 122 And b < 176) Then  'Or (b > 90 And b < 97)
                                    '    sb.Append(CInt(b.ToString)) 'sb.Append(b)
                                    'Else
                                    '    sb.Append(Chr(b))
                                    'End If

                                End If
                            Next
                            Param(count) = sb.ToString
                        End If
                    Else
                        Param(count) = Val
                    End If
                    count += 1
                Next

                newrow.ItemArray = Param
                TempTable.Rows.Add(newrow)

               
            End While

            DataGridView1.DataSource = TempTable
            'DataGridView1.Rows.Add(newrow)

            DataGridView1.Visible = True
            DataGridView1.Enabled = True
            DataGridView1.Show()
            DataGridView1.ClearSelection()

        Catch OE As Odbc.OdbcException
            LogError(OE)
        Catch ex As Exception
            LogError(ex, "frmMain btnCapture_Click")
        End Try
    End Sub

    '/// Capture 2008 Log
    Private Sub btnCapture2008_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture2008.Click

        Try
            Dim frmL As frmODBCLogin
            '/// Login
            frmL = New frmODBCLogin
            Ulogin = frmL.getLogin()
            If Ulogin IsNot Nothing Then
                objProj.ProjectDSNUID = Ulogin.UID
                objProj.ProjectDSNPWD = Ulogin.PWD
            End If

            Dim dt As New System.Data.DataTable("temp1")
            Dim TempTable As New System.Data.DataTable("TempTable1")

            '//// Setup Datagridview results table 
            For i As Integer = 1 To 17
                Dim newItem As New DataColumn
                Dim newItem2 As New DataColumn
                Select Case i
                    Case 1
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Current LSN"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Current LSN"
                    Case 2
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Operation"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Operation"
                    Case 3
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Transaction ID"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Transaction ID"
                    Case 4
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Log Record Fixed Length"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Log Record Fixed Length"
                    Case 5
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Log Record Length"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Log Record Length"
                    Case 6
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "AllocUnitID"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "AllocUnitID"
                    Case 7
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "AllocUnitName"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "AllocUnitName"
                    Case 8
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Num Elements"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Num Elements"
                    Case 9
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "Flag Bits"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Flag Bits"
                    Case 10
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Transaction Name"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Transaction Name"
                    Case 11
                        newItem.DataType = GetType(String)
                        newItem.ColumnName = "Description"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Description"
                    Case 12
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "RowLog Contents 0"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "RowLog Contents 0"
                    Case 13
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "RowLog Contents 1"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "RowLog Contents 1"
                    Case 14
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "RowLog Contents 2"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "RowLog Contents 2"
                    Case 15
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "RowLog Contents 3"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "RowLog Contents 3"
                    Case 16
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "RowLog Contents 4"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "RowLog Contents 4"
                    Case 17
                        newItem.DataType = GetType(Byte())
                        newItem.ColumnName = "Log Record"
                        newItem2.DataType = GetType(String)
                        newItem2.ColumnName = "Log Record"
                End Select
                dt.Columns.Add(newItem)
                TempTable.Columns.Add(newItem2)
            Next


            Dim da As System.Data.Odbc.OdbcDataAdapter

            Dim cnn As New System.Data.Odbc.OdbcConnection(objProj.ConnectionString)

            dt.Clear() '

            cnn.Open()

            Dim sql As String = "select [Current LSN],Operation, [Transaction ID],[Log Record Fixed Length],[Log Record Length],AllocUnitID,AllocUnitName,[Num Elements],[Flag Bits],[Transaction Name], Description, [RowLog Contents 0],[RowLog Contents 1],[RowLog Contents 2],[RowLog Contents 3],[RowLog Contents 4], [Log Record] from ::fn_dblog(null,null)"

            da = New System.Data.Odbc.OdbcDataAdapter(sql, cnn)
            Log(sql)

            If da.Fill(dt) > 0 Then
                For Each row As DataRow In dt.Rows
                    'For Each itm As Object In row.ItemArray
                    '    MsgBox("item = " & itm.ToString)
                    'Next
                    Dim newrow As DataRow
                    newrow = TempTable.NewRow
                    Dim count As Integer = 0
                    Dim FixLen As Integer
                    Dim h As String = ""

                    For Each Val As Object In row.ItemArray
                        If count < 11 Then

                            If count = 3 Then
                                Dim d As Decimal = Convert.ToDecimal(Val)
                                FixLen = CInt(d)
                                newrow.Item(count) = FixLen.ToString
                            ElseIf count = 8 Then
                                If GetVal(Val) IsNot Nothing Then
                                    Dim sb As New System.Text.StringBuilder

                                    For Each b As Byte In Val
                                        If b > -1 Then
                                            h = Microsoft.VisualBasic.Conversion.Hex(b)

                                            sb.Append("~" & b.ToString)
                                            'sb.Append(Chr(b))
                                        End If
                                    Next
                                    newrow.Item(count) = sb.ToString
                                End If
                            Else
                                newrow.Item(count) = Val
                            End If

                        ElseIf count = 11 Then
                            '****** Row Log Contents 0
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count8 As Integer = 1

                                For Each b As Byte In Val
                                    'If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)
                                    'sb.Append(h)
                                    'sb.Append(Chr(b))
                                    'Else
                                    'sb.Append(b)
                                    'End If
                                    'If count4 > 63 And count4 < 262 Then '
                                    If count8 < 85 Then
                                        sb.Append("~" & b.ToString)
                                    Else
                                        sb.Append(Chr(b))
                                    End If
                                    'Else
                                    '    If count4 <= 63 Then
                                    '        sb.Append("~" & h)
                                    '    Else
                                    '        sb.Append("~" & b.ToString)
                                    '    End If
                                    'End If
                                    count8 += 1
                                Next
                                newrow.Item(count) = sb.ToString
                            End If

                        ElseIf count = 12 Then
                            '****** Row Log Contents 1
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count7 As Integer = 1

                                For Each b As Byte In Val
                                    'If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)
                                    'sb.Append(h)
                                    'sb.Append(Chr(b))
                                    'Else
                                    'sb.Append(b)
                                    'End If
                                    'If count4 > 63 And count4 < 262 Then '
                                    If count7 < 100 Then
                                        sb.Append("~" & b.ToString)
                                    Else
                                        sb.Append(Chr(b))
                                    End If
                                    'Else
                                    '    If count4 <= 63 Then
                                    '        sb.Append("~" & h)
                                    '    Else
                                    '        sb.Append("~" & b.ToString)
                                    '    End If
                                    'End If
                                    count7 += 1
                                Next
                                newrow.Item(count) = sb.ToString
                            End If

                        ElseIf count = 13 Then
                            '****** Row Log Contents 2
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count6 As Integer = 1

                                For Each b As Byte In Val
                                    'If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)
                                    'sb.Append(h)
                                    'sb.Append(Chr(b))
                                    'Else
                                    'sb.Append(b)
                                    'End If
                                    'If count4 > 63 And count4 < 262 Then '
                                    If count6 < 100 Then
                                        sb.Append("~" & b.ToString)
                                    Else
                                        sb.Append(Chr(b))
                                    End If
                                    'Else
                                    '    If count4 <= 63 Then
                                    '        sb.Append("~" & h)
                                    '    Else
                                    '        sb.Append("~" & b.ToString)
                                    '    End If
                                    'End If
                                    count6 += 1
                                Next
                                newrow.Item(count) = sb.ToString
                            End If

                        ElseIf count = 14 Then
                            '****** Row Log Contents 3
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count5 As Integer = 1

                                For Each b As Byte In Val
                                    'If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)
                                    'sb.Append(h)
                                    'sb.Append(Chr(b))
                                    'Else
                                    'sb.Append(b)
                                    'End If
                                    'If count4 > 63 And count4 < 262 Then '
                                    If count5 < 100 Then
                                        sb.Append("~" & b.ToString)
                                    Else
                                        sb.Append(Chr(b))
                                    End If
                                    'Else
                                    '    If count4 <= 63 Then
                                    '        sb.Append("~" & h)
                                    '    Else
                                    '        sb.Append("~" & b.ToString)
                                    '    End If
                                    'End If
                                    count5 += 1
                                Next
                                newrow.Item(count) = sb.ToString
                            End If

                        ElseIf count = 15 Then
                            '****** Row Log Contents 4
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count4 As Integer = 1

                                For Each b As Byte In Val
                                    'If b > -1 Then
                                    h = Microsoft.VisualBasic.Conversion.Hex(b)
                                    'sb.Append(h)
                                    'sb.Append(Chr(b))
                                    'Else
                                    'sb.Append(b)
                                    'End If
                                    'If count4 > 63 And count4 < 262 Then '
                                    If count4 < 100 Then
                                        sb.Append("~" & b.ToString)
                                    Else
                                        sb.Append(Chr(b))
                                    End If
                                    'Else
                                    '    If count4 <= 63 Then
                                    '        sb.Append("~" & h)
                                    '    Else
                                    '        sb.Append("~" & b.ToString)
                                    '    End If
                                    'End If
                                    count4 += 1
                                Next
                                newrow.Item(count) = sb.ToString
                            End If

                        Else
                            '***** Log Record ******
                            If GetVal(Val) IsNot Nothing Then
                                Dim sb As New System.Text.StringBuilder
                                Dim count3 As Integer = 1

                                For Each b As Byte In Val

                                    If b > -1 Then
                                        h = Microsoft.VisualBasic.Conversion.Hex(b)

                                        If count3 = 65 Then
                                            sb.Append(" <65>>> ")
                                        End If
                                        If count3 = 74 Then
                                            sb.Append(" <74>>> ")
                                        End If
                                        If count3 = 80 Then
                                            sb.Append(" <80>>> ")
                                        End If
                                        If count3 = 88 Then
                                            sb.Append(" <88>>> ")
                                        End If
                                        If count3 = 90 Then
                                            sb.Append(" <90>>> ")
                                        End If
                                        If count3 = 100 Then
                                            sb.Append(" <100>>> ")
                                        End If
                                        If count3 = 131 Then
                                            sb.Append(" <131>>> ")
                                        End If
                                        If count3 = 157 Then
                                            sb.Append(" <157>>> ")
                                        End If
                                        'sb.Append("~" & b.ToString)
                                        'sb.Append(Chr(b)) '"~" & 
                                        'sb.Append("~" & h)
                                        'sb.Append("~" & b)

                                        If count3 > 63 And count3 < 218 Then '
                                            If count3 < 200 Then
                                                sb.Append("~" & b.ToString)
                                            Else
                                                sb.Append(Chr(b))
                                            End If
                                        Else
                                            If count3 <= 63 Then
                                                sb.Append("~" & h)
                                            Else
                                                sb.Append("~" & b.ToString)
                                            End If
                                        End If

                                        If count3 = 62 Then
                                            sb.Append(" <<<62> ")
                                        End If

                                        'If count3 = 70 Then
                                        '    sb.Append(" <<<70> ")
                                        'End If

                                        'If count3 = 78 Then
                                        '    sb.Append(" <<<78> ")
                                        'End If

                                        'If count3 = 132 Then
                                        '    sb.Append(" <<<132> ")
                                        'End If

                                        'If count3 = 136 Then
                                        '    sb.Append(" <<<136> ")
                                        'End If

                                        'If count3 = 140 Then
                                        '    sb.Append(" <<<140> ")
                                        'End If

                                        ''If b > -1 Then
                                        'sb.Append(Chr(b))

                                        count3 += 1

                                    Else
                                        'sb.Append(b)
                                        'End If
                                        'If b < 33 Or b > 126 Then
                                        'If b < 47 Or (b > 57 And b < 64) Or (b > 122 And b < 176) Then  'Or (b > 90 And b < 97)
                                        '    sb.Append(CInt(b.ToString)) 'sb.Append(b)
                                        'Else
                                        '    sb.Append(Chr(b))
                                        'End If

                                    End If
                                Next
                                newrow.Item(count) = sb.ToString
                            End If
                        End If
                        count += 1
                    Next
                    TempTable.Rows.Add(newrow)
                Next
                'DataGridView1.DataSource = dt

                DataGridView1.DataSource = TempTable
                '    DataGridView1.Rows.Add(newrow)

                DataGridView1.Visible = True
                DataGridView1.Enabled = True
                DataGridView1.Show()
                DataGridView1.ClearSelection()
            End If

        Catch OE As Odbc.OdbcException
            LogError(OE, "frmMain btnCapture2008_Click", , , True)
        Catch ex As Exception
            LogError(ex, "frmMain btnCapture2008_Click", , , True)
        End Try

    End Sub

End Class
