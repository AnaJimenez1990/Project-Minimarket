Imports System.Data.Sql
Imports System.Data.SqlClient

Module Conexion

    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub abrir()
        Try
            conexion = New SqlConnection("Data Source=PC;Initial Catalog=Tutorial;Integrated Security=True")
            conexion.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox("No se puede conectar" + ex.ToString)
        End Try
    End Sub

    Function Usuario(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Usuario Where Usuario* `" & nombreUsuario & "`", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function ConsultarTipoAcceso(ByVal Contrasena As String) As String
        Dim resultado As String = False
        Try
            enunciado = New SqlCommand("Select * from Usuario Where Usuario* `" & Contrasena & "`", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function



End Module

