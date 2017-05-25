Public Class ClsCDCproj

    Private m_ProjectDSN As String = ""
    Private m_ProjectDSNUID As String
    Private m_ProjectDSNPWD As String

    Public Property ProjectDSNUID() As String
        Get
            Return m_ProjectDSNUID
        End Get
        Set(ByVal Value As String)
            m_ProjectDSNUID = Value
        End Set
    End Property

    Public Property ProjectDSNPWD() As String
        Get
            Return m_ProjectDSNPWD
        End Get
        Set(ByVal Value As String)
            m_ProjectDSNPWD = Value
        End Set
    End Property

    Public Property ProjectDSN() As String
        Get
            Return m_ProjectDSN
        End Get
        Set(ByVal Value As String)
            m_ProjectDSN = Value
        End Set
    End Property

    Public ReadOnly Property ConnectionString() As String
        Get
            Return "DSN=" & ProjectDSN & "; UID=" & ProjectDSNUID & "; PWD=" & ProjectDSNPWD
        End Get
    End Property
End Class
