Public Class ClsODBCinfo

    Private m_DSNname As String
    Private m_DSNdesc As String
    Private m_ODBCtype As EnumODBCtype

    Property DSNname() As String
        Get
            Return m_DSNname
        End Get
        Set(ByVal value As String)
            m_DSNname = value
        End Set
    End Property

    Property DSNdesc() As String
        Get
            Return m_DSNdesc
        End Get
        Set(ByVal value As String)
            m_DSNdesc = value
        End Set
    End Property

    Private Property ODBCtype() As EnumODBCtype
        Get
            Return m_ODBCtype
        End Get
        Set(ByVal value As EnumODBCtype)
            m_ODBCtype = value
        End Set
    End Property

End Class
