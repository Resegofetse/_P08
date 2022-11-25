<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nationalpark
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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.txtdisplaydetails = New System.Windows.Forms.TextBox()
        Me.txtdisplaysaved = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(0, 1)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(155, 23)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'txtdisplaydetails
        '
        Me.txtdisplaydetails.Location = New System.Drawing.Point(0, 30)
        Me.txtdisplaydetails.Multiline = True
        Me.txtdisplaydetails.Name = "txtdisplaydetails"
        Me.txtdisplaydetails.Size = New System.Drawing.Size(788, 138)
        Me.txtdisplaydetails.TabIndex = 2
        '
        'txtdisplaysaved
        '
        Me.txtdisplaysaved.Location = New System.Drawing.Point(0, 222)
        Me.txtdisplaysaved.Multiline = True
        Me.txtdisplaysaved.Name = "txtdisplaysaved"
        Me.txtdisplaysaved.Size = New System.Drawing.Size(788, 129)
        Me.txtdisplaysaved.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(35, 193)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(225, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(485, 1)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(173, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(199, 1)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(217, 23)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(485, 193)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(217, 23)
        Me.btnLoad.TabIndex = 7
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'frm_nationalpark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtdisplaysaved)
        Me.Controls.Add(Me.txtdisplaydetails)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "frm_nationalpark"
        Me.Text = "NationalParkManagement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents txtdisplaydetails As TextBox
    Friend WithEvents txtdisplaysaved As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnLoad As Button
End Class
