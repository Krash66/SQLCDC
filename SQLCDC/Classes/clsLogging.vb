
Public Class clsLogging
    Private m_Log As New System.Text.StringBuilder
    Private Shared m_EventCount As Integer

    Public Shared Event OnEvent(ByVal Msg As String)

    Public Shared Sub LogEvent(ByVal Msg As String, Optional ByVal AddNewLine As Boolean = True)
        Dim oStreamWriter As IO.StreamWriter = Nothing

        Try
            If EnableLogging = True Then
                oStreamWriter = New System.IO.StreamWriter(GetAppTemp() & "\" & TraceFile, True)
                If AddNewLine = True Then
                    Msg = "[" & Now & "] " & Msg & vbCrLf
                    oStreamWriter.Write(Msg)
                Else
                    Msg = "[" & Now & "] " & Msg
                    oStreamWriter.Write(Msg)
                End If
            End If

        Catch ex As Exception
            MsgBox("LogEvent : " & ex.Message, MsgBoxStyle.Information, MsgTitle)
        Finally
            If Not oStreamWriter Is Nothing Then oStreamWriter.Close()
        End Try

        RaiseEvent OnEvent(Msg)
    End Sub

    Public Shared Sub ErrorEvent(ByVal Msg As String, Optional ByVal AddNewLine As Boolean = True)
        Dim oStreamWriter As IO.StreamWriter = Nothing

        Try
            If EnableLogging = True Then
                oStreamWriter = New System.IO.StreamWriter(GetAppTemp() & "\" & errorTrace, True)
                If AddNewLine = True Then
                    Msg = "[" & Now & "] " & Msg & vbCrLf
                    oStreamWriter.Write(Msg)
                Else
                    Msg = "[" & Now & "] " & Msg
                    oStreamWriter.Write(Msg)
                End If
            End If

        Catch ex As Exception
            MsgBox("LogEvent : " & ex.Message, MsgBoxStyle.Information, MsgTitle)
        Finally
            If Not oStreamWriter Is Nothing Then oStreamWriter.Close()
        End Try

        RaiseEvent OnEvent(Msg)
    End Sub

    Public Shared Sub LogError(ByVal ex As Exception, Optional ByVal p1 As String = "", Optional ByVal p2 As String = "", Optional ByVal ThrowError As Boolean = False, Optional ByVal displayMSG As Boolean = False)

        errorLog("****************************")
        If p1 <> "" Then
            Debug.Write(p1)
            ErrorLog(p1)
        End If

        If p2 <> "" Then
            Debug.Write(p2)
            ErrorLog(p2)
        End If

        ErrorLog(ex.Source & " > " & ex.StackTrace & " > " & ex.Message)
        ErrorLog("****************************")

        Dim strMsg As String

        '//New: 8/15/05
        If ex.Message.IndexOf("ERROR [IM002]") >= 0 Then
            strMsg = "Datasource not found."
        ElseIf ex.Message.IndexOf("ERROR [23000]") >= 0 Then
            strMsg = "Object already exists, please specify a new object name."
        Else
            strMsg = ex.Message
        End If

        Err.Clear()

        If ThrowError = True Then
            Throw (New Exception(strMsg))
        ElseIf displayMSG = True Then
            MsgBox(strMsg, MsgBoxStyle.Critical, MsgTitle)
        End If

    End Sub

    Public Sub ClearLog()
        m_Log.Remove(0, m_Log.Length)
        m_EventCount = 0
        RaiseEvent OnEvent("[" & Now & "] Log cleared")
    End Sub

    Public Shared ReadOnly Property EventCount() As Integer
        Get
            Return m_EventCount
        End Get
    End Property

    Public Property Text() As String
        Get
            Return m_Log.ToString
        End Get
        Set(ByVal value As String)

        End Set
    End Property

End Class
