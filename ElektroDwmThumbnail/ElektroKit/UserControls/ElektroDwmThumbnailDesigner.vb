#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Imports "

Imports System.Windows.Forms.Design

#End Region

#Region " ElektroDwmThumbnailDesigner "

Namespace ElektroKit.UserControls.Designers

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Extends the design mode behavior of a <see cref="ElektroDwmThumbnail"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <seealso cref="ElektroDwmThumbnail"/>
    ''' ----------------------------------------------------------------------------------------------------
    <DebuggerStepThrough>
    Public NotInheritable Class ElektroDwmThumbnailDesigner : Inherits ControlDesigner

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Provides design-time support for the <see cref="ElektroDwmThumbnail"/> control.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="properties">
        ''' Ab <see cref="IDictionary"/> that contains the properties for the class of the component.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        Protected Overrides Sub PreFilterProperties(ByVal properties As IDictionary)

            MyBase.PreFilterAttributes(properties)

            Dim propertyNames As String() = {
                "AutoScroll",
                "AutoScrollMargin",
                "AutoScrollMinSize",
                "ForeColor",
                "RightToLeft"
            }

            For Each propertyName As String In propertyNames
                properties.Remove(propertyName)
            Next

        End Sub

    End Class

End Namespace

#End Region
