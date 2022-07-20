Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Imports System.IO
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Public Class pdfCreator
    Private Sub genarateButton_Click(sender As Object, e As EventArgs) Handles genarateButton.Click
        resumePanel.Visible = True

        Dim directory As String = "C:\Users\Rom\Desktop\5TH-YR-2ND-SEM\elec3\pdf-resume-creator-vb\resumeInfo.json"
        Dim jsonFile As String = File.ReadAllText(directory)
        Dim getJsonValue As jsonData = JsonConvert.DeserializeObject(Of jsonData)(jsonFile)

        fullNameLabel.Text = getJsonValue.fullName
        addressLabel.Text = getJsonValue.address
        emailLabel.Text = getJsonValue.email
        contactLabel.Text = getJsonValue.contact
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Public Class jsonData
        Public Property fullName As String
        Public Property address As String
        Public Property email As String
        Public Property contact As String
        Public Property objective As String
        Public Property literate As String
        Public Property school As String
        Public Property course As String
        Public Property year As String
        Public Property activity As String
        Public Property certificate1 As String
        Public Property certificate2 As String
        Public Property certificate3 As String


    End Class

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        resumePanel.Visible = False
    End Sub
End Class
