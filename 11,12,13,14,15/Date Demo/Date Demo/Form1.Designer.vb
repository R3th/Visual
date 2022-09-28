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
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnDateProperties = New System.Windows.Forms.Button()
        Me.btnDateNames = New System.Windows.Forms.Button()
        Me.btnDateLiterals = New System.Windows.Forms.Button()
        Me.btnDateManipulation = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(29, 33)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(198, 23)
        Me.btnShowDate.TabIndex = 0
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnDateProperties
        '
        Me.btnDateProperties.Location = New System.Drawing.Point(44, 62)
        Me.btnDateProperties.Name = "btnDateProperties"
        Me.btnDateProperties.Size = New System.Drawing.Size(170, 23)
        Me.btnDateProperties.TabIndex = 1
        Me.btnDateProperties.Text = "Date Properties"
        Me.btnDateProperties.UseVisualStyleBackColor = True
        '
        'btnDateNames
        '
        Me.btnDateNames.Location = New System.Drawing.Point(78, 91)
        Me.btnDateNames.Name = "btnDateNames"
        Me.btnDateNames.Size = New System.Drawing.Size(104, 23)
        Me.btnDateNames.TabIndex = 2
        Me.btnDateNames.Text = "Date Names"
        Me.btnDateNames.UseVisualStyleBackColor = True
        '
        'btnDateLiterals
        '
        Me.btnDateLiterals.Location = New System.Drawing.Point(64, 120)
        Me.btnDateLiterals.Name = "btnDateLiterals"
        Me.btnDateLiterals.Size = New System.Drawing.Size(130, 23)
        Me.btnDateLiterals.TabIndex = 3
        Me.btnDateLiterals.Text = "Date Literals"
        Me.btnDateLiterals.UseVisualStyleBackColor = True
        '
        'btnDateManipulation
        '
        Me.btnDateManipulation.Location = New System.Drawing.Point(44, 149)
        Me.btnDateManipulation.Name = "btnDateManipulation"
        Me.btnDateManipulation.Size = New System.Drawing.Size(170, 23)
        Me.btnDateManipulation.TabIndex = 4
        Me.btnDateManipulation.Text = "Date Manipulation"
        Me.btnDateManipulation.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.btnDateManipulation)
        Me.Controls.Add(Me.btnDateLiterals)
        Me.Controls.Add(Me.btnDateNames)
        Me.Controls.Add(Me.btnDateProperties)
        Me.Controls.Add(Me.btnShowDate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShowDate As Button
    Friend WithEvents btnDateProperties As Button
    Friend WithEvents btnDateNames As Button
    Friend WithEvents btnDateLiterals As Button
    Friend WithEvents btnDateManipulation As Button
End Class
