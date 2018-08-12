#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Imports "

Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows

Imports ElektroKit.Core.System.Tools
Imports ElektroKit.Interop
Imports ElektroKit.Interop.Win32
Imports ElektroKit.Interop.Win32.Enums
Imports ElektroKit.Interop.Win32.Types

#End Region

#Region " Image Util "

Namespace ElektroKit.Core.Imaging.Tools

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Contains image related utilities.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------   
    Public NotInheritable Class ImageUtil

#Region " Constructors "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Prevents a default instance of the <see cref="ImageUtil"/> class from being created.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerNonUserCode>
        Private Sub New()
        End Sub

#End Region

#Region " Public Methods "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the (non-client) <see cref="Rectangle"/> of a window.
        ''' <para></para>
        ''' This method supports a borderless <c>Windows 10</c> window.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="hwnd">
        ''' A handle to the window.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' The resulting (non-client) <see cref="Rectangle"/> of the window.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Shared Function GetRealWindowRect(ByVal hwnd As IntPtr) As Rectangle

            Dim rc As NativeRectangle = Rectangle.Empty

            If (WindowsUtil.IsWin10) Then
                Dim hResult As Integer
                hResult = NativeMethods.DwmGetWindowAttribute(hwnd, DwmWindowAttribute.ExtendedFrameBounds, rc, Marshal.SizeOf(rc))
                If (DirectCast(hResult, HResult) <> Win32.Enums.HResult.S_OK) Then
                    Marshal.ThrowExceptionForHR(hResult)
                End If

            Else
                Dim success As Boolean
                Dim win32Err As Integer
                success = NativeMethods.GetWindowRect(hwnd, rc)
                win32Err = Marshal.GetLastWin32Error()
                If Not (success) Then
                    Throw New Win32Exception(win32Err)
                End If

            End If

            Return rc

        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the (non-client) <see cref="Rectangle"/> of a window.
        ''' <para></para>
        ''' This method supports a borderless <c>Windows 10</c> window.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="window">
        ''' The window.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' The resulting (non-client) <see cref="Rectangle"/> of the window.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Shared Function GetRealWindowRect(ByVal window As Forms.IWin32Window) As Rectangle

            Return ImageUtil.GetRealWindowRect(window.Handle)

        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the (non-client) <see cref="Rectangle"/> of a window.
        ''' <para></para>
        ''' This method supports a borderless <c>Windows 10</c> window.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="form">
        ''' The Form.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' The resulting (non-client) <see cref="Rectangle"/> of the window.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Shared Function GetRealWindowRect(ByVal form As Form) As Rectangle

            Return ImageUtil.GetRealWindowRect(DirectCast(form, Forms.IWin32Window).Handle)

        End Function

#End Region

    End Class

End Namespace

#End Region
