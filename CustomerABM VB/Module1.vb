Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Mail
Module Module1
    Function Leerarchivo(ByVal archivo As String) As String 'La función se encarga de leer el archivo que esta declarado en File
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt") 'La ruta de la base de datos es: " DESKTOP-CK9FJ93\SQLEXPRESS "
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        End If
    End Function

    Function YaExisteSQL(ByVal sql As String) As Boolean
        Dim ar As String
        Dim con As New SqlConnection("data source=" & CStr(Leerarchivo(ar)) & "; initial catalog=Northwind; integrated security=true")
        Dim da1 As New SqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "afidesc")
        If ds1.Tables("afidesc").Rows.Count < 1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function Vnum(ByVal NTexto As String) As Decimal
        'transforma un texto con algo, que puede ser un numero con coma o punto o perro, y devuelve un valor decimal siempre
        Return CDec(Val(NTexto.Trim.Replace(",", ".")))
    End Function

    Function SqlAccion(ByVal SqlDeAccion As String) As Boolean
        Dim ar As String
        Dim connection As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=Northwind; integrated security=true")
        Dim dataAdapter As New SqlDataAdapter
        'Para ver si hubo o no error en la ejecucion
        Dim salida As Boolean = True

        Try
            connection.Open()
            'Busca el contenido con IndexOf si tiene algunas de las acciones
            If SqlDeAccion.ToUpper.IndexOf("INSERT") Then
                dataAdapter.InsertCommand = New SqlCommand(SqlDeAccion, connection)
                dataAdapter.InsertCommand.ExecuteNonQuery()
            Else
                If SqlDeAccion.ToUpper.IndexOf("UPDATE") Then
                    dataAdapter.UpdateCommand = New SqlCommand(SqlDeAccion, connection)
                    dataAdapter.UpdateCommand.ExecuteNonQuery()
                Else
                    If SqlDeAccion.ToUpper.IndexOf("DELETE") Then
                        dataAdapter.DeleteCommand = New SqlCommand(SqlDeAccion, connection)
                        dataAdapter.DeleteCommand.ExecuteNonQuery()
                    Else
                        salida = False
                    End If
                End If
            End If
            'Capturamos el Error
        Catch ex As Exception
            'Mostaramos el Error y Devolvemos False en la salida es decir que todo salio mal
            MsgBox(ex.Message)
            salida = False
        End Try
        'Cerramos la Conexion y Devolvemos True en la salida es decir que todo salio bien
        connection.Close()
        Return salida
    End Function

    Function NumSQL(ByVal numero As String) As String
        Return CStr(Vnum(numero)).Trim.Replace(",", ".")
    End Function

    Function RellenaNum(ByVal numero As Integer, ByVal cantidad As Integer) As String
        Dim snum As String = CStr(numero).Trim
        Return "00000000000000000000".Substring(0, cantidad - snum.Length) & snum
    End Function

    Function FechaSQL(ByVal fecha As Date) As String
        'Devuelve fecha en el formato 'AAAAMMDD'
        Return "'" & RellenaNum(Year(fecha), 4) & RellenaNum(Month(fecha), 2) & RellenaNum(fecha.Day, 2) & "'"

    End Function
End Module
