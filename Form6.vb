Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data
Imports System.Math
Imports System.Drawing
Imports System.IO
Public Class Form6
    Dim cmd As OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cn.State <> ConnectionState.Open Then cn.Open()
        cmd = New OleDbCommand("Insert into Emp values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Details Saved....", MsgBoxStyle.OkOnly, "")
        cn.Close()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cn.State <> ConnectionState.Open Then cn.Open()
    End Sub
End Class