<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtHours = New System.Windows.Forms.Label()
        Me.txtP1 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.Label()
        Me.txtP2 = New System.Windows.Forms.Label()
        Me.txtSec = New System.Windows.Forms.Label()
        Me.tmrRefreshForm = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(504, 169)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(95, 27)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Comenzar"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtHours
        '
        Me.txtHours.AutoSize = True
        Me.txtHours.Font = New System.Drawing.Font("Consolas", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(124, 42)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(76, 55)
        Me.txtHours.TabIndex = 1
        Me.txtHours.Text = "00"
        '
        'txtP1
        '
        Me.txtP1.AutoSize = True
        Me.txtP1.Font = New System.Drawing.Font("Consolas", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP1.Location = New System.Drawing.Point(206, 42)
        Me.txtP1.Name = "txtP1"
        Me.txtP1.Size = New System.Drawing.Size(50, 55)
        Me.txtP1.TabIndex = 2
        Me.txtP1.Text = ":"
        '
        'txtMin
        '
        Me.txtMin.AutoSize = True
        Me.txtMin.Font = New System.Drawing.Font("Consolas", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(250, 42)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(76, 55)
        Me.txtMin.TabIndex = 3
        Me.txtMin.Text = "00"
        '
        'txtP2
        '
        Me.txtP2.AutoSize = True
        Me.txtP2.Font = New System.Drawing.Font("Consolas", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP2.Location = New System.Drawing.Point(321, 42)
        Me.txtP2.Name = "txtP2"
        Me.txtP2.Size = New System.Drawing.Size(50, 55)
        Me.txtP2.TabIndex = 4
        Me.txtP2.Text = ":"
        '
        'txtSec
        '
        Me.txtSec.AutoSize = True
        Me.txtSec.Font = New System.Drawing.Font("Consolas", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec.Location = New System.Drawing.Point(377, 42)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(76, 55)
        Me.txtSec.TabIndex = 5
        Me.txtSec.Text = "00"
        '
        'tmrRefreshForm
        '
        Me.tmrRefreshForm.Interval = 1000
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(387, 169)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 27)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reiniciar"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 208)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtSec)
        Me.Controls.Add(Me.txtP2)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtP1)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.btnStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.Text = "Cronómetro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents txtHours As Label
    Friend WithEvents txtP1 As Label
    Friend WithEvents txtMin As Label
    Friend WithEvents txtP2 As Label
    Friend WithEvents txtSec As Label
    Friend WithEvents tmrRefreshForm As Timer
    Friend WithEvents btnReset As Button
End Class
