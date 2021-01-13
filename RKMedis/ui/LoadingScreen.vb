Public Class LoadingScreen

    Dim totalCountData As Integer = DBOperation.getAllDataCount()
    ' become 2 digit decimal points
    Dim progressCount As Double = Math.Round(100 / totalCountData, 2)
    ' we post the reference of background worker here
    Dim homeFrame As New Home

   
    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        GUIHelper.setBackgroundWorkerRef(BackgroundWorker1)
        GUIHelper.setProgressIntervalCount(progressCount)
        GUIHelper.setManyData(totalCountData)

       

        BackgroundWorker1.RunWorkerAsync()

        If (totalCountData = 0) Then
            BackgroundWorker1.ReportProgress(100)

        End If



    End Sub

   

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        
        homeFrame.loadData()

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        LabelText.Text = "Loading..." & ProgressBar1.Value & "%"

      
      

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Me.Hide()
        homeFrame.setLoadingScreenRef(Me)
        homeFrame.Visible = True

        ' when it is done
        GUIHelper.setProgressWorkerStat(True)


    End Sub

   

End Class