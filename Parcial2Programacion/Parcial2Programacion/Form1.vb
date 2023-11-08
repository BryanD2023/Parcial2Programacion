Imports System.Data.SqlClient


Public Class Form1
    Dim conexion As New SqlConnection("Server=DESKTOP-7F67A6S; DataBase=BDParcial2BryanAlexisDuranDuran;Integrated Security=True")




    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Try
            Dim comando As New SqlCommand("Insert Into Cliente(Nombre,Apellido,Departamento,Municipio) 
                                      Values('" & tbNombre.Text.Trim & "','" & tbApellido.Text.Trim & "','" & Me.cbDepartamento.Text.Trim & "','" & Me.cbMunicipio.Text.Trim & "')", conexion)
            conexion.Open()
            comando.ExecuteNonQuery()
            MsgBox("Se ha Guardado Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
            MsgBox("Se Cerro la conexión")
            tbNombre.Text = ""
            tbApellido.Text = ""
            cbDepartamento.Text = ""
            cbMunicipio.Text = "Seleccione..."
        End Try

    End Sub
End Class
