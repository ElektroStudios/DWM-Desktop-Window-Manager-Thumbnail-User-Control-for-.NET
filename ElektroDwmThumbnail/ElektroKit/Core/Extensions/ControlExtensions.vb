#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Imports "

Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports WinForms = System.Windows.Forms

#End Region

#Region " Control Extensions "

Namespace ElektroKit.Core.Extensions.[Control]

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Contains custom extension methods to use with <see cref="WinForms.Control"/>.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    <HideModuleName>
    Public Module ControlExtensions

#Region " Public Extension Methods "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the bounds of the source <see cref="WinForms.Control"/> relatively to its parent <see cref="WinForms.Form"/>.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <example> This is a code example.
        ''' <code>
        ''' Dim ctrl As New Label
        ''' Dim rc As Rectangle = ctrl.GetBoundsRelativeToForm()
        ''' Console.WriteLine(rc.ToString())
        ''' </code>
        ''' </example>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="sender">
        ''' The source <see cref="WinForms.Control"/>.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' The bounds of the source <see cref="WinForms.Control"/> relatively to its parent <see cref="WinForms.Form"/>.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        <Extension>
        <EditorBrowsable(EditorBrowsableState.Always)>
        Public Function GetBoundsRelativeToForm(ByVal sender As WinForms.Control) As Rectangle

            If (sender Is Nothing) OrElse (sender.IsDisposed) Then
                Throw New ArgumentNullException(NameOf(sender))
            End If

            Dim form As WinForms.Form = sender.FindForm()
            If (form Is Nothing) Then
                Throw New InvalidOperationException("The control is not hosted inside a Form.")
            End If

            Dim parent As WinForms.Control = sender.Parent
            If (parent Is Nothing) Then
                Throw New InvalidOperationException("The control does not have a parent.")
            End If

            Dim p1 As Point = parent.PointToScreen(sender.Location)
            Dim p2 As Point = form.PointToScreen(Point.Empty)

            Return New Rectangle(New Point(p1.X - p2.X, p1.Y - p2.Y), sender.Size)

        End Function

#End Region

    End Module

End Namespace

#End Region
