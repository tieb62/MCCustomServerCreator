Public Class JavaChecker

    Public Enum JavaStatus
        INSTALLED
        NOT_INSTALLED
        NOT_VERIFIED
        VERIFYING
        VERIFY_ERROR
    End Enum

    Public CurrentStatus As JavaStatus

    Public Sub New()
        CurrentStatus = JavaStatus.NOT_VERIFIED
    End Sub

    Public Sub SyncCheck()
        CurrentStatus = JavaStatus.VERIFYING
        Try
            Dim JavaChecker As Process = Process.Start("java", "-version")
            JavaChecker.WaitForExit(30000)
            If JavaChecker.ExitCode <> 0 Then ' <> ==> "Différent de"
            CurrentStatus = JavaStatus.NOT_INSTALLED
            Else
                CurrentStatus = JavaStatus.INSTALLED
            End If
        Catch ex As Exception
            CurrentStatus = JavaStatus.VERIFY_ERROR
        End Try
    End Sub

    Public Async Function AsyncCheck() As Task
        Await Task.Run(New Action(AddressOf SyncCheck))
    End Function


End Class
