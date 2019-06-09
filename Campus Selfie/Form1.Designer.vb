<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampusSelfie
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picFinalistCheer = New System.Windows.Forms.PictureBox()
        CType(Me.picFinalistCheer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(37, 13)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(341, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Vote for the Best Campus Selfie"
        '
        'picFinalistCheer
        '
        Me.picFinalistCheer.Location = New System.Drawing.Point(42, 58)
        Me.picFinalistCheer.Name = "picFinalistCheer"
        Me.picFinalistCheer.Size = New System.Drawing.Size(185, 150)
        Me.picFinalistCheer.TabIndex = 1
        Me.picFinalistCheer.TabStop = False
        '
        'frmCampusSelfie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(414, 356)
        Me.Controls.Add(Me.picFinalistCheer)
        Me.Controls.Add(Me.lblHeading)
        Me.ForeColor = System.Drawing.Color.Firebrick
        Me.Name = "frmCampusSelfie"
        Me.Text = "Vote for the Best Campus Selfie"
        CType(Me.picFinalistCheer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picFinalistCheer As PictureBox
End Class
