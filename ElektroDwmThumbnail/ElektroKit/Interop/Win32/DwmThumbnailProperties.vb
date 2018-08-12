#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Imports "

Imports System.Runtime.InteropServices

Imports ElektroKit.Interop.Win32.Enums

#End Region

#Region " DwmThumbnailProperties "

Namespace ElektroKit.Interop.Win32.Types

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Specifies Desktop Window Manager (DWM) thumbnail properties. 
    ''' <para></para>
    ''' Used by the <see cref="NativeMethods.DwmUpdateThumbnailProperties"/> function.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <remarks>
    ''' <see href="https://docs.microsoft.com/en-us/windows/desktop/api/dwmapi/ns-dwmapi-_dwm_thumbnail_properties"/>
    ''' </remarks>
    ''' ----------------------------------------------------------------------------------------------------
    <DebuggerStepThrough>
    <StructLayout(LayoutKind.Sequential)>
    Friend Structure DwmThumbnailProperties

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' A bitwise combination of DWM thumbnail constant values that indicates which members of this structure are set.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <MarshalAs(UnmanagedType.U4)>
        Public Flags As DwmThumbnailPropertiesFlags

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' The area in the destination window where the thumbnail will be rendered.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Public DstRectangle As NativeRectangle

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' The region of the source window to use as the thumbnail. By default, the entire window is used as the thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Public SrcRectangle As NativeRectangle

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' The opacity with which to render the thumbnail. 
        ''' <para></para>
        ''' 0 is fully transparent while 255 is fully opaque. 
        ''' <para></para>
        ''' The default value is 255.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Public Opacity As Byte

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' <see langword="True"/> to make the thumbnail visible; otherwise, <see langword="False"/>. 
        ''' <para></para>
        ''' The default is <see langword="False"/>.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <MarshalAs(UnmanagedType.Bool)>
        Public Visible As Boolean

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' <see langword="True"/> to use only the thumbnail source's client area; otherwise, <see langword="False"/>. 
        ''' <para></para>
        ''' The default is <see langword="False"/>.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <MarshalAs(UnmanagedType.Bool)>
        Public SourceClientAreaOnly As Boolean

    End Structure

End Namespace

#End Region
