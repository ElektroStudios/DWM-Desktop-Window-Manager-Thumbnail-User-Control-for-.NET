#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Imports "

Imports ElektroKit.Interop.Win32.Types

#End Region

#Region " DwmThumbnailPropertiesFlags "

Namespace ElektroKit.Interop.Win32.Enums

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Specifies flags used by the <see cref="DwmThumbnailProperties"/> structure to 
    ''' indicate which of its members contain valid information.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <remarks>
    ''' <see href="https://docs.microsoft.com/en-us/windows/desktop/dwm/dwm-tnp-constants"/>
    ''' </remarks>
    ''' ----------------------------------------------------------------------------------------------------
    <Flags>
    Friend Enum DwmThumbnailPropertiesFlags As UInteger

        ''' <summary>
        ''' A value for the rcDestination member has been specified.
        ''' </summary>
        RectDestination = &H1

        ''' <summary>
        ''' A value for the rcSource member has been specified.
        ''' </summary>
        RectSource = &H2

        ''' <summary>
        ''' A value for the opacity member has been specified.
        ''' </summary>
        Opacity = &H4

        ''' <summary>
        ''' A value for the fVisible member has been specified.
        ''' </summary>
        Visible = &H8

        ''' <summary>
        ''' A value for the fSourceClientAreaOnly member has been specified.
        ''' </summary>
        SourceClientAreaOnly = &H10

    End Enum

End Namespace

#End Region
