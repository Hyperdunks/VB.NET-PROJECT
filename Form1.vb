Imports System.Data.OleDb
Public Class Form1
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\DonNet\Database3.accdb"
    Private connection As OleDbConnection
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database3DataSet.Table1)

        connection = New OleDbConnection(connectionString)
        Try
            connection.Open()
            MessageBox.Show("Conection Successfull")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        On Error GoTo SaveError

        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(Database3DataSet.Table1)
        MessageBox.Show("Data Updated Successfully!")
SaveError:

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Table1BindingSource.RemoveCurrent()

    End Sub
End Class
