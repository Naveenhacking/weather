Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data
Imports System.Math
Imports System.Drawing
Imports System.IO
Public Class Form1
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\2020-Projects\Hostal\Hostel.mdb;")

        If cn.State <> ConnectionState.Open Then cn.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cn.State <> ConnectionState.Open Then cn.Open()
        cmd = New OleDbCommand("Insert into State values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Details Saved....", MsgBoxStyle.OkOnly, "")
        cn.Close()
    End Sub
End Class
