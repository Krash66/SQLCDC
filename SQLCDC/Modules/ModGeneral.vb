Module ModGeneral
    Public EnableLogging As Boolean = True
    Public TraceFile As String
    Public errorTrace As String
    Public objLog As clsLogging

    Public Const MsgTitle As String = "SQLCDC"

    Public Enum enumODBCtype
        ACCESS = 1
        SQL_SERVER = 2
        ORACLE = 3
        DB2 = 4
        OTHER = 20
    End Enum

#Region "Log Functions"

    Public Function Log(ByVal sMsg As String, Optional ByVal AddNewLine As Boolean = True) As Boolean
        clsLogging.LogEvent(sMsg, AddNewLine)
    End Function

    Public Function ErrorLog(ByVal sMsg As String, Optional ByVal AddNewLine As Boolean = True) As Boolean
        clsLogging.ErrorEvent(sMsg, AddNewLine)
    End Function

    Public Function LogError(ByVal ex As Exception, Optional ByVal p1 As String = "", Optional ByVal p2 As String = "", Optional ByVal ThrowError As Boolean = False, Optional ByVal displayMSG As Boolean = False) As Boolean
        clsLogging.LogError(ex, p1, p2, ThrowError, displayMSG)
    End Function

    Public Function LoadGlobalValues(Optional ByVal ClearLogOnStartUp As Boolean = True) As Boolean

        objLog = New clsLogging
        ModGeneral.objLog = objLog

        Try
            If TraceFile Is Nothing Then
                TraceFile = "Trace.log"
            End If
            If errorTrace Is Nothing Then
                errorTrace = "ErrorTrc.log"
            End If
            If ClearLogOnStartUp = True Then
                System.IO.File.Delete(GetAppTemp() & "\" & TraceFile)  '
                System.IO.File.Delete(GetAppTemp() & "\" & errorTrace)   '& "\"
                'System.IO.File.Delete(GetAppPath() & "*.log")
            End If
            EnableLogging = True

            Log("Trace Enabled")
            Return True

        Catch ex As Exception
            LogError(ex, "modGeneral LoadGlobalValues")
            Return False
        End Try

    End Function

#End Region

#Region "Mylist Class"

    ''' <summary>
    ''' Simple list of objects and their names
    ''' </summary>
    ''' <remarks>Useful for small collections, dropdown lists, etc...</remarks>
    Public Class Mylist

        Private sName As String
        ' You can also declare this as String,bitmap or almost anything. 
        ' If you change this delcaration you will also need to change the Sub New 
        ' to reflect any change. Also the ItemData Property will need to be updated. 
        Private iID As Object

        ''' <summary>
        ''' Default empty constructor. 
        ''' </summary>
        ''' <remarks>Defines new list of objects</remarks>
        Public Sub New()
            sName = ""
            ' This would need to be changed if you modified the declaration above. 
            iID = 0
        End Sub

        ''' <summary>
        ''' Contructor with item definition
        ''' </summary>
        ''' <param name="Name">Text Name</param>
        ''' <param name="ID">Object</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal Name As String, ByVal ID As Object)
            sName = Name
            iID = ID
        End Sub

        Public Property Name() As String
            Get
                Return sName
            End Get
            Set(ByVal sValue As String)
                sName = sValue
            End Set
        End Property

        ' This is the property that holds the extra data. 
        Public Property ItemData() As Object
            Get
                Return iID
            End Get
            Set(ByVal iValue As Object)
                iID = iValue
            End Set
        End Property

        ' This is neccessary because the ListBox and ComboBox rely 
        ' on this method when determining the text to display. 
        Public Overrides Function ToString() As String
            Return sName
        End Function

    End Class

#End Region

    '//Creates a Tempfolder in the same location of Application exe file
    Function GetAppTemp(Optional ByVal TempFolderName As String = "Temp") As String

        Dim AppData As String = System.Windows.Forms.Application.LocalUserAppDataPath()
        Dim AppTemp As String = ""

        If Right(AppData, 1) <> "\" Then
            AppData = AppData & "\"
        End If

        AppTemp = AppData & TempFolderName

        'If Right(AppTemp, 1) <> "\" Then
        '    AppTemp = AppTemp & "\"
        'End If

        If System.IO.Directory.Exists(AppTemp) = False Then
            System.IO.Directory.CreateDirectory(AppTemp)
        End If

        GetAppTemp = AppTemp

    End Function

    Function GetVal(ByVal obj As Object) As Object
        If (obj Is System.DBNull.Value) Then
            GetVal = Nothing
        Else
            GetVal = obj
        End If
    End Function

    Function GetString(ByVal obj As Object, ByVal idx As Integer) As String

        If idx < 10 Then
            GetString = obj.ToString
        Else
            If obj IsNot Nothing Then
                Dim sb As New System.Text.StringBuilder
                For Each b As Byte In obj
                    'If b > 32 Then
                    sb.Append(Chr(b))
                    'End If
                    'If b < 33 Or b > 126 Then
                    '    'b < 47 Or (b > 57 And b < 64) Or (b > 90 And b < 97) Or b > 122
                    '    sb.Append(b)
                    'Else
                    'sb.Append(Chr(b))
                    'End If
                Next
                GetString = sb.ToString
            Else
                GetString = ""
            End If
        End If

    End Function

    Function Quote(ByVal s As String, Optional ByVal ch As String = "'") As String

        'If s.Trim.StartsWith("'") And s.Trim.EndsWith("'") Then
        '    Quote = s.Trim
        'ElseIf s.StartsWith("'") And s.EndsWith("'") = False Then
        '    Quote = s & ch
        'ElseIf s.StartsWith("'") = False And s.EndsWith("'") = True Then
        '    Quote = ch & s
        'Else
        Quote = ch & s & ch
        'End If

    End Function

End Module
