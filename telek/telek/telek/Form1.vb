Public Class Form1

    Private Sub beolvas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beolvas.Click
        Dim f As New IO.StreamReader("telkek.txt")
        Dim Telekszam As Long

        Telekszam = CInt(f.ReadLine)
        'Dim telek()
        Dim word(Telekszam - 1)
        Dim telek(Telekszam - 1) As String

        For i As Integer = 0 To Telekszam - 1
            Dim sor As String = f.ReadLine
            telek(i) = sor

            TextBox1.Text = TextBox1.Text + telek(i) + Chr(13) + Chr(10)

        Next

    End Sub

    Private Sub beolvas2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beolvas2.Click
        

        
        ' Néhány string szóközzel, vesszővel és adott sztringgel "KKK" elválasztva

        Dim x As Integer

        Dim intSpacedString As String = "1 3 5 7 9"
        Dim charCommaString As String = " a, e, i, o, u"
        Dim nameCommaString As String = "Sándor,József,,,Benedek,Ádám,Éva,Joli,Béla"
        Dim subStringString As String = "12KKK34KKK56KKK78KKK"
        Dim spaceSeparator As Char() = New Char() {" "c}
        Dim commaSeparator As Char() = New Char() {","c}
        Dim stringSeparators As String() = New String() {"KKK"}
        Dim result As String()


        result = intSpacedString.Split(spaceSeparator, StringSplitOptions.None)

        For Each str As String In result
            x = CInt(str)
            str = CStr(x)
            TextBox2.Text = TextBox2.Text + str + Chr(13) + Chr(10)
        Next
        
        result = charCommaString.Split(commaSeparator, StringSplitOptions.None)

        For Each str As String In result
            TextBox2.Text = TextBox2.Text + str + Chr(13) + Chr(10)
        Next

        result = nameCommaString.Split(commaSeparator, StringSplitOptions.None)

        For Each str As String In result
            TextBox2.Text = TextBox2.Text + str + Chr(13) + Chr(10)
        Next
        
        result = subStringString.Split(stringSeparators, StringSplitOptions.None)

        For Each str As String In result

            TextBox2.Text = TextBox2.Text + str + Chr(13) + Chr(10)
        Next


    End Sub

    Private Sub tombbeolvas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tombbeolvas.Click
        Dim f As New IO.StreamReader("telkek.txt")
        Dim i, j, k, l, m, n, szamlalo1, szamlalo2, szamlalo3, szamlalo4 As Integer
        Dim Telekszam As Integer

        Dim osszesadat As String
        Dim result As String()

        Dim spaceSeparator As Char() = New Char() {" "c}
        Dim intSpacedString As String

        Telekszam = CInt(f.ReadLine)
        'Dim telek()
        Dim word(Telekszam - 1)
        Dim telek(Telekszam - 1) As String
        Dim adatok((Telekszam - 1) * 5) As Integer

        For i = 0 To Telekszam - 1
            Dim sor As String = f.ReadLine
            telek(i) = sor


            tombbeolvasott.Text = tombbeolvasott.Text + telek(i) + Chr(13) + Chr(10)

            osszesadat = Join(telek)
            TextBox3.Text = osszesadat


        Next

        intSpacedString = osszesadat

        result = intSpacedString.Split(spaceSeparator, StringSplitOptions.None)
        k = 0
        j = 0
        For Each str As String In result

            TextBox4.Text = TextBox4.Text + str + Chr(13) + Chr(10)


            adatok(k) = CInt(str)
            TextBox6.Text = TextBox6.Text + CStr(adatok(k)) + Chr(13) + Chr(10)
            Console.WriteLine(adatok(k))
            k = k + 1


            

        Next


        'szétválogatás
        Dim joletsor((Telekszam - 1) / 2, 2) As Integer 'páros számú telkek
        Dim gazdagsor((Telekszam - 1) / 2, 2) As Integer 'páratlan számú telkek
        m = 1
        n = 2
        l = 0
        szamlalo1 = 0
        szamlalo2 = 0


        For l = 0 To ((Telekszam - 1) * 3 + 2) Step 3
            TextBox7.Text = TextBox7.Text + CStr(adatok(l)) + Chr(13) + Chr(10)
            If adatok(l) / 2 = Int(adatok(l) / 2) Then
                joletsortext.Text = joletsortext.Text + " " + CStr(adatok(l)) + " " + CStr(adatok(l + 1)) + " " + CStr(adatok(l + 2)) + Chr(13) + Chr(10)
                joletsor(szamlalo1, 0) = adatok(l) : joletsor(szamlalo1, 1) = adatok(l + 1) : joletsor(szamlalo1, 2) = adatok(l + 2)
                joletsortext.Text = joletsortext.Text + " " + CStr(joletsor(szamlalo1, 0)) + " " + CStr(joletsor(szamlalo1, 1)) + " " + CStr(joletsor(szamlalo1, 2)) + Chr(13) + Chr(10)
                szamlalo1 = szamlalo1 + 1
                n = n + 2
            Else
                gazdagsortext.Text = gazdagsortext.Text + " " + CStr(adatok(l)) + " " + CStr(adatok(l + 1)) + " " + CStr(adatok(l + 2)) + Chr(13) + Chr(10)
                gazdagsor(szamlalo2, 0) = adatok(l) : gazdagsor(szamlalo2, 1) = adatok(l + 1) : gazdagsor(szamlalo2, 2) = adatok(l + 2)
                gazdagsortext.Text = gazdagsortext.Text + " " + CStr(gazdagsor(szamlalo2, 0)) + " " + CStr(gazdagsor(szamlalo2, 1)) + " " + CStr(gazdagsor(szamlalo2, 2)) + Chr(13) + Chr(10)
                szamlalo2 = szamlalo2 + 1
                m = m + 2
            End If
        Next

        'rendezés házszám szerint

        Dim i1, j1
        Dim a, b, c, d, e1 As Integer
        szamlalo3 = 0
        szamlalo4 = 0

        For i1 = 0 To 14 'n - 1
            For j1 = i1 + 1 To 15 'n
                If joletsor(i1, 0) > joletsor(j1, 0) Then
                    a = joletsor(i1, 0) : b = joletsor(i1, 1) : c = joletsor(i1, 2)
                    joletsor(i1, 0) = joletsor(j1, 0) : joletsor(i1, 1) = joletsor(j1, 1) : joletsor(i1, 2) = joletsor(j1, 2)
                    joletsor(j1, 0) = a : joletsor(j1, 1) = b : joletsor(j1, 2) = c

                End If
            Next
        Next

        For szamlalo3 = 0 To 15
            joletsorhsztext.Text = joletsorhsztext.Text + " " + CStr(joletsor(szamlalo3, 0)) + " " + CStr(joletsor(szamlalo3, 1)) + " " + CStr(joletsor(szamlalo3, 2)) + Chr(13) + Chr(10)

        Next


        For i1 = 0 To 14 'n - 1
            For j1 = i1 + 1 To 15 'n
                If gazdagsor(i1, 0) > gazdagsor(j1, 0) Then
                    a = gazdagsor(i1, 0) : b = gazdagsor(i1, 1) : c = gazdagsor(i1, 2)
                    gazdagsor(i1, 0) = gazdagsor(j1, 0) : gazdagsor(i1, 1) = gazdagsor(j1, 1) : gazdagsor(i1, 2) = gazdagsor(j1, 2)
                    gazdagsor(j1, 0) = a : gazdagsor(j1, 1) = b : gazdagsor(j1, 2) = c

                End If
            Next
        Next

        For szamlalo4 = 0 To 15
            gazdagsorhsztext.Text = gazdagsorhsztext.Text + " " + CStr(gazdagsor(szamlalo4, 0)) + " " + CStr(gazdagsor(szamlalo4, 1)) + " " + CStr(gazdagsor(szamlalo4, 2)) + Chr(13) + Chr(10)

        Next

        'számítások Jólétsor
        Dim joletsorszamitott(15, 4) As Integer
        Dim ado As Integer
        For szamlalo3 = 0 To 15
            joletsorszamitott(szamlalo3, 0) = joletsor(szamlalo3, 0) 'házszám
            joletsorszamitott(szamlalo3, 1) = joletsor(szamlalo3, 1) ' szélesség
            joletsorszamitott(szamlalo3, 2) = 70 - gazdagsor(szamlalo3, 2) 'telekhossz
            joletsorszamitott(szamlalo3, 3) = (70 - gazdagsor(szamlalo3, 2)) * (joletsor(szamlalo3, 1)) 'terület


            If joletsorszamitott(szamlalo3, 3) <= 700 Then
                ado = joletsorszamitott(szamlalo3, 3) * 51
            ElseIf joletsorszamitott(szamlalo3, 3) <= 1000 Then

                ado = 700 * 51 + (joletsorszamitott(szamlalo3, 3) - 700) * 39
            ElseIf joletsorszamitott(szamlalo3, 3) > 1000 Then
                ado = 700 * 51 + 300 * 39 + 200
            End If

            If joletsorszamitott(szamlalo3, 1) <= 20 Then
                ado = Int(8 / 10 * ado)
            End If

            ado = Int(ado / 100) * 100
            joletsorszamitott(szamlalo3, 4) = ado 'adó



        Next

        For szamlalo3 = 0 To 15
            joletsoreredmenyek.Text = joletsoreredmenyek.Text + " " + CStr(joletsorszamitott(szamlalo3, 0)) + " " + CStr(joletsorszamitott(szamlalo3, 1)) + " " + CStr(joletsorszamitott(szamlalo3, 2)) + " " + CStr(joletsorszamitott(szamlalo3, 3)) + " " + CStr(joletsorszamitott(szamlalo3, 4)) + Chr(13) + Chr(10)

        Next

        'kiírás fájlba
        Dim g As New IO.StreamWriter("joletsor.csv")
        For szamlalo3 = 0 To 15
            g.WriteLine("{0};{1};{2};{3};{4}", joletsorszamitott(szamlalo3, 0), joletsorszamitott(szamlalo3, 1), joletsorszamitott(szamlalo3, 2), joletsorszamitott(szamlalo3, 3), joletsorszamitott(szamlalo3, 4))

        Next
        g.Close()


        'számítások Gazdagsor
        Dim gazdagsorszamitott(15, 4) As Integer
        For szamlalo3 = 0 To 15
            gazdagsorszamitott(szamlalo3, 0) = gazdagsor(szamlalo3, 0)
            gazdagsorszamitott(szamlalo3, 1) = gazdagsor(szamlalo3, 1)
            gazdagsorszamitott(szamlalo3, 2) = gazdagsor(szamlalo3, 2) 'telekhossz
            gazdagsorszamitott(szamlalo3, 3) = (gazdagsor(szamlalo3, 1)) * (gazdagsor(szamlalo3, 2)) 'terület

            gazdagsorszamitott(szamlalo3, 4) = 0 'adó



        Next

        For szamlalo3 = 0 To 15
            gazdagsoreredmenyek.Text = gazdagsoreredmenyek.Text + " " + CStr(gazdagsorszamitott(szamlalo3, 0)) + " " + CStr(gazdagsorszamitott(szamlalo3, 1)) + " " + CStr(gazdagsorszamitott(szamlalo3, 2)) + " " + CStr(gazdagsorszamitott(szamlalo3, 3)) + " " + CStr(gazdagsorszamitott(szamlalo3, 4)) + Chr(13) + Chr(10)

        Next


        For i1 = 0 To 14 'n - 1
            For j1 = i1 + 1 To 15 'n
                If gazdagsorszamitott(i1, 3) > gazdagsorszamitott(j1, 3) Then
                    a = gazdagsorszamitott(i1, 0) : b = gazdagsorszamitott(i1, 1) : c = gazdagsorszamitott(i1, 2) : d = gazdagsorszamitott(i1, 3) : e1 = gazdagsorszamitott(i1, 4)
                    gazdagsorszamitott(i1, 0) = gazdagsorszamitott(j1, 0) : gazdagsorszamitott(i1, 1) = gazdagsorszamitott(j1, 1) : gazdagsorszamitott(i1, 2) = gazdagsorszamitott(j1, 2) : gazdagsorszamitott(i1, 3) = gazdagsorszamitott(j1, 3) : gazdagsorszamitott(i1, 4) = gazdagsorszamitott(j1, 4)
                    gazdagsorszamitott(j1, 0) = a : gazdagsorszamitott(j1, 1) = b : gazdagsorszamitott(j1, 2) = c : gazdagsorszamitott(j1, 3) = d : gazdagsorszamitott(j1, 4) = e1

                End If
            Next
        Next

        For szamlalo3 = 0 To 15
            gazdagsorteruletszerinttext.Text = gazdagsorteruletszerinttext.Text + " " + CStr(gazdagsorszamitott(szamlalo3, 0)) + " " + CStr(gazdagsorszamitott(szamlalo3, 1)) + " " + CStr(gazdagsorszamitott(szamlalo3, 2)) + " " + CStr(gazdagsorszamitott(szamlalo3, 3)) + " " + CStr(gazdagsorszamitott(szamlalo3, 4)) + Chr(13) + Chr(10)

        Next

    End Sub

    Private Sub joletsortext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles joletsortext.TextChanged

    End Sub
End Class
