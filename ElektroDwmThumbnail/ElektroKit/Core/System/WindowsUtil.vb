#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Imports "

Imports Microsoft.Win32

#End Region

#Region " WindowsUtil "

Namespace ElektroKit.Core.System.Tools

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Contains operating system info.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    Public NotInheritable Class WindowsUtil

#Region " Constructors "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Prevents a default instance of the <see cref="WindowsUtil"/> class from being created.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerNonUserCode>
        Private Sub New()
        End Sub

#End Region

#Region " Properties "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets a value that determines whether the current operating system is <c>Windows 10</c>.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <example> This is a code example.
        ''' <code>
        ''' If IsWin10 Then
        '''     Throw New PlatformNotSupportedException("This application cannot run under Windows 10.")
        ''' End If
        ''' </code>
        ''' </example>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <value>
        ''' A value that determines whether the current operating system is <c>Windows 10</c>.
        ''' </value>
        ''' ----------------------------------------------------------------------------------------------------
        Public Shared ReadOnly Property IsWin10() As Boolean
            <DebuggerStepThrough>
            Get
                Return (Environment.OSVersion.Platform = PlatformID.Win32NT) AndAlso
                       (WindowsUtil.InternalIsWin10())
            End Get
        End Property

#End Region

#Region " Private Methods "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Determines whether the current operating system is <c>Windows 10</c>.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="https://msdn.microsoft.com/es-es/library/windows/desktop/dn424972%28v=vs.85%29.aspx"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' <see langword="True"/> if the current operating system is <c>Windows 10</c>; otherwise, <see langword="False"/>.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Private Shared Function InternalIsWin10() As Boolean

            Using reg As RegistryKey = Microsoft.Win32.Registry.LocalMachine.
                                       OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", writable:=False)

                Dim productName As String = DirectCast(reg.GetValue("ProductName", "Empty", RegistryValueOptions.None), String)
                Return productName.StartsWith("Windows 10", StringComparison.OrdinalIgnoreCase)

            End Using

        End Function

#End Region

    End Class

End Namespace

#End Region
