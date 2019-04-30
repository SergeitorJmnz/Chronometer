



Public Class mainForm


#Region "Global Variables"

    Dim g_working As Boolean = False

    Dim g_hours As UInt16 = 2
    Dim g_mins As UInt16 = 0
    Dim g_secs As UInt16 = 0

#End Region


#Region "Form events"

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If Not g_working Then

            btnStart.Text = "Parar"
            g_working = True
            tmrRefreshForm.Start()

        Else

            btnStart.Text = "Comenzar"
            g_working = False
            tmrRefreshForm.Stop()

        End If

    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtHours.Text = "02"
        txtMin.Text = "00"
        txtSec.Text = "00"

        btnStart.Text = "Comenzar"

    End Sub

    Private Sub tmrRefreshForm_Tick(sender As Object, e As EventArgs) Handles tmrRefreshForm.Tick

        If g_secs = 0 Then
            g_secs = 59
        Else
            g_secs -= 1
        End If

        txtSec.Text = g_secs

    End Sub

#End Region


#Region "Aux Functions"

    Private Sub cuentaRegresiva()



    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        g_hours = 2
        g_mins = 0
        g_secs = 0

    End Sub


#End Region


End Class
