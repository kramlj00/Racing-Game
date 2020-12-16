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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadBtn_Easy = New System.Windows.Forms.RadioButton()
        Me.RadBtn_Medium = New System.Windows.Forms.RadioButton()
        Me.RadBtn_Hard = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 44)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Racing Game"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Red
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(301, 160)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(66, 28)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.Text = "Red"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Gray
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(301, 211)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(70, 28)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.Text = "Gray"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.LightGreen
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(301, 257)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(84, 28)
        Me.RadioButton3.TabIndex = 11
        Me.RadioButton3.Text = "Green"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(668, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(226, 58)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-5, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 32)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Choose background color :"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Blue
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.White
        Me.RadioButton4.Location = New System.Drawing.Point(303, 309)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(69, 28)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.Text = "Blue"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadBtn_Easy
        '
        Me.RadBtn_Easy.AutoSize = True
        Me.RadBtn_Easy.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RadBtn_Easy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RadBtn_Easy.Location = New System.Drawing.Point(65, 32)
        Me.RadBtn_Easy.Name = "RadBtn_Easy"
        Me.RadBtn_Easy.Size = New System.Drawing.Size(72, 28)
        Me.RadBtn_Easy.TabIndex = 16
        Me.RadBtn_Easy.Text = "Easy"
        Me.RadBtn_Easy.UseVisualStyleBackColor = False
        '
        'RadBtn_Medium
        '
        Me.RadBtn_Medium.AutoSize = True
        Me.RadBtn_Medium.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RadBtn_Medium.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RadBtn_Medium.Location = New System.Drawing.Point(65, 77)
        Me.RadBtn_Medium.Name = "RadBtn_Medium"
        Me.RadBtn_Medium.Size = New System.Drawing.Size(100, 28)
        Me.RadBtn_Medium.TabIndex = 17
        Me.RadBtn_Medium.Text = "Medium"
        Me.RadBtn_Medium.UseVisualStyleBackColor = False
        '
        'RadBtn_Hard
        '
        Me.RadBtn_Hard.AutoSize = True
        Me.RadBtn_Hard.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RadBtn_Hard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RadBtn_Hard.Location = New System.Drawing.Point(65, 120)
        Me.RadBtn_Hard.Name = "RadBtn_Hard"
        Me.RadBtn_Hard.Size = New System.Drawing.Size(72, 28)
        Me.RadBtn_Hard.TabIndex = 18
        Me.RadBtn_Hard.Text = "Hard"
        Me.RadBtn_Hard.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.RadBtn_Easy)
        Me.GroupBox1.Controls.Add(Me.RadBtn_Hard)
        Me.GroupBox1.Controls.Add(Me.RadBtn_Medium)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(540, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 189)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Difficulty"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(932, 483)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(950, 530)
        Me.MinimumSize = New System.Drawing.Size(950, 530)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadBtn_Easy As RadioButton
    Friend WithEvents RadBtn_Medium As RadioButton
    Friend WithEvents RadBtn_Hard As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
