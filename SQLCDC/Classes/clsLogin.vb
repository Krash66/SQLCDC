Public Class clsLogin

    Dim m_UID As String
    Dim m_PWD As String
    Dim m_LoggedInChange As Boolean

    Property UID() As String
        Get
            Return m_UID
        End Get
        Set(ByVal value As String)
            m_UID = value
        End Set
    End Property

    Property PWD() As String
        Get
            Return m_PWD
        End Get
        Set(ByVal value As String)
            m_PWD = value
        End Set
    End Property

    Property LoggedInChange() As Boolean
        Get
            Return m_LoggedInChange
        End Get
        Set(ByVal value As Boolean)
            m_LoggedInChange = value
        End Set
    End Property

End Class
