Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Public Class Form7
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rpt As New CrystalReport1()

        Dim cmd As OleDbCommand
        Dim adp As OleDbDataAdapter
        Dim ds As New DataSet
        Try
            CrystalReportViewer1.Refresh()
            If cn.State <> ConnectionState.Open Then cn.Open()
            cmd = New OleDbCommand("select * from District", cn)
            adp = New OleDbDataAdapter(cmd)
            adp.Fill(ds, "District")
            rpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rpt As New CrystalReport2()

        Dim cmd As OleDbCommand
        Dim adp As OleDbDataAdapter
        Dim ds As New DataSet
        Try
            CrystalReportViewer1.Refresh()
            If cn.State <> ConnectionState.Open Then cn.Open()
            cmd = New OleDbCommand("select * from City", cn)
            adp = New OleDbDataAdapter(cmd)
            adp.Fill(ds, "City")
            rpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rpt As New CrystalReport3()

        Dim cmd As OleDbCommand
        Dim adp As OleDbDataAdapter
        Dim ds As New DataSet
        Try
            CrystalReportViewer1.Refresh()
            If cn.State <> ConnectionState.Open Then cn.Open()
            cmd = New OleDbCommand("select * from Wheather", cn)
            adp = New OleDbDataAdapter(cmd)
            adp.Fill(ds, "Wheather")
            rpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim rpt As New CrystalReport4()

        'Dim cmd As OleDbCommand
        'Dim adp As OleDbDataAdapter
        'Dim ds As New DataSet
        'Try
        '    CrystalReportViewer1.Refresh()
        '    If cn.State <> ConnectionState.Open Then cn.Open()
        '    cmd = New OleDbCommand("select * from Room", cn)
        '    adp = New OleDbDataAdapter(cmd)
        '    adp.Fill(ds, "Room")
        '    rpt.SetDataSource(ds)
        '    CrystalReportViewer1.ReportSource = rpt
        'Catch Excep As Exception
        '    MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Dim rpt As New CrystalReport5()

        'Dim cmd As OleDbCommand
        'Dim adp As OleDbDataAdapter
        'Dim ds As New DataSet
        'Try
        '    CrystalReportViewer1.Refresh()
        '    If cn.State <> ConnectionState.Open Then cn.Open()
        '    cmd = New OleDbCommand("select * from Room", cn)
        '    adp = New OleDbDataAdapter(cmd)
        '    adp.Fill(ds, "Room")
        '    rpt.SetDataSource(ds)
        '    CrystalReportViewer1.ReportSource = rpt
        'Catch Excep As Exception
        '    MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class