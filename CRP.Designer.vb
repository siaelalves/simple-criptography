<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRP
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
        Me.txtNtx = New System.Windows.Forms.RichTextBox()
        Me.txtCtx = New System.Windows.Forms.RichTextBox()
        Me.cmdCry = New System.Windows.Forms.Button()
        Me.cmdDecry = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNtx
        '
        Me.txtNtx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNtx.Location = New System.Drawing.Point(12, 12)
        Me.txtNtx.Name = "txtNtx"
        Me.txtNtx.Size = New System.Drawing.Size(196, 212)
        Me.txtNtx.TabIndex = 0
        Me.txtNtx.Text = ""
        '
        'txtCtx
        '
        Me.txtCtx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtx.Location = New System.Drawing.Point(321, 12)
        Me.txtCtx.Name = "txtCtx"
        Me.txtCtx.Size = New System.Drawing.Size(187, 212)
        Me.txtCtx.TabIndex = 1
        Me.txtCtx.Text = ""
        '
        'cmdCry
        '
        Me.cmdCry.Location = New System.Drawing.Point(214, 182)
        Me.cmdCry.Name = "cmdCry"
        Me.cmdCry.Size = New System.Drawing.Size(101, 42)
        Me.cmdCry.TabIndex = 2
        Me.cmdCry.Text = "Criptografar"
        Me.cmdCry.UseVisualStyleBackColor = True
        '
        'cmdDecry
        '
        Me.cmdDecry.Location = New System.Drawing.Point(214, 134)
        Me.cmdDecry.Name = "cmdDecry"
        Me.cmdDecry.Size = New System.Drawing.Size(101, 42)
        Me.cmdDecry.TabIndex = 3
        Me.cmdDecry.Text = "Descriptografar"
        Me.cmdDecry.UseVisualStyleBackColor = True
        '
        'CRP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 240)
        Me.Controls.Add(Me.cmdDecry)
        Me.Controls.Add(Me.cmdCry)
        Me.Controls.Add(Me.txtCtx)
        Me.Controls.Add(Me.txtNtx)
        Me.Name = "CRP"
        Me.Text = "Criptografia"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNtx As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCtx As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdCry As System.Windows.Forms.Button
    Friend WithEvents cmdDecry As System.Windows.Forms.Button

End Class
