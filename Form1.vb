Imports System.Net
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security


Public Class Form1
    Dim get_filename As String
    Dim get_filesafename As String
    Public get_foldername As String
    Dim ftpwebrequest As FtpWebRequest
    Dim writeUrlFlg As Boolean
    Dim loginFlg As Boolean
    Dim checkChgFlg As Boolean

    'FtpWebRequestのObjectに、接続先(1回分)の設定とSSLキーの証明書を入れてリターン
    Private Function ftpOj()

        Dim store As X509Store = New X509Store("teststore", StoreLocation.CurrentUser)
        store.Open(OpenFlags.ReadWrite)
        Dim certificate1 As X509Certificate2 = New X509Certificate2()

        Dim urlAddress As String = txtserveraddress.Text & ":21/" & get_foldername & txtdownloadfile.Text
        If writeUrlFlg = True Then urlAddress = weburl.Text

        Try
            ftpwebrequest = Nothing
            ftpwebrequest = DirectCast(WebRequest.Create("ftp://" & urlAddress), FtpWebRequest)
            Console.Write("現在のアドレス:   " & urlAddress)
            ftpwebrequest.Credentials = New NetworkCredential(txtserverusername.Text, txtserverpassword.Text)
            ftpwebrequest.ClientCertificates.Add(certificate1)

            ftpOj = ftpwebrequest
            ' certificate1 = Nothing
            ' ftpwebrequest = Nothing
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_upload.Click

        If loginFlg = False Then Exit Sub
        Try
            Me.Cursor = Cursors.WaitCursor
            If txtserveraddress.Text = txtdownloadfile.Text Then
                MessageBox.Show("Enter FTP Server address.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtserveraddress.Focus()
            ElseIf txtserverusername.Text = Nothing Then
                MessageBox.Show("Enter FTP Server username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtserverusername.Focus()
            ElseIf txtserverpassword.Text = Nothing Then
                MessageBox.Show("Enter FTP Server password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtserverpassword.Focus()
            Else
                txtdownloadfile.Text = get_filesafename
                get_foldername = get_foldername & "/"

                ftpwebrequest = ftpOj()

                With ftpwebrequest
                    'set the method to upload
                    .Method = WebRequestMethods.Ftp.UploadFile
                    .Timeout = "100000"
                    'data transfer type
                    .UseBinary = True
                    'size of the file to upload’
                    ' .ContentLength = get_filename.Length
                    .EnableSsl = False
                End With

                Dim ufile() As Byte = File.ReadAllBytes(get_filename.ToString)
                Dim ftpwebstreamrequest As Stream = ftpwebrequest.GetRequestStream()

                'start streaming upload
                ftpwebstreamrequest.Write(ufile, 0, ufile.Length)
                'close and dispose file and request stream after the upload
                ftpwebstreamrequest.Close()
                ftpwebstreamrequest.Dispose()
                'refresh web browser list
                tsbRefresh.PerformClick()

                txtdownloadfile.Text = ""
                get_filename = ""

                Me.Cursor = Cursors.Default

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_browse.Click

        If loginFlg = False Then Exit Sub
        Try
            ' Me.Cursor = Cursors.WaitCursor
            Dim openfile As OpenFileDialog = New OpenFileDialog
            With openfile
                .Title = "ファイル検索"
                .FileName = ""
                'Csvファイルをアップロード
                .Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*"
            End With

            'open file to upload
            If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtfilename.Text = openfile.FileName
                'get file name and path to upload
                get_filename = txtfilename.Text
                'get file safename
                get_filesafename = openfile.SafeFileName
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub txtserveraddress_TextChanged(sender As Object, e As EventArgs) Handles txtserveraddress.TextChanged
        weburl.Text = txtserveraddress.Text & ":21//" & get_foldername
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_download.Click

        If loginFlg = False Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim savefildlg As SaveFileDialog = New SaveFileDialog
            If txtserveraddress.Text = Nothing Then
                MessageBox.Show("Enter FTP Server address.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtserveraddress.Focus()
            ElseIf txtserverusername.Text = Nothing Then
                MessageBox.Show("Enter FTP Server username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtserverusername.Focus()
            ElseIf txtserverpassword.Text = Nothing Then
                MessageBox.Show("Enter FTP Server password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtserverpassword.Focus()
            Else

                ftpwebrequest = ftpOj()
                With ftpwebrequest
                    'set the method to download
                    .Method = WebRequestMethods.Ftp.DownloadFile
                    .Timeout = "100000"
                    .UseBinary = True
                    ' .ContentLength = ftpwebrequest.Ftp.GetFileSize
                    .UsePassive = True
                    .KeepAlive = False
                    .EnableSsl = True
                End With

                With savefildlg
                    .Title = " FTPサーバーからファイルダウンロード(CSVのみ)"
                    .FileName = get_filename
                    .Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*"
                End With

                Dim ftpwebres As FtpWebResponse = DirectCast(ftpwebrequest.GetResponse(), FtpWebResponse)
                Dim ftpstream As Stream = ftpwebres.GetResponseStream()
                Dim encodingTYpe As System.Text.Encoding

                '  Dim localFilePath As String = Path.Combine(localPath, Name)

                Try
                    'start streaming download
                    If savefildlg.ShowDialog = Windows.Forms.DialogResult.OK Then

                        If checkChgFlg = False Then
                            'defaultでencodingg(checkbox)
                            ' encoding_default(ftpwebres, savefildlg.FileName)
                            encodingTYpe = New System.Text.UTF8Encoding(False)
                            encodingChange(savefildlg.FileName, ftpstream, savefildlg.FileName, encodingTYpe)
                        Else
                            'Shift-jisでencoding(checkbox)
                            encodingTYpe = System.Text.Encoding.GetEncoding("Shift-JIS")
                            encodingChange(savefildlg.FileName, ftpstream, savefildlg.FileName, encodingTYpe)
                        End If

                    End If
                Catch ex As WebException
                    ' Me.Cursor = Cursors.Default
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    ftpwebres.Close()
                    ftpstream.Close()
                    txtdownloadfile.Text = ""
                    ftpwebrequest = Nothing
                    Me.Cursor = Cursors.Default
                End Try


            End If
        Catch ex As WebException
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            'Me.Cursor = Cursors.WaitCursor
            If txtserveraddress.Text = Nothing Then
                MessageBox.Show("Enter FTP Server address.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtserveraddress.Focus()
            ElseIf txtserverusername.Text = Nothing Then
                MessageBox.Show("Enter FTP Server username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtserverusername.Focus()
            ElseIf txtserverpassword.Text = Nothing Then
                MessageBox.Show("Enter FTP Server password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtserverpassword.Focus()
            Else

                ftpwebrequest = ftpOj()

                With ftpwebrequest
                    ' .Credentials = New NetworkCredential(txtserverusername.Text, txtserverpassword.Text)
                    'set the method to upload
                    .Method = WebRequestMethods.Ftp.ListDirectory
                    .Timeout = "20000"
                    .EnableSsl = True
                End With

                Dim ftpwebres As FtpWebResponse = CType(ftpwebrequest.GetResponse(), FtpWebResponse)
                Dim ftpstreamreader As StreamReader = New StreamReader(ftpwebres.GetResponseStream())

                lstfiles.Items.Clear()

                While (ftpstreamreader.Peek() > -1)
                    lstfiles.Items.Add(ftpstreamreader.ReadLine())
                End While

                ftpwebres.Close()
                ftpstreamreader.Close()

            End If

            SearchInFolder()
            Me.Cursor = Cursors.Default
        Catch ex As WebException
            ' Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub lstfiles_DoubleClick(sender As Object, e As EventArgs) Handles lstfiles.DoubleClick
        If get_foldername = "" Then Exit Sub
        SearchInFolder()
    End Sub

    Private Sub lstfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstfiles.SelectedIndexChanged
        get_foldername = lstfiles.FocusedItem.Text
        InFilesView.Items.Clear()
    End Sub

    Private Sub SearchInFolder()

        ftpwebrequest = ftpOj()

        With ftpwebrequest
            'set the method to upload
            .Method = WebRequestMethods.Ftp.ListDirectory
            .Timeout = "20000"
            .EnableSsl = True
        End With

        Dim ftpwebres As FtpWebResponse = CType(ftpwebrequest.GetResponse(), FtpWebResponse)
        Dim ftpstreamreader As StreamReader = New StreamReader(ftpwebres.GetResponseStream())
        'clear list of files

        InFilesView.Items.Clear()
        'start loading files from ftp server into list
        Try
            While (ftpstreamreader.Peek() > -1)
                InFilesView.Items.Add(ftpstreamreader.ReadLine())
            End While
            Me.Cursor = Cursors.Default

            If writeUrlFlg <> True Then weburl.Text = txtserveraddress.Text & ":21//" & get_foldername

        Catch ex As WebException
            ' Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Finally
            ftpwebres.Close()
            ftpstreamreader.Close()
        End Try
    End Sub

    Private Sub InFilesView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InFilesView.SelectedIndexChanged
        txtdownloadfile.Text = "/" & InFilesView.FocusedItem.Text
        get_filename = InFilesView.FocusedItem.Text
    End Sub

    'all files download
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim savefildlg As FolderBrowserDialog = New FolderBrowserDialog()
        Dim folderName As String


        txtdownloadfile.Text = ""
        Dim result As DialogResult = savefildlg.ShowDialog

        If loginFlg = False Then Exit Sub

        If result = DialogResult.OK Then
            folderName = savefildlg.SelectedPath
        Else
            savefildlg = Nothing
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        DownloadFtpDirectory("ftp://" & txtserveraddress.Text & ":21/" & get_foldername & "/", folderName)
    End Sub

    Private Sub DownloadFtpDirectory(url As String, localPath As String)

        Me.Cursor = Cursors.WaitCursor
        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
        ftpwebrequest = ftpOj()
        Dim lines As List(Of String) = New List(Of String)

            With ftpwebrequest
                .Method = WebRequestMethods.Ftp.ListDirectoryDetails
                .Timeout = "100000"
                .UseBinary = True
                .EnableSsl = True
            End With

        'filesのリストを読み込みしてListに入れます。
        Dim listResponse As FtpWebResponse = DirectCast(ftpwebrequest.GetResponse(), FtpWebResponse),
          listStream As Stream = listResponse.GetResponseStream(),
          listReader As StreamReader = New StreamReader(listStream, utf8WithoutBom)
            While Not listReader.EndOfStream
                lines.Add(listReader.ReadLine())
            End While

        Try
            For Each line As String In lines
                Dim tokens As String() =
                    line.Split(New Char() {" "}, 9, StringSplitOptions.RemoveEmptyEntries)
                Dim name As String = tokens(8)
                Dim permissions As String = tokens(0)

                Dim localFilePath As String = Path.Combine(localPath, name)
                Dim fileUrl As String = url + name
                Dim myappendingoption As Boolean = True
                Dim encodingTYpe As System.Text.Encoding
                '文字の頭字が'd'(directory)で始まる場合にはdirectoryが入ってる可能性があるので、
                '分岐して処理

                If permissions(0) = "d" Then
                    If Not Directory.Exists(localFilePath) Then
                        Directory.CreateDirectory(localFilePath)
                    End If
                    DownloadFtpDirectory(fileUrl + "/", localFilePath)
                Else
                    Dim downloadRequest As FtpWebRequest = WebRequest.Create(fileUrl)
                    downloadRequest.Method = WebRequestMethods.Ftp.DownloadFile
                    downloadRequest.Credentials = New NetworkCredential(txtserverusername.Text, txtserverpassword.Text)

                    Using downloadResponse As FtpWebResponse = downloadRequest.GetResponse()

                        If checkChgFlg = False Then
                            'defaultでencodingg(checkbox)
                            encodingTYpe = utf8WithoutBom
                            ' encoding_default(downloadResponse, localFilePath, encodingTYpe)
                            encodingChange(localPath & "\" & name, downloadResponse.GetResponseStream(), localFilePath, encodingTYpe)
                        Else
                            'Shift-jisでencoding(checkbox)
                            encodingTYpe = System.Text.Encoding.GetEncoding("Shift-JIS")
                            encodingChange(localPath & "\" & name, downloadResponse.GetResponseStream(), localFilePath, encodingTYpe)
                        End If

                    End Using
                End If
            Next

        Catch ex As WebException
            ' Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Finally
            listResponse.Close()
            listStream.Close()
            listReader.Close()
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub encoding_default(downloadResponse As FtpWebResponse, localFilePath As String)

        Dim sourceStream As Stream = downloadResponse.GetResponseStream(),
         targetStream As Stream = File.Create(localFilePath)

        Dim buffer As Byte() = New Byte(10240 - 1) {}
        Dim read As Integer
        Do
            read = sourceStream.Read(buffer, 0, buffer.Length)
            If read > 0 Then
                targetStream.Write(buffer, 0, read)
            End If
        Loop While read > 0

        targetStream.Close()
        sourceStream.Close()
        downloadResponse.Close()

    End Sub

    ' Shift-jisにencode
    Private Sub encodingChange(infile As String, reader As Stream, localFilePath As String, encodingTYpe As System.Text.Encoding)

        Dim sw As StreamWriter = New StreamWriter(File.Create(localFilePath), encodingTYpe)

        Dim reader2 As StreamReader
        Dim listA As New List(Of String)()
        Dim myfilepath As String = infile
        Dim myappendingoption As Boolean = True
        Dim s As String = String.Empty
        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
        reader2 = New StreamReader(reader, utf8WithoutBom)
        Try

            While reader2.Peek() >= 0
                Dim line As String = reader2.ReadLine()
                Dim values As String() = line.Split(";"c)
                listA.Add(values(0))
                s = s + line + Chr(10)
            End While

            sw.Write(s)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("エラー", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sw.Close()
            reader2.Close()
            reader.Close()
            MessageBox.Show("ダウンロード完了です。", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        If loginFlg = False Then Exit Sub
        txtdownloadfile.Text = ""
        SearchInFolder()
    End Sub

    Private Sub tsbBack_Click(sender As Object, e As EventArgs) Handles tsbBack.Click
        If loginFlg = False Then Exit Sub
        Try
            ftpwebrequest = ftpOj()
            ftpwebrequest.Method = WebRequestMethods.Ftp.DeleteFile

            Dim response As FtpWebResponse = ftpwebrequest.GetResponse
            Console.WriteLine("Delete status: {0}", response.StatusDescription)
            response.Close()
            txtdownloadfile.Text = ""
            MsgBox("成功的に削除されました。")
        Catch ex As WebException
            ' Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub tsbGo_Click(sender As Object, e As EventArgs) Handles tsbGo.Click
        writeUrlFlg = True
        SearchInFolder()
        writeUrlFlg = False
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        If loginFlg = True Then Exit Sub

        txtdownloadfile.Text = ""
        get_foldername = ""
        ftpwebrequest = ftpOj()

        '  If ftpwebrequest.ContentLength == Nothing Then Exit Sub
        Dim ftpwebres As FtpWebResponse
        Dim ftpstreamreader As StreamReader

        Try
            With ftpwebrequest
                .Method = WebRequestMethods.Ftp.ListDirectory
                .Timeout = "20000"
                .EnableSsl = True
            End With

            ' 自己署名証明書でも通信OK
            Dim cb As RemoteCertificateValidationCallback = _
                New RemoteCertificateValidationCallback(AddressOf OnRemoteCertificateValidationCallback)

            ' コールバックメソッドを登録（デバッグや試験の場合にのみ使用されるべき）
            ServicePointManager.ServerCertificateValidationCallback = cb


            ftpwebres = CType(ftpwebrequest.GetResponse(), FtpWebResponse)
            ftpstreamreader = New StreamReader(ftpwebres.GetResponseStream())

            loginFlg = True
            lstfiles.Items.Clear()

            While (ftpstreamreader.Peek() > -1)
                lstfiles.Items.Add(ftpstreamreader.ReadLine())
            End While

            ftpwebres.Close()
            ftpstreamreader.Close()

        Catch ex As WebException
            loginFlg = False
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Finally

        End Try
    End Sub

    Private Sub CbChange_CheckedChanged(sender As Object, e As EventArgs) Handles CbChange.CheckedChanged

        If checkChgFlg = False Then
            checkChgFlg = True
        Else
            checkChgFlg = False
        End If

    End Sub

    ' コールバックメソッド
    Private Function OnRemoteCertificateValidationCallback(ByVal sender As Object, _
                                                           ByVal certificate As X509Certificate, _
                                                           ByVal chain As X509Chain, _
                                                           ByVal sslPolicyErrors As SslPolicyErrors) _
                                                           As Boolean
        ' 自己署名証明書証明書でもOKとする
        ' デバッグで自己署名証明書を使用している場合などにのみ使うこと
        Return True
    End Function
End Class