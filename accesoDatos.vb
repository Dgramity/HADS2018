Imports System.Data.SqlClient

Public Class accesodatosSQL
    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand

    Public Shared Function conectar() As String
        Try
            conexion.ConnectionString = "Server=tcp:hads-11.database.windows.net,1433;Initial Catalog=hads-11;Persist Security Info=False;User ID=hads_2018_dais;Password=asdFGH12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            conexion.Open()
        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
        Return conexion.ConnectionString
    End Function

    Public Shared Sub cerrarconexion()
        conexion.Close()
    End Sub

    Public Shared Function insertar(ByVal email As String, ByVal nombre As String, ByVal apellidos As String, ByVal numconfir As Integer, ByVal confirmado As Integer, ByVal tipo As String, ByVal pass As String) As Boolean

        Dim st = "insert into Usuarios  values ('" & email & " ', '" & nombre & " ', '" & apellidos & " ', '" & numconfir & " ', '" & confirmado & " ','" & tipo & " ','" & pass & " ')"
        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Shared Function actualizarDatos(ByVal act As String) As Boolean
        Dim st1 = act
        Dim R As Integer
        comando = New SqlCommand(st1, conexion)
        Try
            R = comando.ExecuteNonQuery()
            If R = 1 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Shared Function cambiarContraseña(ByVal pass As String, ByVal correo As String) As Integer
        Dim s As Integer
        Dim st = "Update  Usuarios Set pass='" & pass & "'Where email='" & correo & "'"
        Try
            comando = New SqlCommand(st, conexion)
            s = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try

        Return s

    End Function

    Public Shared Function estaConfirmado(ByVal correo As String) As SqlDataReader

        Dim st = "Select * From Usuarios Where email='" & correo & "' AND confirmado=1"
        comando = New SqlCommand(st, conexion)

        Return comando.ExecuteReader()

    End Function



    Public Shared Function setConfirmacion(ByVal email As String, ByVal num As Integer) As Integer
        Dim s As Integer
        Dim st = "UPDATE Usuarios SET confirmado=1 WHERE email='" & email & "' AND numconfir=" & num & " AND confirmado=0"
        Try
            comando = New SqlCommand(st, conexion)
            s = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try

        Return s

    End Function


    Public Shared Function HacerLogin(ByVal email As String, ByVal password As String) As Boolean
        Dim st = "select count(*) from Usuarios where email='" & email & "' AND pass='" & password & "'"

        comando = New SqlCommand(st, conexion)

        If comando.ExecuteScalar() = 1 Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Shared Function obtenerDatos(ByVal email As String) As SqlDataReader
        Dim st = "select * from Usuarios where email='" & email & "'"

        comando = New SqlCommand(st, conexion)
        Return comando.ExecuteReader()

    End Function

    Public Shared Function ObtenerAsignaturas(email As String) As SqlDataReader
        Dim st = "select codigoasig from EstudiantesGrupo inner join GruposClase on EstudiantesGrupo.Grupo = GruposClase.codigo where Email='" & email & "'"

        comando = New SqlCommand(st, conexion)
        Return comando.ExecuteReader()
    End Function

    Public Shared Function ObtenerTareas(email As String, asignatura As String) As SqlDataAdapter
        Dim da As SqlDataAdapter
        Dim st = "select * from TareasGenericas where codasig = '" & asignatura & "' and explotacion = 1 and codigo not in (select CodTarea from EstudiantesTareas where Email='" & email & "')"


        comando = New SqlCommand(st, conexion)
        da = New SqlDataAdapter(comando)
        Return da
    End Function

    Public Shared Function ObtenerInstanciadas(email As String) As SqlDataAdapter
        Dim da As SqlDataAdapter
        Dim st = "select * from EstudiantesTareas where Email='" & email & "'"
        comando = New SqlCommand(st, conexion)
        da = New SqlDataAdapter(comando)
        Return da
    End Function

End Class
