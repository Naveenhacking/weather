Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data
Imports System.Math
Imports System.Drawing
Imports System.IO
Public Class Form5
    Dim cmd As OleDbCommand
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cn.State <> ConnectionState.Open Then cn.Open()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New OleDbCommand("Insert into City values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Details Saved....", MsgBoxStyle.OkOnly, "")
        cn.Close()
    End Sub
End Class