Module SessionModule

    Public CurrentIdUser As Integer = 0
    Public CurrentUsername As String = ""
    Public CurrentNama As String = ""
    Public CurrentEmail As String = ""
    Public CurrentGolDarah As String = ""
    Public CurrentTelepon As String = ""
    Public CurrentRole As String = ""

    Public Sub ResetSession()
        CurrentIdUser = 0
        CurrentUsername = ""
        CurrentNama = ""
        CurrentEmail = ""
        CurrentGolDarah = ""
        CurrentTelepon = ""
        CurrentRole = ""
    End Sub

End Module