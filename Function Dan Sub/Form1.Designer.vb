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
        Me.btnSubmit1 = New System.Windows.Forms.Button()
        Me.lblText1 = New System.Windows.Forms.Label()
        Me.btnSubmit2 = New System.Windows.Forms.Button()
        Me.btnSubmit3 = New System.Windows.Forms.Button()
        Me.btnSubmit4 = New System.Windows.Forms.Button()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.lblText3 = New System.Windows.Forms.Label()
        Me.lblText4 = New System.Windows.Forms.Label()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSubmit1
        '
        Me.btnSubmit1.Location = New System.Drawing.Point(344, 110)
        Me.btnSubmit1.Name = "btnSubmit1"
        Me.btnSubmit1.Size = New System.Drawing.Size(124, 42)
        Me.btnSubmit1.TabIndex = 0
        Me.btnSubmit1.Text = "Button1"
        Me.btnSubmit1.UseVisualStyleBackColor = True
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Location = New System.Drawing.Point(519, 123)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(51, 17)
        Me.lblText1.TabIndex = 1
        Me.lblText1.Text = "Label1"
        '
        'btnSubmit2
        '
        Me.btnSubmit2.Location = New System.Drawing.Point(344, 174)
        Me.btnSubmit2.Name = "btnSubmit2"
        Me.btnSubmit2.Size = New System.Drawing.Size(124, 42)
        Me.btnSubmit2.TabIndex = 2
        Me.btnSubmit2.Text = "Button2"
        Me.btnSubmit2.UseVisualStyleBackColor = True
        '
        'btnSubmit3
        '
        Me.btnSubmit3.Location = New System.Drawing.Point(344, 249)
        Me.btnSubmit3.Name = "btnSubmit3"
        Me.btnSubmit3.Size = New System.Drawing.Size(124, 42)
        Me.btnSubmit3.TabIndex = 3
        Me.btnSubmit3.Text = "Button3"
        Me.btnSubmit3.UseVisualStyleBackColor = True
        '
        'btnSubmit4
        '
        Me.btnSubmit4.Location = New System.Drawing.Point(344, 326)
        Me.btnSubmit4.Name = "btnSubmit4"
        Me.btnSubmit4.Size = New System.Drawing.Size(124, 42)
        Me.btnSubmit4.TabIndex = 4
        Me.btnSubmit4.Text = "Button4"
        Me.btnSubmit4.UseVisualStyleBackColor = True
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Location = New System.Drawing.Point(519, 187)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(51, 17)
        Me.lblText2.TabIndex = 5
        Me.lblText2.Text = "Label2"
        '
        'lblText3
        '
        Me.lblText3.AutoSize = True
        Me.lblText3.Location = New System.Drawing.Point(519, 262)
        Me.lblText3.Name = "lblText3"
        Me.lblText3.Size = New System.Drawing.Size(51, 17)
        Me.lblText3.TabIndex = 6
        Me.lblText3.Text = "Label3"
        '
        'lblText4
        '
        Me.lblText4.AutoSize = True
        Me.lblText4.Location = New System.Drawing.Point(519, 339)
        Me.lblText4.Name = "lblText4"
        Me.lblText4.Size = New System.Drawing.Size(51, 17)
        Me.lblText4.TabIndex = 7
        Me.lblText4.Text = "Label4"
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(119, 187)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(171, 22)
        Me.txtBox1.TabIndex = 8
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(119, 326)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(171, 22)
        Me.txtBox2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.lblText4)
        Me.Controls.Add(Me.lblText3)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.btnSubmit4)
        Me.Controls.Add(Me.btnSubmit3)
        Me.Controls.Add(Me.btnSubmit2)
        Me.Controls.Add(Me.lblText1)
        Me.Controls.Add(Me.btnSubmit1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit1 As Button
    Friend WithEvents lblText1 As Label
    Friend WithEvents btnSubmit2 As Button
    Friend WithEvents btnSubmit3 As Button
    Friend WithEvents btnSubmit4 As Button
    Friend WithEvents lblText2 As Label
    Friend WithEvents lblText3 As Label
    Friend WithEvents lblText4 As Label
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents txtBox2 As TextBox
End Class
