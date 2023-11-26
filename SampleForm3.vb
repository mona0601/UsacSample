Imports System.Data.OleDb

Public Class SampleForm3

    'DB接続情報
    Const CON_PROVIDER As String = "SQLOLEDB"
    Const CON_SERVER_NAME As String = "MEGURO-MAC-WIND"
    Const CON_DATABASE As String = "Koshow"
    Const CON_USERID As String = "sa"
    Const CON_PASSWORD As String = "password"

    Private _connectionString As String = " Provider = " & CON_PROVIDER &
                                        ";Data Source = " & CON_SERVER_NAME &
                                        ";Initial Catalog = " & CON_DATABASE &
                                        ";User Id = " & CON_USERID &
                                        ";Password =" & CON_PASSWORD


#Region "OLE DB接続"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using conn As New OleDbConnection()

                conn.ConnectionString = _connectionString

                conn.Open()
                Console.WriteLine("データベースに接続しました。")

                Try
                    '必要な処理を実装

                Catch ex As Exception
                    Throw
                Finally
                    conn.Close()
                    Console.WriteLine("データベースから切断しました。")
                End Try
            End Using
        Catch ex As Exception
            Console.WriteLine("データベース接続エラー：" + Err.Description)
        End Try

    End Sub
#End Region

#Region "DB登録"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using conn As New OleDbConnection()

                conn.ConnectionString = _connectionString

                conn.Open()
                Console.WriteLine("データベースに接続しました。")

                Try
                    Using transaction As OleDbTransaction = conn.BeginTransaction()
                        Try
                            Dim sql As String = "insert into users (user_id,password,user_name,email) VALUES (?,?,?,?)"

                            Using cmd As New OleDbCommand(sql, conn, transaction)
                                cmd.Parameters.Add(New OleDbParameter("@userId", SqlDbType.VarChar)).Value = "test2"
                                cmd.Parameters.Add(New OleDbParameter("@password", SqlDbType.VarChar)).Value = "test2"
                                cmd.Parameters.Add(New OleDbParameter("@userName", SqlDbType.VarChar)).Value = "テスト２"
                                cmd.Parameters.Add(New OleDbParameter("@email", SqlDbType.VarChar)).Value = "test2@test.com"

                                cmd.ExecuteNonQuery()

                                transaction.Commit()
                            End Using
                        Catch ex As Exception
                            transaction.Rollback()
                            Console.WriteLine(ex.Message)
                        End Try
                    End Using

                Catch ex As Exception
                    Throw
                Finally
                    conn.Close()
                    Console.WriteLine("データベースから切断しました。")
                End Try
            End Using
        Catch ex As Exception
            Console.WriteLine("データベース接続エラー：" + Err.Description)
        End Try
    End Sub
#End Region

#Region "DBデータ読み込み"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Using conn As New OleDbConnection()

                conn.ConnectionString = _connectionString

                conn.Open()
                Console.WriteLine("データベースに接続しました。")

                Try
                    Dim sql As String = "select * from users"
                    Dim outputData As List(Of String) = New List(Of String)()

                    Using cmd As New OleDbCommand(sql, conn)
                        Dim reader As OleDbDataReader = cmd.ExecuteReader()

                        While reader.Read()
                            outputData.Add("id:" & reader("id") &
                                           ", user_id:" & reader("user_id") &
                                           ", password:" & reader("password") &
                                           ", user_name:" & reader("user_name") &
                                           ", email:" & reader("email"))

                        End While
                    End Using
                    Console.WriteLine(String.Join(Environment.NewLine, outputData.ToArray()))
                Catch ex As Exception
                    Throw
                Finally
                    conn.Close()
                    Console.WriteLine("データベースから切断しました。")
                End Try
            End Using
        Catch ex As Exception
            Console.WriteLine("データベース接続エラー：" + Err.Description)
        End Try
    End Sub
#End Region

#Region "DBデータセット１"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Using conn As New OleDbConnection()

                conn.ConnectionString = _connectionString

                conn.Open()
                Console.WriteLine("データベースに接続しました。")

                Try
                    Dim sql As String = "select * from users"
                    Dim outputData As List(Of String) = New List(Of String)()
                    Dim ds As DataSet = New DataSet()

                    Using adapter As New OleDbDataAdapter(sql, conn)
                        Dim rowCount As Integer = adapter.Fill(ds, "users")

                        For Each row As DataRow In ds.Tables("users").Rows()
                            outputData.Add("id:" & row("id") &
                                       ", user_id:" & row("user_id") &
                                       ", password:" & row("password") &
                                       ", user_name:" & row("user_name") &
                                       ", email:" & row("email"))

                        Next
                    End Using
                    Console.WriteLine(String.Join(Environment.NewLine, outputData.ToArray()))
                Catch ex As Exception
                    Throw
                Finally
                    conn.Close()
                    Console.WriteLine("データベースから切断しました。")
                End Try
            End Using
        Catch ex As Exception
            Console.WriteLine("データベース接続エラー：" + Err.Description)
        End Try
    End Sub
#End Region

#Region "DBデータセット２"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Using conn As New SqlClient.SqlConnection()

                conn.ConnectionString = "Data Source = " & CON_SERVER_NAME &
                                        ";Initial Catalog = " & CON_DATABASE &
                                        ";User Id = " & CON_USERID &
                                        ";Password =" & CON_PASSWORD

                conn.Open()
                Console.WriteLine("データベースに接続しました。")

                Try
                    Dim outputData As List(Of String) = New List(Of String)()
                    Dim ds As KoshowDataSet = New KoshowDataSet()

                    Using adapter As KoshowDataSetTableAdapters.usersTableAdapter =
                                        New KoshowDataSetTableAdapters.usersTableAdapter()
                        adapter.Connection = conn
                        Dim rowCount As Integer = adapter.Fill(ds.users)

                        For rowIdx As Integer = 0 To rowCount - 1
                            outputData.Add("id:" & ds.users(rowIdx).id &
                                       ", user_id:" & ds.users(rowIdx).user_id &
                                       ", password:" & ds.users(rowIdx).password &
                                       ", user_name:" & ds.users(rowIdx).user_name &
                                       ", email:" & ds.users(rowIdx).email)


                        Next
                    End Using
                    Console.WriteLine(String.Join(Environment.NewLine, outputData.ToArray()))
                Catch ex As Exception
                    Throw
                Finally
                    conn.Close()
                    Console.WriteLine("データベースから切断しました。")
                End Try
            End Using
        Catch ex As Exception
            Console.WriteLine("データベース接続エラー：" + Err.Description)
        End Try
    End Sub

#End Region


#Region "XMLドキュメントコメント"
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sample As SampleOne = New SampleOne()

        Dim sampleConst As Integer = SampleOne.ONE
        Dim sampleValue As Integer = sample.SampleValue

        Dim calcValue As Integer = sample.AddNumbers(1, 2)

    End Sub
#End Region
End Class