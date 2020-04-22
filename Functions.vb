Imports System.Net
Imports System.Net.NetworkInformation

Module Functions

    Function CheckInternet() As Boolean

        Try
            Return My.Computer.Network.Ping("www.google.com")
            My.Application.Log.WriteEntry("Check connection : Connecté à Internet")
        Catch ex As PingException
            Return False
            My.Application.Log.WriteEntry("Check connection : échoué : non connecté à internet")
        End Try

    End Function



End Module
