﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pdfCreator
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.genarateButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resumePanel = New System.Windows.Forms.Panel()
        Me.Label = New System.Windows.Forms.Label()
        Me.filenameLabel = New System.Windows.Forms.Label()
        Me.contactLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.fullNameLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.resumePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.exitButton)
        Me.Panel1.Controls.Add(Me.clearButton)
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Controls.Add(Me.genarateButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 301)
        Me.Panel1.TabIndex = 0
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(10, 228)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 59)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.White
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(10, 156)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(96, 59)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(10, 82)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(96, 59)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'genarateButton
        '
        Me.genarateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.genarateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.genarateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genarateButton.Location = New System.Drawing.Point(10, 10)
        Me.genarateButton.Name = "genarateButton"
        Me.genarateButton.Size = New System.Drawing.Size(96, 59)
        Me.genarateButton.TabIndex = 2
        Me.genarateButton.Text = "Generate"
        Me.genarateButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Resume Generator"
        '
        'resumePanel
        '
        Me.resumePanel.BackColor = System.Drawing.SystemColors.Window
        Me.resumePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resumePanel.Controls.Add(Me.Label)
        Me.resumePanel.Controls.Add(Me.filenameLabel)
        Me.resumePanel.Controls.Add(Me.contactLabel)
        Me.resumePanel.Controls.Add(Me.emailLabel)
        Me.resumePanel.Controls.Add(Me.addressLabel)
        Me.resumePanel.Controls.Add(Me.fullNameLabel)
        Me.resumePanel.Location = New System.Drawing.Point(127, 45)
        Me.resumePanel.Name = "resumePanel"
        Me.resumePanel.Size = New System.Drawing.Size(389, 231)
        Me.resumePanel.TabIndex = 2
        Me.resumePanel.Visible = False
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(3, 10)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(202, 24)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Resume Information:"
        '
        'filenameLabel
        '
        Me.filenameLabel.AutoSize = True
        Me.filenameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filenameLabel.Location = New System.Drawing.Point(3, 184)
        Me.filenameLabel.Name = "filenameLabel"
        Me.filenameLabel.Size = New System.Drawing.Size(335, 20)
        Me.filenameLabel.TabIndex = 1
        Me.filenameLabel.Text = "Filename: PILAPIL_ROMWIL JAMES.pdf"
        '
        'contactLabel
        '
        Me.contactLabel.AutoSize = True
        Me.contactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactLabel.Location = New System.Drawing.Point(3, 147)
        Me.contactLabel.Name = "contactLabel"
        Me.contactLabel.Size = New System.Drawing.Size(80, 24)
        Me.contactLabel.TabIndex = 1
        Me.contactLabel.Text = "Contact"
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(3, 111)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(62, 24)
        Me.emailLabel.TabIndex = 1
        Me.emailLabel.Text = "Email"
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLabel.Location = New System.Drawing.Point(3, 76)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(87, 24)
        Me.addressLabel.TabIndex = 1
        Me.addressLabel.Text = "Address"
        '
        'fullNameLabel
        '
        Me.fullNameLabel.AutoSize = True
        Me.fullNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullNameLabel.Location = New System.Drawing.Point(3, 43)
        Me.fullNameLabel.Name = "fullNameLabel"
        Me.fullNameLabel.Size = New System.Drawing.Size(97, 24)
        Me.fullNameLabel.TabIndex = 1
        Me.fullNameLabel.Text = "Fullname"
        '
        'pdfCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(528, 301)
        Me.Controls.Add(Me.resumePanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pdfCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDF Creator"
        Me.Panel1.ResumeLayout(False)
        Me.resumePanel.ResumeLayout(False)
        Me.resumePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents genarateButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents resumePanel As Panel
    Friend WithEvents Label As Label
    Friend WithEvents contactLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents addressLabel As Label
    Friend WithEvents fullNameLabel As Label
    Friend WithEvents filenameLabel As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents SaveButton As Button
End Class
