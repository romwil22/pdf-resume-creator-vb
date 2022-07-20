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
        ' review information of resume
        resumePanel.Visible = True

        Dim directory As String = "C:\Users\Rom\Desktop\5TH-YR-2ND-SEM\elec3\pdf-resume-creator-vb\resumeInfo.json"
        Dim jsonFile As String = File.ReadAllText(directory)
        Dim getJsonValue As jsonData = JsonConvert.DeserializeObject(Of jsonData)(jsonFile)

        fullNameLabel.Text = getJsonValue.fullName
        addressLabel.Text = getJsonValue.address
        emailLabel.Text = getJsonValue.email
        contactLabel.Text = getJsonValue.contact
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
        Public Property certification1 As String
        Public Property certification2 As String
        Public Property certification3 As String


    End Class

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        ' json file
        Dim Directory As String = "C:\Users\Rom\Desktop\5TH-YR-2ND-SEM\elec3\pdf-resume-creator-vb\resumeInfo.json"
        Dim jsonFile As String = File.ReadAllText(directory)
        Dim getJsonValue As jsonData = JsonConvert.DeserializeObject(Of jsonData)(jsonFile)





        'pdf writer
        If resumePanel.Visible Then
            ' pdf file
            Dim pdfDirectory As String = "C:\Users\Rom\Desktop\5TH-YR-2ND-SEM\elec3\pdf-resume-creator-vb\PILAPIL_ROMWIL JAMES.pdf"
            Dim pdfFile As Document = New Document()
            PdfWriter.GetInstance(pdfFile, New FileStream(pdfDirectory, FileMode.Create))

            pdfFile.Open()

            Dim completeName As Paragraph = New Paragraph(getJsonValue.fullName)
            Dim completeAddress As Paragraph = New Paragraph(getJsonValue.address)
            Dim emailContact As Paragraph = New Paragraph(getJsonValue.email + " | " + getJsonValue.contact + vbLf + vbLf)
            Dim careerObjective As Paragraph = New Paragraph("Career Objective")
            Dim obj As Paragraph = New Paragraph("  - " + getJsonValue.objective + vbLf + vbLf)
            Dim proffessionalAttribute As Paragraph = New Paragraph("Proffesional Attibute")
            Dim attribute As Paragraph = New Paragraph("  - " + getJsonValue.literate + vbLf + vbLf)
            Dim education As Paragraph = New Paragraph("Education")
            Dim schoolName As Paragraph = New Paragraph(getJsonValue.school)
            Dim courseName As Paragraph = New Paragraph(getJsonValue.course)
            Dim yearPresent As Paragraph = New Paragraph(getJsonValue.year + vbLf + vbLf)
            Dim extracurricular As Paragraph = New Paragraph("Extracurricular Activity")
            Dim activityName As Paragraph = New Paragraph("  - " + getJsonValue.activity + vbLf + vbLf)
            Dim certicateEtc As Paragraph = New Paragraph("Certifications, Workshops, and Seminars Attended")
            Dim certicateName1 As Paragraph = New Paragraph("  - " + getJsonValue.certification1)
            Dim certicateName2 As Paragraph = New Paragraph("  - " + getJsonValue.certification2)
            Dim certicateName3 As Paragraph = New Paragraph("  - " + getJsonValue.certification3)
            Dim horizontalBar As LineSeparator = New LineSeparator(3.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)

            completeName.Alignment = Element.ALIGN_CENTER
            completeAddress.Alignment = Element.ALIGN_CENTER
            emailContact.Alignment = Element.ALIGN_CENTER

            pdfFile.Add(completeName)
            pdfFile.Add(completeAddress)
            pdfFile.Add(emailContact)
            pdfFile.Add(horizontalBar)
            pdfFile.Add(careerObjective)
            pdfFile.Add(obj)
            pdfFile.Add(horizontalBar)
            pdfFile.Add(proffessionalAttribute)
            pdfFile.Add(attribute)
            pdfFile.Add(horizontalBar)
            pdfFile.Add(education)
            pdfFile.Add(schoolName)
            pdfFile.Add(courseName)
            pdfFile.Add(yearPresent)
            pdfFile.Add(horizontalBar)
            pdfFile.Add(extracurricular)
            pdfFile.Add(activityName)
            pdfFile.Add(horizontalBar)
            pdfFile.Add(certicateEtc)
            pdfFile.Add(certicateName1)
            pdfFile.Add(certicateName2)
            pdfFile.Add(certicateName3)

            pdfFile.Close()

            MessageBox.Show("PDF file save successfully...", "Information")
        Else
            MessageBox.Show("Generate first, before saving file.", "Information")
        End If


        MessageBox.Show("test save button")
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        resumePanel.Visible = False
        fullNameLabel.Text = ""
        addressLabel.Text = ""
        emailLabel.Text = ""
        contactLabel.Text = ""
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
