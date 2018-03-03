<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblTeamH = New System.Windows.Forms.Label()
        Me.txtbxHomeName = New System.Windows.Forms.TextBox()
        Me.txtbxAwayName = New System.Windows.Forms.TextBox()
        Me.lblTeamA = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btn20Overs = New System.Windows.Forms.Button()
        Me.btn45Overs = New System.Windows.Forms.Button()
        Me.btn50Overs = New System.Windows.Forms.Button()
        Me.btnSetBack = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnPre = New System.Windows.Forms.Button()
        Me.btnPre2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNameOfProject = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblWelcome.Location = New System.Drawing.Point(34, 7)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(302, 20)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to my Cricket Scoreboard ""App"""
        '
        'lblTeamH
        '
        Me.lblTeamH.AutoSize = True
        Me.lblTeamH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamH.ForeColor = System.Drawing.Color.Black
        Me.lblTeamH.Location = New System.Drawing.Point(12, 107)
        Me.lblTeamH.Name = "lblTeamH"
        Me.lblTeamH.Size = New System.Drawing.Size(124, 16)
        Me.lblTeamH.TabIndex = 2
        Me.lblTeamH.Text = "Home Team Name"
        '
        'txtbxHomeName
        '
        Me.txtbxHomeName.HideSelection = False
        Me.txtbxHomeName.Location = New System.Drawing.Point(169, 103)
        Me.txtbxHomeName.Name = "txtbxHomeName"
        Me.txtbxHomeName.Size = New System.Drawing.Size(186, 20)
        Me.txtbxHomeName.TabIndex = 3
        '
        'txtbxAwayName
        '
        Me.txtbxAwayName.Location = New System.Drawing.Point(169, 142)
        Me.txtbxAwayName.Name = "txtbxAwayName"
        Me.txtbxAwayName.Size = New System.Drawing.Size(186, 20)
        Me.txtbxAwayName.TabIndex = 5
        '
        'lblTeamA
        '
        Me.lblTeamA.AutoSize = True
        Me.lblTeamA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTeamA.Location = New System.Drawing.Point(12, 146)
        Me.lblTeamA.Name = "lblTeamA"
        Me.lblTeamA.Size = New System.Drawing.Size(120, 16)
        Me.lblTeamA.TabIndex = 4
        Me.lblTeamA.Text = "Away Team Name"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQuestion.Location = New System.Drawing.Point(12, 205)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(183, 16)
        Me.lblQuestion.TabIndex = 6
        Me.lblQuestion.Text = "Amount of overs in the game?"
        '
        'btn20Overs
        '
        Me.btn20Overs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn20Overs.Location = New System.Drawing.Point(203, 198)
        Me.btn20Overs.Name = "btn20Overs"
        Me.btn20Overs.Size = New System.Drawing.Size(30, 30)
        Me.btn20Overs.TabIndex = 7
        Me.btn20Overs.Text = "20"
        Me.btn20Overs.UseVisualStyleBackColor = True
        '
        'btn45Overs
        '
        Me.btn45Overs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn45Overs.Location = New System.Drawing.Point(259, 198)
        Me.btn45Overs.Name = "btn45Overs"
        Me.btn45Overs.Size = New System.Drawing.Size(30, 30)
        Me.btn45Overs.TabIndex = 8
        Me.btn45Overs.Text = "45"
        Me.btn45Overs.UseVisualStyleBackColor = True
        '
        'btn50Overs
        '
        Me.btn50Overs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn50Overs.Location = New System.Drawing.Point(315, 198)
        Me.btn50Overs.Name = "btn50Overs"
        Me.btn50Overs.Size = New System.Drawing.Size(30, 30)
        Me.btn50Overs.TabIndex = 9
        Me.btn50Overs.Text = "50"
        Me.btn50Overs.UseVisualStyleBackColor = True
        '
        'btnSetBack
        '
        Me.btnSetBack.BackgroundImage = CType(resources.GetObject("btnSetBack.BackgroundImage"), System.Drawing.Image)
        Me.btnSetBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSetBack.Location = New System.Drawing.Point(12, 513)
        Me.btnSetBack.Name = "btnSetBack"
        Me.btnSetBack.Size = New System.Drawing.Size(75, 30)
        Me.btnSetBack.TabIndex = 10
        Me.btnSetBack.Text = "Background"
        Me.btnSetBack.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSubmit.Location = New System.Drawing.Point(125, 300)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(149, 47)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnPre
        '
        Me.btnPre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPre.Location = New System.Drawing.Point(15, 374)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(357, 44)
        Me.btnPre.TabIndex = 12
        Me.btnPre.Text = "Pre1 - Testing -> PlayGame"
        Me.btnPre.UseVisualStyleBackColor = True
        '
        'btnPre2
        '
        Me.btnPre2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPre2.Location = New System.Drawing.Point(15, 424)
        Me.btnPre2.Name = "btnPre2"
        Me.btnPre2.Size = New System.Drawing.Size(357, 44)
        Me.btnPre2.TabIndex = 13
        Me.btnPre2.Text = "Pre2 - Testing -> Statistics"
        Me.btnPre2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Please note that when you click 'Submit' data is stored and cannot be changed."
        '
        'lblNameOfProject
        '
        Me.lblNameOfProject.AutoSize = True
        Me.lblNameOfProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfProject.ForeColor = System.Drawing.Color.Coral
        Me.lblNameOfProject.Location = New System.Drawing.Point(118, 46)
        Me.lblNameOfProject.Name = "lblNameOfProject"
        Me.lblNameOfProject.Size = New System.Drawing.Size(144, 39)
        Me.lblNameOfProject.TabIndex = 15
        Me.lblNameOfProject.Text = "ScoreIO"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.lblNameOfProject)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPre2)
        Me.Controls.Add(Me.btnPre)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnSetBack)
        Me.Controls.Add(Me.btn50Overs)
        Me.Controls.Add(Me.btn45Overs)
        Me.Controls.Add(Me.btn20Overs)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.txtbxAwayName)
        Me.Controls.Add(Me.lblTeamA)
        Me.Controls.Add(Me.txtbxHomeName)
        Me.Controls.Add(Me.lblTeamH)
        Me.Controls.Add(Me.lblWelcome)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblTeamH As Label
    Friend WithEvents txtbxHomeName As TextBox
    Friend WithEvents txtbxAwayName As TextBox
    Friend WithEvents lblTeamA As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btn20Overs As Button
    Friend WithEvents btn45Overs As Button
    Friend WithEvents btn50Overs As Button
    Friend WithEvents btnSetBack As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnPre As Button
    Friend WithEvents btnPre2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNameOfProject As Label
End Class
