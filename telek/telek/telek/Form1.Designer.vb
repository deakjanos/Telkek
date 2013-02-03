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
        Me.beolvas = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.beolvas2 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.tombbeolvas = New System.Windows.Forms.Button
        Me.tombbeolvasott = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.joletsortext = New System.Windows.Forms.TextBox
        Me.gazdagsortext = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.joletsorhsztext = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.gazdagsorhsztext = New System.Windows.Forms.TextBox
        Me.joletsoreredmenyek = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.gazdagsoreredmenyek = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.gazdagsorteruletszerinttext = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'beolvas
        '
        Me.beolvas.Location = New System.Drawing.Point(13, 11)
        Me.beolvas.Name = "beolvas"
        Me.beolvas.Size = New System.Drawing.Size(153, 43)
        Me.beolvas.TabIndex = 0
        Me.beolvas.Text = "Beolvasás fájlból soronként"
        Me.beolvas.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(173, 13)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(226, 41)
        Me.TextBox1.TabIndex = 1
        '
        'beolvas2
        '
        Me.beolvas2.Location = New System.Drawing.Point(406, 13)
        Me.beolvas2.Name = "beolvas2"
        Me.beolvas2.Size = New System.Drawing.Size(140, 41)
        Me.beolvas2.TabIndex = 2
        Me.beolvas2.Text = "Szeparátorok használata"
        Me.beolvas2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(553, 13)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(196, 41)
        Me.TextBox2.TabIndex = 3
        '
        'tombbeolvas
        '
        Me.tombbeolvas.Location = New System.Drawing.Point(13, 61)
        Me.tombbeolvas.Name = "tombbeolvas"
        Me.tombbeolvas.Size = New System.Drawing.Size(153, 44)
        Me.tombbeolvas.TabIndex = 4
        Me.tombbeolvas.Text = "Beolvasás tömbbe"
        Me.tombbeolvas.UseVisualStyleBackColor = True
        '
        'tombbeolvasott
        '
        Me.tombbeolvasott.Location = New System.Drawing.Point(173, 82)
        Me.tombbeolvasott.Multiline = True
        Me.tombbeolvasott.Name = "tombbeolvasott"
        Me.tombbeolvasott.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tombbeolvasott.Size = New System.Drawing.Size(226, 44)
        Me.tombbeolvasott.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(405, 82)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(343, 44)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 160)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(62, 290)
        Me.TextBox4.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Soronkénti beolvasás (u.a., mint fent):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(403, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Egyetlen sztring az összes beolvasott adatból (Join, konkatenáció):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "A teljes sztring leválogatása:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Jólétsor adatok:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Gazdagsor adatok:"
        '
        'joletsortext
        '
        Me.joletsortext.Location = New System.Drawing.Point(80, 179)
        Me.joletsortext.Multiline = True
        Me.joletsortext.Name = "joletsortext"
        Me.joletsortext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.joletsortext.Size = New System.Drawing.Size(150, 53)
        Me.joletsortext.TabIndex = 15
        '
        'gazdagsortext
        '
        Me.gazdagsortext.Location = New System.Drawing.Point(254, 179)
        Me.gazdagsortext.Multiline = True
        Me.gazdagsortext.Name = "gazdagsortext"
        Me.gazdagsortext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gazdagsortext.Size = New System.Drawing.Size(145, 53)
        Me.gazdagsortext.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(661, 160)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox6.Size = New System.Drawing.Size(55, 290)
        Me.TextBox6.TabIndex = 17
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(722, 160)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox7.Size = New System.Drawing.Size(50, 290)
        Me.TextBox7.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Jólétsor házszám szerint:"
        '
        'joletsorhsztext
        '
        Me.joletsorhsztext.Location = New System.Drawing.Point(80, 251)
        Me.joletsorhsztext.Multiline = True
        Me.joletsorhsztext.Name = "joletsorhsztext"
        Me.joletsorhsztext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.joletsorhsztext.Size = New System.Drawing.Size(149, 64)
        Me.joletsorhsztext.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(254, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Gazdagsor házszám szerint:"
        '
        'gazdagsorhsztext
        '
        Me.gazdagsorhsztext.Location = New System.Drawing.Point(254, 251)
        Me.gazdagsorhsztext.Multiline = True
        Me.gazdagsorhsztext.Name = "gazdagsorhsztext"
        Me.gazdagsorhsztext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gazdagsorhsztext.Size = New System.Drawing.Size(142, 64)
        Me.gazdagsorhsztext.TabIndex = 22
        '
        'joletsoreredmenyek
        '
        Me.joletsoreredmenyek.Location = New System.Drawing.Point(80, 348)
        Me.joletsoreredmenyek.Multiline = True
        Me.joletsoreredmenyek.Name = "joletsoreredmenyek"
        Me.joletsoreredmenyek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.joletsoreredmenyek.Size = New System.Drawing.Size(149, 102)
        Me.joletsoreredmenyek.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(83, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Jólétsor: hsz, szél, hossz, ter., adó"
        '
        'gazdagsoreredmenyek
        '
        Me.gazdagsoreredmenyek.Location = New System.Drawing.Point(254, 348)
        Me.gazdagsoreredmenyek.Multiline = True
        Me.gazdagsoreredmenyek.Name = "gazdagsoreredmenyek"
        Me.gazdagsoreredmenyek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gazdagsoreredmenyek.Size = New System.Drawing.Size(138, 102)
        Me.gazdagsoreredmenyek.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Gazdagsor:hsz, szél, hossz, ter., adó"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(438, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Gazdagasor terület szerint:"
        '
        'gazdagsorteruletszerinttext
        '
        Me.gazdagsorteruletszerinttext.Location = New System.Drawing.Point(441, 179)
        Me.gazdagsorteruletszerinttext.Multiline = True
        Me.gazdagsorteruletszerinttext.Name = "gazdagsorteruletszerinttext"
        Me.gazdagsorteruletszerinttext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gazdagsorteruletszerinttext.Size = New System.Drawing.Size(174, 136)
        Me.gazdagsorteruletszerinttext.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.gazdagsorteruletszerinttext)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gazdagsoreredmenyek)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.joletsoreredmenyek)
        Me.Controls.Add(Me.gazdagsorhsztext)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.joletsorhsztext)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.gazdagsortext)
        Me.Controls.Add(Me.joletsortext)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.tombbeolvasott)
        Me.Controls.Add(Me.tombbeolvas)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.beolvas2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.beolvas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents beolvas As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents beolvas2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tombbeolvas As System.Windows.Forms.Button
    Friend WithEvents tombbeolvasott As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents joletsortext As System.Windows.Forms.TextBox
    Friend WithEvents gazdagsortext As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents joletsorhsztext As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gazdagsorhsztext As System.Windows.Forms.TextBox
    Friend WithEvents joletsoreredmenyek As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gazdagsoreredmenyek As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gazdagsorteruletszerinttext As System.Windows.Forms.TextBox

End Class
