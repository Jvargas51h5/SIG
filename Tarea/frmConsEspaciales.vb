Public Class frmConsEspaciales

    Private Sub frmConsEspaciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCbox()
    End Sub

    Sub cargarCbox()
        cbLayer.Items.Clear()
        cbElement.Items.Clear()
        Dim frm As Form1 = Form1
        Dim c As Integer = 0
        While c < frm.cbCapas.Items.Count
            cbLayer.Items.Add(frm.cbCapas.Items(c))
            cbElement.Items.Add(frm.cbCapas.Items(c))
            c = c + 1
        End While
    End Sub

    Private Sub cbBusqu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBusqu.SelectedIndexChanged
        If cbBusqu.SelectedIndex = 1 Then
            gbDistancia.Enabled = True
        Else
            gbDistancia.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub cbElement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbElement.SelectedIndexChanged
    End Sub
End Class