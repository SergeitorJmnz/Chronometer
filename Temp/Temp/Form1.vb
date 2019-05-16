



Public Class mainForm


#Region "Global Variables"

    Dim g_working As Boolean = False

#End Region


#Region "Form events"

    ''' <summary>
    ''' Start/Pause button events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If Not g_working Then

            btnStart.Text = "Pause ⏸️"
            g_working = True
            tmrRefreshForm.Start()

        Else

            btnStart.Text = "Restart ⏯️"
            g_working = False
            tmrRefreshForm.Stop()

        End If

    End Sub

    ''' <summary>
    ''' Reset button events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtHours.Text = "00"
        txtMin.Text = "00"
        txtSec.Text = "00"

    End Sub

    ''' <summary>
    ''' Form initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtHours.Text = "00"
        txtMin.Text = "00"
        txtSec.Text = "00"

    End Sub

    ''' <summary>
    ''' Form timer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrRefreshForm_Tick(sender As Object, e As EventArgs) Handles tmrRefreshForm.Tick

        tmrRefreshForm.Interval = 10

        txtSec.Text += 1

        If txtSec.Text = "60" Then

            txtMin.Text += 1
            txtSec.Text = 0

        End If

        If txtMin.Text = "60" Then

            txtHours.Text += 1
            txtMin.Text = 0

        End If

    End Sub


#End Region


End Class
