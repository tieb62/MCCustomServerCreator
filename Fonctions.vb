Imports System.Net
Module Fonctions

    Function CheckInternet() As Boolean

        Try
            Return My.Computer.Network.Ping("www.google.com")
            My.Application.Log.WriteEntry("Check connection : Connecté à Internet")
        Catch
            Return False
            My.Application.Log.WriteEntry("Check connection : échoué : non connecté à internet")
        End Try

    End Function


    Function GetHostName() As String

        Dim hostname As String = System.Net.Dns.GetHostName()

        Return hostname

    End Function


End Module
