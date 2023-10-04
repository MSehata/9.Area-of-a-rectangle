<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnCalculateArea = New Button()
        lblHeight = New Label()
        lblLenth = New Label()
        txtHeight = New TextBox()
        txtLength = New TextBox()
        txtArea = New TextBox()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' btnCalculateArea
        ' 
        btnCalculateArea.Location = New Point(173, 199)
        btnCalculateArea.Name = "btnCalculateArea"
        btnCalculateArea.Size = New Size(94, 29)
        btnCalculateArea.TabIndex = 0
        btnCalculateArea.Text = "Calculate Aea"
        btnCalculateArea.UseVisualStyleBackColor = True
        ' 
        ' lblHeight
        ' 
        lblHeight.AutoSize = True
        lblHeight.Location = New Point(173, 95)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(54, 20)
        lblHeight.TabIndex = 1
        lblHeight.Text = "Height"
        ' 
        ' lblLenth
        ' 
        lblLenth.AutoSize = True
        lblLenth.Location = New Point(173, 138)
        lblLenth.Name = "lblLenth"
        lblLenth.Size = New Size(54, 20)
        lblLenth.TabIndex = 2
        lblLenth.Text = "Length"
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(357, 94)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(125, 27)
        txtHeight.TabIndex = 3
        ' 
        ' txtLength
        ' 
        txtLength.Location = New Point(357, 138)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(125, 27)
        txtLength.TabIndex = 3
        ' 
        ' txtArea
        ' 
        txtArea.Location = New Point(357, 199)
        txtArea.Name = "txtArea"
        txtArea.Size = New Size(125, 27)
        txtArea.TabIndex = 3
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(322, 300)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 4
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(txtArea)
        Controls.Add(txtLength)
        Controls.Add(txtHeight)
        Controls.Add(lblLenth)
        Controls.Add(lblHeight)
        Controls.Add(btnCalculateArea)
        Name = "Form1"
        Text = "Area of A rectangle"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculateArea As Button
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblLenth As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents btnClose As Button
End Class
