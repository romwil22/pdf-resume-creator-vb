<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.genarateButton = New System.Windows.Forms.Button()
        Me.resumePanel = New System.Windows.Forms.Panel()
        Me.fullNameLabel = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.contactLabel = New System.Windows.Forms.Label()
        Me.filenameLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.resumePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.genarateButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 301)
        Me.Panel1.TabIndex = 0
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
        'genarateButton
        '
        Me.genarateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genarateButton.Location = New System.Drawing.Point(10, 10)
        Me.genarateButton.Name = "genarateButton"
        Me.genarateButton.Size = New System.Drawing.Size(96, 59)
        Me.genarateButton.TabIndex = 2
        Me.genarateButton.Text = "Generate"
        Me.genarateButton.UseVisualStyleBackColor = True
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 59)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(10, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 59)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(10, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 59)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'pdfCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 301)
        Me.Controls.Add(Me.resumePanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pdfCreator"
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
