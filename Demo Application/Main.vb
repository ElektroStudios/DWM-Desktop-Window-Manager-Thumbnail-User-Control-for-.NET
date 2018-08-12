Imports ElektroKit.Interop.Win32

Public NotInheritable Class Main : Inherits Form

    Private targetHwnd As IntPtr

    Private Sub Main_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(Me.SplitContainer1.Panel1.Width * 2, Me.Height)
        Me.SplitContainer1.Panel1MinSize = Me.SplitContainer1.Panel1.Width
    End Sub

    Private Sub Main_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
        Me.TextBox1.Text = "notepad"
    End Sub

    Private Sub Button_Register_Click(sender As Object, e As EventArgs) Handles Button_Register.Click
        Try
            Me.ElektroDwmThumbnail1.RegisterThumbnail(Me.targetHwnd)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_Unregister_Click(sender As Object, e As EventArgs) Handles Button_Unregister.Click
        Try
            Me.ElektroDwmThumbnail1.UnregisterThumbnail()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_Show_Click(sender As Object, e As EventArgs) Handles Button_Show.Click
        Me.ElektroDwmThumbnail1.Visible = True
    End Sub

    Private Sub Button_Hide_Click(sender As Object, e As EventArgs) Handles Button_Hide.Click
        Me.ElektroDwmThumbnail1.Visible = False
    End Sub

    Private Sub Button_AspectRatioEnable_Click(sender As Object, e As EventArgs) Handles Button_AspectRatioEnable.Click
        Me.ElektroDwmThumbnail1.KeepAspectRatio = True
    End Sub

    Private Sub Button_AspectRatioDisable_Click(sender As Object, e As EventArgs) Handles Button_AspectRatioDisable.Click
        Me.ElektroDwmThumbnail1.KeepAspectRatio = False
    End Sub

    Private Sub Button_AddTransparency_Click(sender As Object, e As EventArgs) Handles Button_AddTransparency.Click
        Me.ElektroDwmThumbnail1.Opacity -= 0.1R
    End Sub

    Private Sub Button_MakeOpaque_Click(sender As Object, e As EventArgs) Handles Button_MakeOpaque.Click
        Me.ElektroDwmThumbnail1.Opacity = 1.0R
    End Sub

    Private Sub Button_ShowNonClientArea_Click(sender As Object, e As EventArgs) Handles Button_ShowNonClientArea.Click
        Me.ElektroDwmThumbnail1.NonClientAreaVisible = True
    End Sub

    Private Sub Button_HideNonClientArea_Click(sender As Object, e As EventArgs) Handles Button_HideNonClientArea.Click
        Me.ElektroDwmThumbnail1.NonClientAreaVisible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim p As Process = Process.GetProcessesByName(tb.Text).FirstOrDefault()

        If (p Is Nothing) Then
            Me.ErrorProvider1.SetError(tb, "Process not found with the specified name.")
            For Each bt As Button In Me.SplitContainer1.Panel1.Controls.OfType(Of Button)
                bt.Enabled = False
            Next

        Else
            Me.ErrorProvider1.SetError(tb, String.Empty)
            Me.targetHwnd = p.MainWindowHandle
            For Each bt As Button In Me.SplitContainer1.Panel1.Controls.OfType(Of Button)
                bt.Enabled = True
            Next

        End If

    End Sub

End Class