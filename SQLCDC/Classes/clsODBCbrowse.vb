Imports System.Data.Odbc
Public Class CRODBCHelper
    Inherits Object

    Private Const SQL_BUFFER_SIZE As Short = 1024
    Private Const SQL_FETCH_FIRST As Short = 1
    Private Const SQL_SUCCESS As Short = 0
    Private Const SQL_SUCCESS_WITH_INFO As Short = 1
    Private Const SQL_NO_DATA As Short = 100

    Private Const SQL_HANDLE_ENV As Integer = 1
    Private Const SQL_HANDLE_DBC As Integer = 2
    Private Const SQL_HANDLE_STMT As Integer = 3
    Private Const SQL_HANDLE_DESC As Short = 4
    Private Const SQL_NULL_HANDLE As Short = 0

    Private m_ConnectString As String
    Private m_DSNDataTable As DataTable
    Private m_ODBCNativeError As Integer
    Private m_ODBCMessage As String

    Private Declare Function SQLFreeHandle Lib "odbc32.dll" (ByVal handleType As Short, _
    ByVal Handle As Integer) As Short

    Private Declare Function SQLDataSources Lib "ODBC32.DLL" (ByVal WindowHandle As Integer, _
    ByVal Direction As Short, _
    ByVal DSNBuffer As String, _
    ByVal DSNBufferLength As Short, _
    ByRef DSNLength As Short, _
    ByVal DESCBuffer As String, _
    ByVal DESCBufferLength As Short, _
    ByRef DESCLength As Short) As Short

    Declare Function SQLGetDiagRec Lib "odbc32.dll" (ByVal iHType As Short, _
    ByVal lHInput As Integer, _
    ByVal iRecNumber As Short, _
    ByVal szSQLState As String, _
    ByRef iNativeError As Integer, _
    ByVal strMessageText As String, _
    ByVal iBufferLength As Short, _
    ByRef iTextLength As Short) As Short

    Private Declare Function SQLAllocEnv Lib "ODBC32.DLL" (ByRef env As Integer) As Short


    Public Sub New()

        MyBase.New()
        InitializeTables()

    End Sub

    Private Sub InitializeTables()

        m_DSNDataTable = New DataTable("DSNList")
        m_DSNDataTable.Columns.Add(New System.Data.DataColumn("DSN_NAME"))
        m_DSNDataTable.Columns.Add(New System.Data.DataColumn("DSN_DESCRIPTION"))

    End Sub

#Region "Properties"

    Public ReadOnly Property DSNDataTable() As DataTable
        Get
            Return m_DSNDataTable
        End Get
    End Property

    Public ReadOnly Property ErrorCode() As Integer
        Get
            Return m_ODBCNativeError
        End Get
    End Property

    Public ReadOnly Property ErrorMessage() As String
        Get
            Return m_ODBCMessage
        End Get
    End Property

#End Region

#Region "Methods"

    Public Function BuildDSNDataTable() As Boolean

        Dim env As Integer
        Dim ODBCRC As Integer
        Dim ret As Short
        Dim DSNBuffer As String
        Dim DSNBufferLength As Short
        Dim ReturnedDSNLength As Short
        Dim DESCBuffer As String
        Dim DESCBufferLength As Short
        Dim ReturnedDESCLength As Short
        Dim DSNName As String
        Dim DSNDescription As String

        'Initialize the string buffer lengths
        DSNBufferLength = SQL_BUFFER_SIZE
        DESCBufferLength = SQL_BUFFER_SIZE

        ODBCRC = SQLAllocEnv(env)
        If ProcessODBCError(env, ODBCRC) = True Then
            SQLFreeHandle(SQL_HANDLE_ENV, env)
            env = Nothing
            Return False
        End If

        m_DSNDataTable.Clear()

        ret = SQL_SUCCESS

        'Get the DSN names & descriptions
        While (ret = SQL_SUCCESS) Or (ret = SQL_SUCCESS_WITH_INFO)
            DSNBuffer = Space(DSNBufferLength)
            DESCBuffer = Space(DESCBufferLength)
            ret = SQLDataSources(env, SQL_FETCH_FIRST, DSNBuffer, DSNBufferLength, ReturnedDSNLength, DESCBuffer, DESCBufferLength, ReturnedDESCLength)
            If ProcessODBCError(env, ret) = True Then
                SQLFreeHandle(SQL_HANDLE_ENV, env)
                env = Nothing
                Return False
            End If

            DSNName = DSNBuffer.Substring(0, ReturnedDSNLength)
            DSNDescription = DESCBuffer.Substring(0, ReturnedDESCLength)

            Dim nr As System.Data.DataRow = m_DSNDataTable.NewRow()

            nr("DSN_NAME") = DSNName
            nr("DSN_DESCRIPTION") = DSNDescription

            m_DSNDataTable.Rows.Add(nr)

        End While

        SQLFreeHandle(SQL_HANDLE_ENV, env)
        env = Nothing
        Return True

    End Function

    Private Function ProcessODBCError(ByVal env As Integer, ByVal retval As Short) As Boolean

        Dim ODBCRC As Short
        Dim State As String = ""
        Dim NativeError As Long, Length As Integer
        Dim strErrMsg As String

        strErrMsg = Space(128)
        ODBCRC = retval

        If (ODBCRC <> SQL_SUCCESS) And (ODBCRC <> SQL_SUCCESS_WITH_INFO) Then
            ODBCRC = SQLGetDiagRec(SQL_HANDLE_ENV, env, 1, State, NativeError, strErrMsg, strErrMsg.Length, Length)
            If ODBCRC = SQL_SUCCESS Then
                m_ODBCNativeError = NativeError
                m_ODBCMessage = strErrMsg
                env = Nothing
                Return True
            End If
        ElseIf (ODBCRC = SQL_SUCCESS_WITH_INFO) Then
            ODBCRC = SQLGetDiagRec(SQL_HANDLE_ENV, env, 1, State, NativeError, strErrMsg, strErrMsg.Length, Length)
            If ODBCRC = SQL_SUCCESS Then
                m_ODBCNativeError = NativeError
                m_ODBCMessage = strErrMsg
                Return False
            End If
        End If

        Return False

    End Function

#End Region

End Class
