<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1plus = New System.Windows.Forms.Button()
        Me.Button2min = New System.Windows.Forms.Button()
        Me.Button3kali = New System.Windows.Forms.Button()
        Me.Button4bagi = New System.Windows.Forms.Button()
        Me.Button5clr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(69, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 26)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(69, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(117, 26)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(69, 216)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(134, 26)
        Me.TextBox3.TabIndex = 5
        '
        'Button1plus
        '
        Me.Button1plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1plus.Location = New System.Drawing.Point(28, 113)
        Me.Button1plus.Name = "Button1plus"
        Me.Button1plus.Size = New System.Drawing.Size(41, 31)
        Me.Button1plus.TabIndex = 6
        Me.Button1plus.Text = "+"
        Me.Button1plus.UseVisualStyleBackColor = True
        '
        'Button2min
        '
        Me.Button2min.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2min.Location = New System.Drawing.Point(75, 113)
        Me.Button2min.Name = "Button2min"
        Me.Button2min.Size = New System.Drawing.Size(41, 31)
        Me.Button2min.TabIndex = 7
        Me.Button2min.Text = "-"
        Me.Button2min.UseVisualStyleBackColor = True
        '
        'Button3kali
        '
        Me.Button3kali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3kali.Location = New System.Drawing.Point(28, 150)
        Me.Button3kali.Name = "Button3kali"
        Me.Button3kali.Size = New System.Drawing.Size(41, 31)
        Me.Button3kali.TabIndex = 8
        Me.Button3kali.Text = "*"
        Me.Button3kali.UseVisualStyleBackColor = True
        '
        'Button4bagi
        '
        Me.Button4bagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4bagi.Location = New System.Drawing.Point(75, 150)
        Me.Button4bagi.Name = "Button4bagi"
        Me.Button4bagi.Size = New System.Drawing.Size(41, 31)
        Me.Button4bagi.TabIndex = 9
        Me.Button4bagi.Text = "/"
        Me.Button4bagi.UseVisualStyleBackColor = True
        '
        'Button5clr
        '
        Me.Button5clr.Location = New System.Drawing.Point(122, 132)
        Me.Button5clr.Name = "Button5clr"
        Me.Button5clr.Size = New System.Drawing.Size(41, 31)
        Me.Button5clr.TabIndex = 10
        Me.Button5clr.Text = "CLR"
        Me.Button5clr.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(215, 262)
        Me.Controls.Add(Me.Button5clr)
        Me.Controls.Add(Me.Button4bagi)
        Me.Controls.Add(Me.Button3kali)
        Me.Controls.Add(Me.Button2min)
        Me.Controls.Add(Me.Button1plus)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1plus As System.Windows.Forms.Button
    Friend WithEvents Button2min As System.Windows.Forms.Button
    Friend WithEvents Button3kali As System.Windows.Forms.Button
    Friend WithEvents Button4bagi As System.Windows.Forms.Button
    Friend WithEvents Button5clr As System.Windows.Forms.Button

End Class
