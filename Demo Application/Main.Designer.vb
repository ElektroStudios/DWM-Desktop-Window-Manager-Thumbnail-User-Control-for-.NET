<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main : Inherits System.Windows.Forms.Form

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
        Me.Button_Register = New System.Windows.Forms.Button()
        Me.Button_Unregister = New System.Windows.Forms.Button()
        Me.Button_Show = New System.Windows.Forms.Button()
        Me.Button_Hide = New System.Windows.Forms.Button()
        Me.Button_AspectRatioEnable = New System.Windows.Forms.Button()
        Me.Button_AspectRatioDisable = New System.Windows.Forms.Button()
        Me.Button_AddTransparency = New System.Windows.Forms.Button()
        Me.Button_MakeOpaque = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button_HideNonClientArea = New System.Windows.Forms.Button()
        Me.Button_ShowNonClientArea = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ElektroDwmThumbnail1 = New ElektroKit.UserControls.Controls.ElektroDwmThumbnail()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Register
        '
        Me.Button_Register.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Register.Enabled = False
        Me.Button_Register.Location = New System.Drawing.Point(12, 12)
        Me.Button_Register.Name = "Button_Register"
        Me.Button_Register.Size = New System.Drawing.Size(128, 32)
        Me.Button_Register.TabIndex = 1
        Me.Button_Register.Text = "Register Thumbnail"
        Me.Button_Register.UseVisualStyleBackColor = False
        '
        'Button_Unregister
        '
        Me.Button_Unregister.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Unregister.Enabled = False
        Me.Button_Unregister.Location = New System.Drawing.Point(12, 58)
        Me.Button_Unregister.Name = "Button_Unregister"
        Me.Button_Unregister.Size = New System.Drawing.Size(128, 32)
        Me.Button_Unregister.TabIndex = 2
        Me.Button_Unregister.Text = "Unregister Thumbnail"
        Me.Button_Unregister.UseVisualStyleBackColor = False
        '
        'Button_Show
        '
        Me.Button_Show.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Show.Enabled = False
        Me.Button_Show.Location = New System.Drawing.Point(12, 119)
        Me.Button_Show.Name = "Button_Show"
        Me.Button_Show.Size = New System.Drawing.Size(128, 32)
        Me.Button_Show.TabIndex = 3
        Me.Button_Show.Text = "Show Thumbnail"
        Me.Button_Show.UseVisualStyleBackColor = False
        '
        'Button_Hide
        '
        Me.Button_Hide.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Hide.Enabled = False
        Me.Button_Hide.Location = New System.Drawing.Point(12, 165)
        Me.Button_Hide.Name = "Button_Hide"
        Me.Button_Hide.Size = New System.Drawing.Size(128, 32)
        Me.Button_Hide.TabIndex = 4
        Me.Button_Hide.Text = "Hide Thumbnail"
        Me.Button_Hide.UseVisualStyleBackColor = False
        '
        'Button_AspectRatioEnable
        '
        Me.Button_AspectRatioEnable.BackColor = System.Drawing.SystemColors.Control
        Me.Button_AspectRatioEnable.Enabled = False
        Me.Button_AspectRatioEnable.Location = New System.Drawing.Point(12, 226)
        Me.Button_AspectRatioEnable.Name = "Button_AspectRatioEnable"
        Me.Button_AspectRatioEnable.Size = New System.Drawing.Size(128, 32)
        Me.Button_AspectRatioEnable.TabIndex = 5
        Me.Button_AspectRatioEnable.Text = "Keep Aspect Ratio"
        Me.Button_AspectRatioEnable.UseVisualStyleBackColor = False
        '
        'Button_AspectRatioDisable
        '
        Me.Button_AspectRatioDisable.BackColor = System.Drawing.SystemColors.Control
        Me.Button_AspectRatioDisable.Enabled = False
        Me.Button_AspectRatioDisable.Location = New System.Drawing.Point(12, 272)
        Me.Button_AspectRatioDisable.Name = "Button_AspectRatioDisable"
        Me.Button_AspectRatioDisable.Size = New System.Drawing.Size(128, 32)
        Me.Button_AspectRatioDisable.TabIndex = 6
        Me.Button_AspectRatioDisable.Text = "Ignore Aspect Ratio"
        Me.Button_AspectRatioDisable.UseVisualStyleBackColor = False
        '
        'Button_AddTransparency
        '
        Me.Button_AddTransparency.BackColor = System.Drawing.SystemColors.Control
        Me.Button_AddTransparency.Enabled = False
        Me.Button_AddTransparency.Location = New System.Drawing.Point(12, 333)
        Me.Button_AddTransparency.Name = "Button_AddTransparency"
        Me.Button_AddTransparency.Size = New System.Drawing.Size(128, 32)
        Me.Button_AddTransparency.TabIndex = 7
        Me.Button_AddTransparency.Text = "Add 10% Transparency"
        Me.Button_AddTransparency.UseVisualStyleBackColor = False
        '
        'Button_MakeOpaque
        '
        Me.Button_MakeOpaque.BackColor = System.Drawing.SystemColors.Control
        Me.Button_MakeOpaque.Enabled = False
        Me.Button_MakeOpaque.Location = New System.Drawing.Point(12, 379)
        Me.Button_MakeOpaque.Name = "Button_MakeOpaque"
        Me.Button_MakeOpaque.Size = New System.Drawing.Size(128, 32)
        Me.Button_MakeOpaque.TabIndex = 8
        Me.Button_MakeOpaque.Text = "Make it Opaque"
        Me.Button_MakeOpaque.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox1.Location = New System.Drawing.Point(12, 578)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 26)
        Me.TextBox1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(12, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 1)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox2.Location = New System.Drawing.Point(12, 211)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 1)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox3.Location = New System.Drawing.Point(12, 318)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 1)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox4.Location = New System.Drawing.Point(12, 532)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(128, 1)
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 555)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Process Name:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_HideNonClientArea)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_ShowNonClientArea)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Register)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Unregister)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Show)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Hide)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_AspectRatioEnable)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_AspectRatioDisable)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_AddTransparency)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_MakeOpaque)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.SplitContainer1.Panel2.Controls.Add(Me.ElektroDwmThumbnail1)
        Me.SplitContainer1.Size = New System.Drawing.Size(792, 622)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 16
        '
        'Button_HideNonClientArea
        '
        Me.Button_HideNonClientArea.BackColor = System.Drawing.SystemColors.Control
        Me.Button_HideNonClientArea.Enabled = False
        Me.Button_HideNonClientArea.Location = New System.Drawing.Point(12, 486)
        Me.Button_HideNonClientArea.Name = "Button_HideNonClientArea"
        Me.Button_HideNonClientArea.Size = New System.Drawing.Size(128, 32)
        Me.Button_HideNonClientArea.TabIndex = 17
        Me.Button_HideNonClientArea.Text = "Hide non-client area"
        Me.Button_HideNonClientArea.UseVisualStyleBackColor = False
        '
        'Button_ShowNonClientArea
        '
        Me.Button_ShowNonClientArea.BackColor = System.Drawing.SystemColors.Control
        Me.Button_ShowNonClientArea.Enabled = False
        Me.Button_ShowNonClientArea.Location = New System.Drawing.Point(12, 440)
        Me.Button_ShowNonClientArea.Name = "Button_ShowNonClientArea"
        Me.Button_ShowNonClientArea.Size = New System.Drawing.Size(128, 32)
        Me.Button_ShowNonClientArea.TabIndex = 16
        Me.Button_ShowNonClientArea.Text = "Show non-client area"
        Me.Button_ShowNonClientArea.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox5.Location = New System.Drawing.Point(12, 425)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(128, 1)
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'ElektroDwmThumbnail1
        '
        Me.ElektroDwmThumbnail1.BackColor = System.Drawing.Color.Transparent
        Me.ElektroDwmThumbnail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ElektroDwmThumbnail1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElektroDwmThumbnail1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ElektroDwmThumbnail1.KeepAspectRatio = True
        Me.ElektroDwmThumbnail1.Location = New System.Drawing.Point(0, 0)
        Me.ElektroDwmThumbnail1.Name = "ElektroDwmThumbnail1"
        Me.ElektroDwmThumbnail1.NonClientAreaVisible = False
        Me.ElektroDwmThumbnail1.Offset = New System.Drawing.Point(0, 0)
        Me.ElektroDwmThumbnail1.Size = New System.Drawing.Size(636, 622)
        Me.ElektroDwmThumbnail1.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(792, 622)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ElektroDwmThumbnail Demo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElektroDwmThumbnail1 As ElektroKit.UserControls.Controls.ElektroDwmThumbnail
    Friend WithEvents Button_Register As Button
    Friend WithEvents Button_Unregister As Button
    Friend WithEvents Button_Show As Button
    Friend WithEvents Button_Hide As Button
    Friend WithEvents Button_AspectRatioEnable As Button
    Friend WithEvents Button_AspectRatioDisable As Button
    Friend WithEvents Button_AddTransparency As Button
    Friend WithEvents Button_MakeOpaque As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button_HideNonClientArea As Button
    Friend WithEvents Button_ShowNonClientArea As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class
