<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Me.tabMenu = New System.Windows.Forms.TabControl()
        Me.tabChrono = New System.Windows.Forms.TabPage()
        Me.tabCounter = New System.Windows.Forms.TabPage()
        Me.tabMenu.SuspendLayout()
        Me.tabChrono.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(22, 82)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(127, 43)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start ▶️"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtHours
        '
        Me.txtHours.AutoSize = True
        Me.txtHours.Font = New System.Drawing.Font("Consolas", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(187, 48)
        Me.txtHours.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(134, 98)
        Me.txtHours.TabIndex = 1
        Me.txtHours.Text = "00"
        '
        'txtP1
        '
        Me.txtP1.AutoSize = True
        Me.txtP1.Font = New System.Drawing.Font("Consolas", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP1.Location = New System.Drawing.Point(289, 48)
        Me.txtP1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtP1.Name = "txtP1"
        Me.txtP1.Size = New System.Drawing.Size(88, 98)
        Me.txtP1.TabIndex = 2
        Me.txtP1.Text = ":"
        '
        'txtMin
        '
        Me.txtMin.AutoSize = True
        Me.txtMin.Font = New System.Drawing.Font("Consolas", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(341, 48)
        Me.txtMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(134, 98)
        Me.txtMin.TabIndex = 3
        Me.txtMin.Text = "00"
        Me.txtMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtP2
        '
        Me.txtP2.AutoSize = True
        Me.txtP2.Font = New System.Drawing.Font("Consolas", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP2.Location = New System.Drawing.Point(448, 49)
        Me.txtP2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtP2.Name = "txtP2"
        Me.txtP2.Size = New System.Drawing.Size(88, 98)
        Me.txtP2.TabIndex = 4
        Me.txtP2.Text = ":"
        '
        'txtSec
        '
        Me.txtSec.AutoSize = True
        Me.txtSec.Font = New System.Drawing.Font("Consolas", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec.Location = New System.Drawing.Point(502, 49)
        Me.txtSec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(134, 98)
        Me.txtSec.TabIndex = 5
        Me.txtSec.Text = "00"
        '
        'tmrRefreshForm
        '
        Me.tmrRefreshForm.Interval = 1000
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(22, 149)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 33)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset ⏹️"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'tabMenu
        '
        Me.tabMenu.Controls.Add(Me.tabChrono)
        Me.tabMenu.Controls.Add(Me.tabCounter)
        Me.tabMenu.Location = New System.Drawing.Point(12, 12)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(673, 218)
        Me.tabMenu.TabIndex = 7
        '
        'tabChrono
        '
        Me.tabChrono.Controls.Add(Me.btnStart)
        Me.tabChrono.Controls.Add(Me.txtSec)
        Me.tabChrono.Controls.Add(Me.btnReset)
        Me.tabChrono.Controls.Add(Me.txtP2)
        Me.tabChrono.Controls.Add(Me.txtHours)
        Me.tabChrono.Controls.Add(Me.txtMin)
        Me.tabChrono.Controls.Add(Me.txtP1)
        Me.tabChrono.Location = New System.Drawing.Point(4, 25)
        Me.tabChrono.Name = "tabChrono"
        Me.tabChrono.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChrono.Size = New System.Drawing.Size(665, 189)
        Me.tabChrono.TabIndex = 0
        Me.tabChrono.Text = "Chronometer"
        Me.tabChrono.UseVisualStyleBackColor = True
        '
        'tabCounter
        '
        Me.tabCounter.Location = New System.Drawing.Point(4, 25)
        Me.tabCounter.Name = "tabCounter"
        Me.tabCounter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCounter.Size = New System.Drawing.Size(665, 189)
        Me.tabCounter.TabIndex = 1
        Me.tabCounter.Text = "Counter"
        Me.tabCounter.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 242)
        Me.Controls.Add(Me.tabMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.Text = "Chronometer"
        Me.tabMenu.ResumeLayout(False)
        Me.tabChrono.ResumeLayout(False)
        Me.tabChrono.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents txtHours As Label
    Friend WithEvents txtP1 As Label
    Friend WithEvents txtMin As Label
    Friend WithEvents txtP2 As Label
    Friend WithEvents txtSec As Label
    Friend WithEvents tmrRefreshForm As Timer
    Friend WithEvents btnReset As Button
    Friend WithEvents tabMenu As TabControl
    Friend WithEvents tabChrono As TabPage
    Friend WithEvents tabCounter As TabPage
End Class
