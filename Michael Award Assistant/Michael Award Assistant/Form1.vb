Public Class Form1
    Dim r As New Random()
    Dim MahURL As String
    Private Sub AddRandomFuny()
        Select Case r.Next(1, 25)
            Case 1
                MahURL += "pet%20"
            Case 2
                MahURL += "russian%20"
            Case 3
                MahURL += "dolphin%20"
            Case 4
                MahURL += "generator%20"
            Case 5
                MahURL += "for%20"
            Case 6
                MahURL += "free%20"
            Case 7
                MahURL += "how%20to%20"
            Case 8
                MahURL += "half-life%20"
            Case 9
                MahURL += "source%20"
            Case 10
                MahURL += "sorse%20"
            Case 11
                MahURL += "working%20"
            Case 12
                MahURL += "sauce%20"
            Case 13
                MahURL += "login%20"
            Case 14
                MahURL += "yeahnet%20"
            Case 15
                MahURL += "self-host%20"
            Case 16
                MahURL += "docker%20"
            Case 17
                MahURL += "portainer%20"
            Case 18
                MahURL += "kubernetes%20"
            Case 19
                MahURL += "gold%20"
            Case 20
                MahURL += "Xbox%20"
            Case 21
                MahURL += "Fortnite%20"
            Case 22
                MahURL += "Battle%20pass%20"
            Case 23
                MahURL += "Eric%20abramov%20"
            Case 24
                MahURL += "1983%20"
        End Select
    End Sub

    Private Sub Form1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        MessageBox.Show("Make sure Microsoft Edge is your default browser for the processes to start correctly.", "Michaelsoft Awards Tip")
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Welcome, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(DomainUpDown1.Text) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            My.Computer.Audio.Play(My.Resources.NotNumeric, AudioPlayMode.Background)
            MessageBox.Show("I would like you to put the number of searches you want me to do in that little box on the top left.", "You fool!")
        Else
            Timer1.Interval = r.Next(25000, 60000)
            Label3.Text = "Search Interval: " & Timer1.Interval & " ms"
            Timer1.Start()
            If Not DomainUpDown1.Text = 0 Then
                DomainUpDown1.Text -= 1
                Timer1.Interval = r.Next(25000, 60000)
                Label3.Text = "Search Interval: " & Timer1.Interval & " ms"
                Process.Start("C:\Program Files\Workplace2Software\MichaelAwardAssistant\CloseTab.exe")
                Threading.Thread.Sleep(4500)
                MahURL = "msedge.exe https://bing.com/?q="
                Select Case r.Next(1, 6)
                    Case 1
                        AddRandomFuny()
                    Case 2
                        AddRandomFuny()
                        AddRandomFuny()
                    Case 3
                        AddRandomFuny()
                        AddRandomFuny()
                        AddRandomFuny()
                    Case 4
                        AddRandomFuny()
                        AddRandomFuny()
                        AddRandomFuny()
                        AddRandomFuny()
                    Case 5
                        AddRandomFuny()
                        AddRandomFuny()
                        AddRandomFuny()
                        AddRandomFuny()
                        AddRandomFuny()
                End Select
                ListBox1.Items.Add(MahURL)
                Application.DoEvents()
                Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", MahURL)
            Else
                Timer1.Stop()
                My.Computer.Audio.Play(My.Resources.EndOfSearches, AudioPlayMode.Background)
                MessageBox.Show("DONE!", "SOPPED")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Select Case r.Next(1, 4)
            Case 1
                My.Computer.Audio.Play(My.Resources.SOP1, AudioPlayMode.WaitToComplete)
            Case 2
                My.Computer.Audio.Play(My.Resources.SOP2, AudioPlayMode.WaitToComplete)
            Case 3
                My.Computer.Audio.Play(My.Resources.SOP3, AudioPlayMode.WaitToComplete)
        End Select
        My.Computer.Audio.Play(My.Resources.EndOfSearches, AudioPlayMode.Background)
        MessageBox.Show("DONE!", "SOPPED")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not DomainUpDown1.Text = 0 Then
            DomainUpDown1.Text -= 1
            Timer1.Interval = r.Next(25000, 60000)
            Label3.Text = "Search Interval: " & Timer1.Interval & " ms"
            Process.Start("C:\Program Files\Workplace2Software\MichaelAwardAssistant\CloseTab.exe")
            Threading.Thread.Sleep(4500)
            MahURL = "msedge.exe https://bing.com/?q="
            Select Case r.Next(1, 6)
                Case 1
                    AddRandomFuny()
                Case 2
                    AddRandomFuny()
                    AddRandomFuny()
                Case 3
                    AddRandomFuny()
                    AddRandomFuny()
                    AddRandomFuny()
                Case 4
                    AddRandomFuny()
                    AddRandomFuny()
                    AddRandomFuny()
                    AddRandomFuny()
                Case 5
                    AddRandomFuny()
                    AddRandomFuny()
                    AddRandomFuny()
                    AddRandomFuny()
                    AddRandomFuny()
            End Select
            ListBox1.Items.Add(MahURL)
            Application.DoEvents()
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", MahURL)
        Else
            Timer1.Stop()
            My.Computer.Audio.Play(My.Resources.EndOfSearches, AudioPlayMode.Background)
            Select Case r.Next(1, 4)
                Case 1
                    My.Computer.Audio.Play(My.Resources.SOP1, AudioPlayMode.WaitToComplete)
                Case 2
                    My.Computer.Audio.Play(My.Resources.SOP2, AudioPlayMode.WaitToComplete)
                Case 3
                    My.Computer.Audio.Play(My.Resources.SOP3, AudioPlayMode.WaitToComplete)
            End Select
            MessageBox.Show("DONE!", "SOPPED")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://rewards.microsoft.com/pointsbreakdown")
    End Sub

    Private Sub AboutLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AboutLink.LinkClicked
        AboutBox1.Show()
    End Sub
End Class
