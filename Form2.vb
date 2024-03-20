Public Class Form2
    Private Sub HOSTALDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOSTALDETAILSToolStripMenuItem.Click
        Dim f1 As New Form1
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub ROOMDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ROOMDETAILSToolStripMenuItem.Click
        Dim f1 As New Form3
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub STUDENTDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDENTDETAILSToolStripMenuItem.Click
        Dim f1 As New Form4
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub ALLOTMENTDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALLOTMENTDETAILSToolStripMenuItem.Click
        Dim f1 As New Form5
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub BILLDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BILLDETAILSToolStripMenuItem.Click
        Dim f1 As New Form6
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub HOSTELREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOSTELREPORTToolStripMenuItem.Click
        Dim f1 As New Form7
        'f1.MdiParent = Me
        f1.Show()
    End Sub

End Class