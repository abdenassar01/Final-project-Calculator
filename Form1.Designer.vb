<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculatrice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculatrice))
        Me.Resultbox = New System.Windows.Forms.TextBox()
        Me.nb1 = New System.Windows.Forms.Button()
        Me.nb2 = New System.Windows.Forms.Button()
        Me.nb3 = New System.Windows.Forms.Button()
        Me.nb4 = New System.Windows.Forms.Button()
        Me.nb5 = New System.Windows.Forms.Button()
        Me.nb6 = New System.Windows.Forms.Button()
        Me.multiplication = New System.Windows.Forms.Button()
        Me.nb7 = New System.Windows.Forms.Button()
        Me.nb8 = New System.Windows.Forms.Button()
        Me.nb9 = New System.Windows.Forms.Button()
        Me.division = New System.Windows.Forms.Button()
        Me.nb0 = New System.Windows.Forms.Button()
        Me.ac = New System.Windows.Forms.Button()
        Me.addition = New System.Windows.Forms.Button()
        Me.substraction = New System.Windows.Forms.Button()
        Me.egal = New System.Windows.Forms.Button()
        Me.dicimal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Resultbox
        '
        Me.Resultbox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Resultbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Resultbox.Enabled = False
        Me.Resultbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Resultbox.Location = New System.Drawing.Point(18, 15)
        Me.Resultbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Resultbox.Multiline = True
        Me.Resultbox.Name = "Resultbox"
        Me.Resultbox.Size = New System.Drawing.Size(331, 83)
        Me.Resultbox.TabIndex = 0
        Me.Resultbox.Text = "0"
        '
        'nb1
        '
        Me.nb1.BackColor = System.Drawing.Color.Yellow
        Me.nb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb1.Location = New System.Drawing.Point(18, 137)
        Me.nb1.Margin = New System.Windows.Forms.Padding(4)
        Me.nb1.Name = "nb1"
        Me.nb1.Size = New System.Drawing.Size(76, 46)
        Me.nb1.TabIndex = 1
        Me.nb1.Text = "1"
        Me.nb1.UseVisualStyleBackColor = False
        '
        'nb2
        '
        Me.nb2.BackColor = System.Drawing.Color.Yellow
        Me.nb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb2.Location = New System.Drawing.Point(104, 137)
        Me.nb2.Margin = New System.Windows.Forms.Padding(4)
        Me.nb2.Name = "nb2"
        Me.nb2.Size = New System.Drawing.Size(76, 46)
        Me.nb2.TabIndex = 1
        Me.nb2.Text = "2"
        Me.nb2.UseVisualStyleBackColor = False
        '
        'nb3
        '
        Me.nb3.BackColor = System.Drawing.Color.Yellow
        Me.nb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb3.Location = New System.Drawing.Point(189, 137)
        Me.nb3.Margin = New System.Windows.Forms.Padding(4)
        Me.nb3.Name = "nb3"
        Me.nb3.Size = New System.Drawing.Size(76, 46)
        Me.nb3.TabIndex = 1
        Me.nb3.Text = "3"
        Me.nb3.UseVisualStyleBackColor = False
        '
        'nb4
        '
        Me.nb4.BackColor = System.Drawing.Color.Yellow
        Me.nb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb4.Location = New System.Drawing.Point(20, 191)
        Me.nb4.Margin = New System.Windows.Forms.Padding(4)
        Me.nb4.Name = "nb4"
        Me.nb4.Size = New System.Drawing.Size(76, 46)
        Me.nb4.TabIndex = 1
        Me.nb4.Text = "4"
        Me.nb4.UseVisualStyleBackColor = False
        '
        'nb5
        '
        Me.nb5.BackColor = System.Drawing.Color.Yellow
        Me.nb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb5.Location = New System.Drawing.Point(104, 190)
        Me.nb5.Margin = New System.Windows.Forms.Padding(4)
        Me.nb5.Name = "nb5"
        Me.nb5.Size = New System.Drawing.Size(76, 46)
        Me.nb5.TabIndex = 1
        Me.nb5.Text = "5"
        Me.nb5.UseVisualStyleBackColor = False
        '
        'nb6
        '
        Me.nb6.BackColor = System.Drawing.Color.Yellow
        Me.nb6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb6.Location = New System.Drawing.Point(189, 190)
        Me.nb6.Margin = New System.Windows.Forms.Padding(4)
        Me.nb6.Name = "nb6"
        Me.nb6.Size = New System.Drawing.Size(76, 46)
        Me.nb6.TabIndex = 1
        Me.nb6.Text = "6"
        Me.nb6.UseVisualStyleBackColor = False
        '
        'multiplication
        '
        Me.multiplication.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.multiplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplication.Location = New System.Drawing.Point(274, 190)
        Me.multiplication.Margin = New System.Windows.Forms.Padding(4)
        Me.multiplication.Name = "multiplication"
        Me.multiplication.Size = New System.Drawing.Size(76, 46)
        Me.multiplication.TabIndex = 1
        Me.multiplication.Text = "X"
        Me.multiplication.UseVisualStyleBackColor = False
        '
        'nb7
        '
        Me.nb7.BackColor = System.Drawing.Color.Yellow
        Me.nb7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb7.Location = New System.Drawing.Point(18, 242)
        Me.nb7.Margin = New System.Windows.Forms.Padding(4)
        Me.nb7.Name = "nb7"
        Me.nb7.Size = New System.Drawing.Size(76, 46)
        Me.nb7.TabIndex = 1
        Me.nb7.Text = "7"
        Me.nb7.UseVisualStyleBackColor = False
        '
        'nb8
        '
        Me.nb8.BackColor = System.Drawing.Color.Yellow
        Me.nb8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb8.Location = New System.Drawing.Point(104, 242)
        Me.nb8.Margin = New System.Windows.Forms.Padding(4)
        Me.nb8.Name = "nb8"
        Me.nb8.Size = New System.Drawing.Size(76, 46)
        Me.nb8.TabIndex = 1
        Me.nb8.Text = "8"
        Me.nb8.UseVisualStyleBackColor = False
        '
        'nb9
        '
        Me.nb9.BackColor = System.Drawing.Color.Yellow
        Me.nb9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb9.Location = New System.Drawing.Point(189, 242)
        Me.nb9.Margin = New System.Windows.Forms.Padding(4)
        Me.nb9.Name = "nb9"
        Me.nb9.Size = New System.Drawing.Size(76, 46)
        Me.nb9.TabIndex = 1
        Me.nb9.Text = "9"
        Me.nb9.UseVisualStyleBackColor = False
        '
        'division
        '
        Me.division.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.division.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.division.Location = New System.Drawing.Point(274, 242)
        Me.division.Margin = New System.Windows.Forms.Padding(4)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(76, 46)
        Me.division.TabIndex = 1
        Me.division.Text = "/"
        Me.division.UseVisualStyleBackColor = False
        '
        'nb0
        '
        Me.nb0.BackColor = System.Drawing.Color.Yellow
        Me.nb0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb0.Location = New System.Drawing.Point(104, 295)
        Me.nb0.Margin = New System.Windows.Forms.Padding(4)
        Me.nb0.Name = "nb0"
        Me.nb0.Size = New System.Drawing.Size(76, 46)
        Me.nb0.TabIndex = 1
        Me.nb0.Text = "0"
        Me.nb0.UseVisualStyleBackColor = False
        '
        'ac
        '
        Me.ac.BackColor = System.Drawing.Color.Thistle
        Me.ac.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ac.Location = New System.Drawing.Point(273, 136)
        Me.ac.Margin = New System.Windows.Forms.Padding(4)
        Me.ac.Name = "ac"
        Me.ac.Size = New System.Drawing.Size(76, 46)
        Me.ac.TabIndex = 1
        Me.ac.Text = "AC"
        Me.ac.UseVisualStyleBackColor = False
        '
        'addition
        '
        Me.addition.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.addition.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addition.Location = New System.Drawing.Point(274, 295)
        Me.addition.Margin = New System.Windows.Forms.Padding(4)
        Me.addition.Name = "addition"
        Me.addition.Size = New System.Drawing.Size(76, 46)
        Me.addition.TabIndex = 1
        Me.addition.Text = "+"
        Me.addition.UseVisualStyleBackColor = False
        '
        'substraction
        '
        Me.substraction.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.substraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.substraction.Location = New System.Drawing.Point(18, 295)
        Me.substraction.Margin = New System.Windows.Forms.Padding(4)
        Me.substraction.Name = "substraction"
        Me.substraction.Size = New System.Drawing.Size(76, 46)
        Me.substraction.TabIndex = 1
        Me.substraction.Text = "-"
        Me.substraction.UseVisualStyleBackColor = False
        '
        'egal
        '
        Me.egal.BackColor = System.Drawing.SystemColors.Highlight
        Me.egal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.egal.Location = New System.Drawing.Point(18, 348)
        Me.egal.Margin = New System.Windows.Forms.Padding(4)
        Me.egal.Name = "egal"
        Me.egal.Size = New System.Drawing.Size(333, 79)
        Me.egal.TabIndex = 1
        Me.egal.Text = "="
        Me.egal.UseVisualStyleBackColor = False
        '
        'dicimal
        '
        Me.dicimal.BackColor = System.Drawing.Color.Magenta
        Me.dicimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dicimal.Location = New System.Drawing.Point(188, 296)
        Me.dicimal.Margin = New System.Windows.Forms.Padding(4)
        Me.dicimal.Name = "dicimal"
        Me.dicimal.Size = New System.Drawing.Size(76, 46)
        Me.dicimal.TabIndex = 1
        Me.dicimal.Text = "."
        Me.dicimal.UseVisualStyleBackColor = False
        '
        'Calculatrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(370, 442)
        Me.Controls.Add(Me.addition)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.multiplication)
        Me.Controls.Add(Me.dicimal)
        Me.Controls.Add(Me.ac)
        Me.Controls.Add(Me.nb9)
        Me.Controls.Add(Me.nb6)
        Me.Controls.Add(Me.nb0)
        Me.Controls.Add(Me.nb8)
        Me.Controls.Add(Me.egal)
        Me.Controls.Add(Me.substraction)
        Me.Controls.Add(Me.nb5)
        Me.Controls.Add(Me.nb7)
        Me.Controls.Add(Me.nb3)
        Me.Controls.Add(Me.nb4)
        Me.Controls.Add(Me.nb2)
        Me.Controls.Add(Me.nb1)
        Me.Controls.Add(Me.Resultbox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Calculatrice"
        Me.Text = "Calculatrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Resultbox As System.Windows.Forms.TextBox
    Friend WithEvents nb1 As System.Windows.Forms.Button
    Friend WithEvents nb2 As System.Windows.Forms.Button
    Friend WithEvents nb3 As System.Windows.Forms.Button
    Friend WithEvents nb4 As System.Windows.Forms.Button
    Friend WithEvents nb5 As System.Windows.Forms.Button
    Friend WithEvents nb6 As System.Windows.Forms.Button
    Friend WithEvents multiplication As System.Windows.Forms.Button
    Friend WithEvents nb7 As System.Windows.Forms.Button
    Friend WithEvents nb8 As System.Windows.Forms.Button
    Friend WithEvents nb9 As System.Windows.Forms.Button
    Friend WithEvents division As System.Windows.Forms.Button
    Friend WithEvents nb0 As System.Windows.Forms.Button
    Friend WithEvents ac As System.Windows.Forms.Button
    Friend WithEvents addition As System.Windows.Forms.Button
    Friend WithEvents substraction As System.Windows.Forms.Button
    Friend WithEvents egal As System.Windows.Forms.Button
    Friend WithEvents dicimal As System.Windows.Forms.Button

End Class
