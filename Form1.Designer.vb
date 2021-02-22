<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.txtfilename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.InFilesView = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstfiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbBack = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblftp = New System.Windows.Forms.ToolStripLabel()
        Me.weburl = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbGo = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CbChange = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.txtdownloadfile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtserveraddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtserverusername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtserverpassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_upload
        '
        Me.btn_upload.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upload.Location = New System.Drawing.Point(516, 54)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(82, 25)
        Me.btn_upload.TabIndex = 0
        Me.btn_upload.Text = "アップロード"
        Me.btn_upload.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_browse)
        Me.GroupBox1.Controls.Add(Me.txtfilename)
        Me.GroupBox1.Controls.Add(Me.btn_upload)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 449)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 85)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "　"
        '
        'btn_browse
        '
        Me.btn_browse.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Location = New System.Drawing.Point(393, 54)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(117, 25)
        Me.btn_browse.TabIndex = 2
        Me.btn_browse.Text = "ファルダー検索"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'txtfilename
        '
        Me.txtfilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfilename.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfilename.Location = New System.Drawing.Point(15, 56)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.ReadOnly = True
        Me.txtfilename.Size = New System.Drawing.Size(372, 27)
        Me.txtfilename.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "アップロードするファイルを検索"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.InFilesView)
        Me.GroupBox2.Controls.Add(Me.lstfiles)
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(-7, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1282, 246)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'InFilesView
        '
        Me.InFilesView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.InFilesView.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InFilesView.FullRowSelect = True
        Me.InFilesView.GridLines = True
        Me.InFilesView.Location = New System.Drawing.Point(6, 49)
        Me.InFilesView.Name = "InFilesView"
        Me.InFilesView.Size = New System.Drawing.Size(775, 231)
        Me.InFilesView.TabIndex = 8
        Me.InFilesView.UseCompatibleStateImageBehavior = False
        Me.InFilesView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FILES"
        Me.ColumnHeader2.Width = 350
        '
        'lstfiles
        '
        Me.lstfiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstfiles.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstfiles.FullRowSelect = True
        Me.lstfiles.GridLines = True
        Me.lstfiles.Location = New System.Drawing.Point(778, 49)
        Me.lstfiles.Name = "lstfiles"
        Me.lstfiles.ShowItemToolTips = True
        Me.lstfiles.Size = New System.Drawing.Size(469, 231)
        Me.lstfiles.TabIndex = 7
        Me.lstfiles.UseCompatibleStateImageBehavior = False
        Me.lstfiles.View = System.Windows.Forms.View.List
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "FILES"
        Me.ColumnHeader1.Width = 350
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.BackgroundImage = CType(resources.GetObject("ToolStrip2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBack, Me.tsbRefresh, Me.ToolStripSeparator4, Me.ToolStripLabel1, Me.lblftp, Me.weburl, Me.tsbGo})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 22)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(1276, 30)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbBack
        '
        Me.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBack.Name = "tsbBack"
        Me.tsbBack.Size = New System.Drawing.Size(85, 27)
        Me.tsbBack.Text = "ファイル削除"
        '
        'tsbRefresh
        '
        Me.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(84, 27)
        Me.tsbRefresh.Text = "再読み込み"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(73, 27)
        Me.ToolStripLabel1.Text = "現在位置:"
        '
        'lblftp
        '
        Me.lblftp.Name = "lblftp"
        Me.lblftp.Size = New System.Drawing.Size(43, 27)
        Me.lblftp.Text = "ftp://"
        '
        'weburl
        '
        Me.weburl.Name = "weburl"
        Me.weburl.Size = New System.Drawing.Size(400, 30)
        '
        'tsbGo
        '
        Me.tsbGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGo.Name = "tsbGo"
        Me.tsbGo.Size = New System.Drawing.Size(43, 27)
        Me.tsbGo.Text = "&移動"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CbChange)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.btn_download)
        Me.GroupBox5.Controls.Add(Me.txtdownloadfile)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(623, 449)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(604, 85)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'CbChange
        '
        Me.CbChange.AutoSize = True
        Me.CbChange.Location = New System.Drawing.Point(102, 10)
        Me.CbChange.Name = "CbChange"
        Me.CbChange.Size = New System.Drawing.Size(158, 24)
        Me.CbChange.TabIndex = 9
        Me.CbChange.Text = "変換する(Shift-JIS)"
        Me.CbChange.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(266, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(318, 44)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "現在フォルダーの全てのファイルダウンロード"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_download
        '
        Me.btn_download.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_download.Location = New System.Drawing.Point(483, 49)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(101, 25)
        Me.btn_download.TabIndex = 2
        Me.btn_download.Text = "ダウンロード"
        Me.btn_download.UseVisualStyleBackColor = True
        '
        'txtdownloadfile
        '
        Me.txtdownloadfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdownloadfile.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdownloadfile.Location = New System.Drawing.Point(27, 49)
        Me.txtdownloadfile.Name = "txtdownloadfile"
        Me.txtdownloadfile.Size = New System.Drawing.Size(450, 27)
        Me.txtdownloadfile.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "選択したファイル名"
        '
        'txtserveraddress
        '
        Me.txtserveraddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtserveraddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserveraddress.Location = New System.Drawing.Point(199, 36)
        Me.txtserveraddress.Name = "txtserveraddress"
        Me.txtserveraddress.Size = New System.Drawing.Size(228, 27)
        Me.txtserveraddress.TabIndex = 7
        Me.txtserveraddress.Text = "write your FTP server Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "FTP Server Host 名:"
        '
        'txtserverusername
        '
        Me.txtserverusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtserverusername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserverusername.Location = New System.Drawing.Point(199, 77)
        Me.txtserverusername.Name = "txtserverusername"
        Me.txtserverusername.Size = New System.Drawing.Size(228, 27)
        Me.txtserverusername.TabIndex = 9
        Me.txtserverusername.Text = "write your FTP server ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FTP Server ユーザー名:"
        '
        'txtserverpassword
        '
        Me.txtserverpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtserverpassword.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtserverpassword.Location = New System.Drawing.Point(199, 115)
        Me.txtserverpassword.Name = "txtserverpassword"
        Me.txtserverpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtserverpassword.Size = New System.Drawing.Size(228, 25)
        Me.txtserverpassword.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "FTP Server パースワード:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightYellow
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(-7, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1251, 190)
        Me.Label7.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Bisque
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(636, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "FTPサーバー管理ツール"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LavenderBlush
        Me.Button2.Location = New System.Drawing.Point(1015, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 39)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "プログラム終了"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn_Login.Location = New System.Drawing.Point(449, 77)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(99, 38)
        Me.btn_Login.TabIndex = 17
        Me.btn_Login.Text = "ログイン"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1239, 546)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtserverpassword)
        Me.Controls.Add(Me.txtserverusername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtserveraddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FTP 管理ツール"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_upload As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblftp As System.Windows.Forms.ToolStripLabel
    Friend WithEvents weburl As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_download As System.Windows.Forms.Button
    Friend WithEvents txtdownloadfile As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtserveraddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtserverusername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtserverpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lstfiles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents InFilesView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tsbBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_Login As System.Windows.Forms.Button
    Friend WithEvents CbChange As System.Windows.Forms.CheckBox

End Class
