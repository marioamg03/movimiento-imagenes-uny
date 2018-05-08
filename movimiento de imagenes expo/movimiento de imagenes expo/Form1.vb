Public Class Form1
    Dim cont As Byte = 0

    Dim Vidas As Byte = 3

    Dim Tiempo As Integer = 60

    Dim X As Double = 720
    Dim X2 As Double = 902
    Dim X3 As Double = 782
    Dim X4 As Double = 848
    Dim Y2 As Double = 116
    Dim Y3 As Double = 164

    Dim Y As Double = 208
    Dim Z As Double = 76
    Dim W As Double = 195


    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress


        Select Case e.KeyChar
            Case "w"
                Timer2.Enabled = False

                PictureBox1.Visible = True
                PictureBox2.Visible = False
                PictureBox4.Visible = False
                PictureBox4.Enabled = False
                PictureBox6.Visible = False


                For i As Byte = 1 To 100
                    PictureBox1.Top -= 1
                    If PictureBox1.Location.Y < 0 Then
                        PictureBox1.Location = New Point(Val(PictureBox1.Location.X), 0)
                    End If
                    System.Threading.Thread.Sleep(8)
                    My.Application.DoEvents()
                Next

                For i As Byte = 1 To 100
                    PictureBox1.Top += 1
                    If PictureBox1.Location.Y > 198 Then
                        PictureBox1.Location = New Point(Val(PictureBox1.Location.X), 198)
                    End If
                    System.Threading.Thread.Sleep(8)
                    My.Application.DoEvents()
                Next

                Timer2.Enabled = True


            Case "d"
                If Z < 660 Then
                    Z = Z + 5
                End If
                Timer2.Enabled = False
                PictureBox1.Visible = True
                PictureBox2.Visible = False

                PictureBox4.Enabled = False
                PictureBox4.Visible = False

                PictureBox6.Visible = False
                PictureBox1.Location = New Point(Z, W)
                PictureBox2.Location = New Point(Z, 195)

                PictureBox4.Location = New Point(Z, 174)
                PictureBox6.Location = New Point(Z, 195)
                System.Threading.Thread.Sleep(10)
                My.Application.DoEvents()

                Timer2.Enabled = True
            Case "a"
                If Z > 0 Then
                    Z = Z - 5
                End If
                Timer2.Enabled = False


                PictureBox1.Visible = True
                PictureBox2.Visible = False

                PictureBox4.Enabled = False
                PictureBox4.Visible = False

                PictureBox6.Visible = False
                PictureBox1.Location = New Point(Z, 195)
                PictureBox2.Location = New Point(Z, 195)

                PictureBox4.Location = New Point(Z, 174)
                PictureBox6.Location = New Point(Z, 195)
                System.Threading.Thread.Sleep(10)
                My.Application.DoEvents()
                Timer2.Enabled = True

            Case "f"

                PictureBox1.Visible = False

                PictureBox2.Visible = True
                PictureBox4.Visible = False
                PictureBox4.Enabled = False
                PictureBox6.Visible = False
                For i As Byte = 1 To 75
                    If Z < 660 Then
                        Z = Z + 4
                    End If
                    PictureBox1.Location = New Point(Z, 195)
                    PictureBox2.Location = New Point(Z, 195)

                    PictureBox4.Location = New Point(Z, 174)
                    PictureBox6.Location = New Point(Z, 195)
                    System.Threading.Thread.Sleep(10)
                    My.Application.DoEvents()
                    If X < Z + 120 Then
                        X = 720
                    End If

                    If X2 < Z + 120 Then
                        X2 = 902
                    End If
                Next

            Case "q"
                PictureBox1.Visible = False
                PictureBox2.Visible = False

                PictureBox4.Visible = True
                PictureBox4.Enabled = True
                PictureBox6.Visible = False

                If X < Z + 120 Then
                    X = 720
                End If

                If X2 < Z + 120 Then
                    X2 = 902
                End If


        End Select

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Ruta As String
        Ruta = My.Application.Info.DirectoryPath
        Dim A As System.Media.SoundPlayer
        A = New System.Media.SoundPlayer(Ruta + "\MC.WAV")
        A.Play()


        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox4.Visible = False

        PictureBox13.Visible = False
        PictureBox14.Visible = False


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        X = X - 2
        X2 = X2 - 2
        X3 = X3 - 3
        X4 = X4 - 5

        PictureBox5.Location = New Point(X, Y)
        PictureBox10.Location = New Point(X2, 195)
        PictureBox3.Location = New Point(X3, 116)
        PictureBox11.Location = New Point(X4, 164)


        If X < -50 Then
            X = 720
            Vidas = Vidas - 1
        End If

        If X2 < -50 Then
            X2 = 902
            Vidas = Vidas - 1
        End If

        If X3 < -50 Then
            X3 = 782

        End If

        If X4 < -50 Then
            X4 = 848

        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        PictureBox6.Visible = True
        PictureBox4.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label3.Text = Tiempo & "s"
        Tiempo = Tiempo - 1

        If Tiempo = 0 Then
            PictureBox14.Visible = True
            Timer1.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False

        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick


        If Vidas = 2 Then
            PictureBox7.Visible = False
        End If

        If Vidas = 1 Then
            PictureBox8.Visible = False
        End If

        If Vidas = 0 Then
            PictureBox9.Visible = False
            Timer1.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False
            PictureBox13.Visible = True
        End If



    End Sub
    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click

    End Sub
End Class
