<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.wb1 = New System.Windows.Forms.WebBrowser()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtBrowser = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wb1
        '
        Me.wb1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wb1.Location = New System.Drawing.Point(2, 42)
        Me.wb1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb1.Name = "wb1"
        Me.wb1.Size = New System.Drawing.Size(722, 360)
        Me.wb1.TabIndex = 0
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(675, 12)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(37, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtBrowser
        '
        Me.txtBrowser.Location = New System.Drawing.Point(12, 12)
        Me.txtBrowser.Name = "txtBrowser"
        Me.txtBrowser.Size = New System.Drawing.Size(657, 20)
        Me.txtBrowser.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(724, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Ready"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 447)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtBrowser)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.wb1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Moogila"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wb1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtBrowser As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class
