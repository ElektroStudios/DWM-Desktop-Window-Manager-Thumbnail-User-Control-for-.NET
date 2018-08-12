#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Imports "

Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis
Imports System.Runtime.InteropServices
Imports System.Security

Imports ElektroKit.Interop.Win32.Enums
Imports ElektroKit.Interop.Win32.Types

#End Region

#Region " P/Invoking "

Namespace ElektroKit.Interop.Win32

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Platform Invocation methods (P/Invoke), access unmanaged code.
    ''' <para></para>
    ''' This class does not suppress stack walks for unmanaged code permission.
    ''' <see cref="Global.System.Security.SuppressUnmanagedCodeSecurityAttribute"/> must not be applied to this class.
    ''' <para></para>
    ''' This class is for methods that can be used anywhere because a stack walk will be performed.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <remarks>
    ''' <see href="https://msdn.microsoft.com/en-us/library/ms182161.aspx"/>
    ''' </remarks>
    ''' ----------------------------------------------------------------------------------------------------
    Friend NotInheritable Class NativeMethods

#Region " Constructors "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Prevents a default instance of the <see cref="NativeMethods"/> class from being created.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerNonUserCode>
        Private Sub New()
        End Sub

#End Region

#Region " Hidden Base Members "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Serves as a hash function for a particular type.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DebuggerNonUserCode>
        Public Shadows Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the <see cref="Type"/> of the current instance.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' The exact runtime type of the current instance.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DebuggerNonUserCode>
        Public Shadows Function [GetType]() As Type
            Return MyBase.GetType()
        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Determines whether the specified <see cref="Object"/> is equal to this instance.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="obj">
        ''' Another object to compare to.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' <see langword="True"/> if the specified <see cref="Object"/> is equal to this instance; 
        ''' otherwise, <see langword="False"/>.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DebuggerNonUserCode>
        Public Shadows Function Equals(ByVal obj As Object) As Boolean
            Return MyBase.Equals(obj)
        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Determines whether the specified <see cref="Object"/> instances are considered equal.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="objA">
        ''' The first object to compare.
        ''' </param>
        ''' 
        ''' <param name="objB">
        ''' The second object to compare.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' <see langword="True"/> if the objects are considered equal; otherwise, <see langword="False"/>.
        ''' <para></para>
        ''' If both <paramref name="objA"/> and <paramref name="objB"/> are <see langword="Nothing"/>, 
        ''' the method returns <see langword="True"/>.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DebuggerNonUserCode>
        Public Shared Shadows Function Equals(ByVal objA As Object, ByVal objB As Object) As Boolean
            Return Object.Equals(objA, objB)
        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Determines whether the specified <see cref="Object"/> instances are the same instance.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="objA">
        ''' The first object to compare.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="objB">
        ''' The second object to compare.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' <see langword="True"/> if <paramref name="objA"/> is the same instance as <paramref name="objB"/> 
        ''' or if both are <see langword="Nothing"/>; otherwise, <see langword="False"/>.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DebuggerNonUserCode>
        Public Shared Shadows Function ReferenceEquals(ByVal objA As Object, ByVal objB As Object) As Boolean
            Return Object.ReferenceEquals(objA, objB)
        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Returns a String that represents the current object.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' A string that represents the current object.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DebuggerNonUserCode>
        Public Overrides Function ToString() As String
            Return MyBase.ToString()
        End Function

#End Region

#Region " DWMAPI "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Retrieves the current value of a specified attribute applied to a window.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa969515%28v=vs.85%29.aspx"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="hwnd">
        ''' The handle to the window from which the attribute data is retrieved.
        ''' </param>
        ''' 
        ''' <param name="attribute">
        ''' The attribute to retrieve
        ''' </param>
        ''' 
        ''' <param name="refAttribute">
        ''' A pointer to a value that, when this function returns successfully, receives the current value of the attribute.
        ''' <para></para>
        ''' The type of the retrieved value depends on the value of the <paramref name="attribute"/> parameter.
        ''' </param>
        ''' 
        ''' <param name="sizeAttribute">
        ''' The size of the <see cref="DwmWindowAttribute"/> value being retrieved.
        ''' <para></para>
        ''' The size is dependent on the type of the <paramref name="refAttribute"/> parameter.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' If this function succeeds, it returns <see cref="HResult.S_OK"/>. 
        ''' Otherwise, it returns an HRESULT error code.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <SuppressUnmanagedCodeSecurity>
        <DllImport("DwmApi.dll", SetLastError:=False)>
        Friend Shared Function DwmGetWindowAttribute(ByVal hwnd As IntPtr,
                                                     ByVal attribute As DwmWindowAttribute,
                                                     ByRef refAttribute As NativeRectangle,
                                                     ByVal sizeAttribute As Integer
        ) As Integer
        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Creates a Desktop Window Manager (DWM) thumbnail relationship between the destination and source windows.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="https://docs.microsoft.com/en-us/windows/desktop/api/dwmapi/nf-dwmapi-dwmregisterthumbnail"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="dstHwnd">
        ''' The handle to the window that will use the DWM thumbnail. 
        ''' <para></para>
        ''' Setting the destination window handle to anything other than a top-level window type will result in a 
        ''' return value of <see cref="HResult.E_INVALIDARG"/>.
        ''' </param>
        ''' 
        ''' <param name="srcHwnd">
        ''' The handle to the window to use as the thumbnail source. 
        ''' <para></para>
        ''' Setting the source window handle to anything other than a top-level window type will result in a 
        ''' return value of <see cref="HResult.E_INVALIDARG"/>.
        ''' </param>
        ''' 
        ''' <param name="refThumbnailId">
        ''' A pointer to a handle that, when this function returns successfully, 
        ''' represents the registration of the DWM thumbnail.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' If this function succeeds, it returns <see cref="HResult.S_OK"/>. 
        ''' Otherwise, it returns an <see cref="HResult"/> error code.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <SuppressUnmanagedCodeSecurity>
        <DllImport("DwmApi.dll", SetLastError:=True)>
        Friend Shared Function DwmRegisterThumbnail(ByVal dstHwnd As IntPtr,
                                                    ByVal srcHwnd As IntPtr,
                                                    ByRef refThumbnailId As IntPtr
        ) As HResult
        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Removes a Desktop Window Manager (DWM) thumbnail relationship previously created by the 
        ''' <see cref="NativeMethods.DwmRegisterThumbnail"/> function.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="https://docs.microsoft.com/en-us/windows/desktop/api/dwmapi/nf-dwmapi-dwmunregisterthumbnail"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="thumbnailId">
        ''' The handle to the thumbnail relationship to be removed. 
        ''' <para></para>
        ''' A value of <see cref="IntPtr.Zero"/> or invalid thumbnail handles will result in a return value of 
        ''' <see cref="HResult.E_INVALIDARG"/>.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' If this function succeeds, it returns <see cref="HResult.S_OK"/>. 
        ''' Otherwise, it returns an <see cref="HResult"/> error code.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <SuppressUnmanagedCodeSecurity>
        <DllImport("DwmApi.dll", SetLastError:=True)>
        Friend Shared Function DwmUnregisterThumbnail(ByVal thumbnailId As IntPtr
        ) As HResult
        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Updates the properties for a Desktop Window Manager (DWM) thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="https://docs.microsoft.com/en-us/windows/desktop/api/dwmapi/nf-dwmapi-dwmupdatethumbnailproperties"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="thumbnailId">
        ''' The handle to the DWM thumbnail to be updated. 
        ''' <para></para>
        ''' A value of <see cref="IntPtr.Zero"/> or invalid thumbnail handles, 
        ''' as well as thumbnails owned by other processes will result in a return value of <see cref="HResult.E_INVALIDARG"/>.
        ''' </param>
        ''' 
        ''' <param name="refThumbnailProperties">
        ''' A pointer to a <see cref="DwmThumbnailProperties"/> structure that contains the new thumbnail properties.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' If this function succeeds, it returns <see cref="HResult.S_OK"/>. 
        ''' Otherwise, it returns an <see cref="HResult"/> error code.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <SuppressUnmanagedCodeSecurity>
        <DllImport("DwmApi.dll", PreserveSig:=True, SetLastError:=True)>
        Friend Shared Function DwmUpdateThumbnailProperties(ByVal thumbnailId As IntPtr,
                                                            ByRef refThumbnailProperties As DwmThumbnailProperties
        ) As HResult
        End Function

#End Region

#Region " USER32 "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Retrieves the dimensions of the bounding rectangle of the specified window. 
        ''' <para></para>
        ''' The dimensions are given in screen coordinates that are relative to the upper-left corner of the screen.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="https://msdn.microsoft.com/es-es/library/windows/desktop/ms633519%28v=vs.85%29.aspx"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="hwnd">
        ''' A <see cref="IntPtr"/> handle to the window.
        ''' </param>
        ''' 
        ''' <param name="refRect">
        ''' A pointer to a <see cref="NativeRectangle"/> structure that receives the screen coordinates of the 
        ''' upper-left and lower-right corners of the window.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' <see langword="True"/> if the function succeeds, <see langword="False"/> otherwise.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <SuppressUnmanagedCodeSecurity>
        <DllImport("User32.dll", SetLastError:=True)>
        Friend Shared Function GetWindowRect(ByVal hwnd As IntPtr,
                                       <Out> ByRef refRect As NativeRectangle
        ) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Determines whether the specified window handle identifies an existing window.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="https://msdn.microsoft.com/en-us/library/windows/desktop/ms633528%28v=vs.85%29.aspx"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="hwnd">
        ''' A handle to the window to be tested. 
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' If the window handle identifies an existing window, the return value is <see langword="True"/>.
        ''' <para></para>
        ''' If the window handle does not identify an existing window, the return value is <see langword="False"/>.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <SuppressUnmanagedCodeSecurity>
        <DllImport("User32.dll", SetLastError:=True)>
        Friend Shared Function IsWindow(ByVal hwnd As IntPtr
        ) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Determines the visibility state of the specified window.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="https://msdn.microsoft.com/en-us/library/windows/desktop/ms633530%28v=vs.85%29.aspx"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="hwnd">
        ''' A handle to the window to be tested. 
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <returns>
        ''' If the specified window, its parent window, its parent's parent window, and so forth, 
        ''' have the <c>WS_VISIBLE</c> style, the return value is <see langword="True"/>.
        ''' <para></para>
        ''' Otherwise, the return value is <see langword="False"/>.
        ''' <para></para>
        ''' Because the return value specifies whether the window has the WS_VISIBLE style, 
        ''' it may be nonzero even if the window is totally obscured by other windows.
        ''' </returns>
        ''' ----------------------------------------------------------------------------------------------------
        <SuppressUnmanagedCodeSecurity>
        <DllImport("User32.dll", SetLastError:=True)>
        Friend Shared Function IsWindowVisible(ByVal hwnd As IntPtr
        ) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

#End Region

    End Class

End Namespace

#End Region
