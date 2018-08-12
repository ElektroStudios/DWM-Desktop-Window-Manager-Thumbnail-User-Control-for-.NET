' ***********************************************************************
' Author   : Elektro
' Modified : 6-August-2018
' ***********************************************************************

#Region " Option Statements "

Option Explicit On
Option Strict On
Option Infer Off

#End Region

#Region " Imports "

Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security.Permissions

Imports ElektroKit.Core.Extensions.Control
Imports ElektroKit.Core.Imaging.Tools
Imports ElektroKit.Interop.Win32
Imports ElektroKit.Interop.Win32.Enums
Imports ElektroKit.Interop.Win32.Types
Imports ElektroKit.UserControls.Designers

#End Region

#Region " ElektroDwmThumbnail "

Namespace ElektroKit.UserControls.Controls

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Represents a Desktop Window Manager (DWM) thumbnail that creates a mirror of any window.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    <DisplayName(NameOf(ElektroDwmThumbnail))>
    <Description("Represents a DWM (Desktop Window Manager) thumbnail that creates a mirror of any window.")>
    <DesignTimeVisible(True)>
    <DesignerCategory(NameOf(UserControl))>
    <ToolboxBitmap(GetType(PictureBox), "PictureBox.bmp")>
    <ToolboxItemFilter("System.Windows.Forms", ToolboxItemFilterType.Require)>
    <ClassInterface(ClassInterfaceType.AutoDispatch)>
    <ComVisible(True)>
    <DefaultProperty(NameOf(ElektroDwmThumbnail.ThumbnailId))>
    <DefaultEvent(NameOf(ElektroDwmThumbnail.Click))>
    <Designer(GetType(ElektroDwmThumbnailDesigner))>
    <Docking(DockingBehavior.Ask)>
    <PermissionSet(SecurityAction.Demand, Name:="FullTrust")>
    Public Class ElektroDwmThumbnail : Inherits UserControl

#Region " Properties "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the default size of the control.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <value>
        ''' The default size of the control.
        ''' </value>
        ''' ----------------------------------------------------------------------------------------------------
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Advanced)>
        Protected Overrides ReadOnly Property DefaultSize As Size
            Get
                Return New Size(96, 96)
            End Get
        End Property

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the unique identifier of the DWM Thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Always)>
        Public ReadOnly Property ThumbnailId As Integer
            Get
                Return Me.thumbnailIdB.ToInt32()
            End Get
        End Property
        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' ( Backing Field )
        ''' <para></para>
        ''' The unique identifier of the DWM Thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Private thumbnailIdB As IntPtr

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the window handle (hWnd) of the window shown in the DWM Thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Always)>
        Public ReadOnly Property WindowHandle As Integer
            Get
                Return Me.windowHandleB.GetValueOrDefault().ToInt32
            End Get
        End Property
        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' ( Backing Field )
        ''' <para></para>
        ''' The window handle (hWnd) of the window shown in the DWM Thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Private windowHandleB As IntPtr?

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets a value that determine whether the DWM thumbnail is registered.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Always)>
        Public ReadOnly Property IsThumbnailRegistered As Boolean
            Get
                Return (Me.thumbnailIdB <> IntPtr.Zero)
            End Get
        End Property

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets a value that determine whether the window shown in the DWM thumbnail should maintain aspect ratio.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <Browsable(True)>
        <EditorBrowsable(EditorBrowsableState.Always)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Localizable(True)>
        <Category("Thumbnail")>
        <Description("A value that determine whether the window shown in the DWM thumbnail should maintain aspect ratio.")>
        Public Property KeepAspectRatio As Boolean
            Get
                Return Me.keepAspectRatioB
            End Get
            Set(ByVal value As Boolean)
                Me.keepAspectRatioB = value
                Me.UpdateThumbnail()
            End Set
        End Property
        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' ( Backing Field )
        ''' A value that determine whether the window shown in the DWM thumbnail should maintain aspect ratio.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Private keepAspectRatioB As Boolean

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets a value that determine whether the window shown in the DWM thumbnail should display its non-client area.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <Browsable(True)>
        <EditorBrowsable(EditorBrowsableState.Always)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Localizable(True)>
        <Category("Thumbnail")>
        <Description("A value that determine whether the window shown in the DWM thumbnail should display its non-client area.")>
        Public Property NonClientAreaVisible As Boolean
            Get
                Return Me.nonClientAreaVisibleB
            End Get
            Set(ByVal value As Boolean)
                Me.nonClientAreaVisibleB = value
                Me.UpdateThumbnail()
            End Set
        End Property
        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' ( Backing Field )
        ''' A value that determine whether the window shown in the DWM thumbnail should display its non-client area.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Private nonClientAreaVisibleB As Boolean

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets or sets the opacity level of the control.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <value>
        ''' The opacity level of the control.
        ''' </value>
        ''' ----------------------------------------------------------------------------------------------------
        <Browsable(True)>
        <EditorBrowsable(EditorBrowsableState.Always)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Localizable(True)>
        <Category("Window Style")>
        <Description("The opacity level of the control.")>
        <TypeConverter(GetType(OpacityConverter))>
        <DefaultValue(GetType(Double), "1.0")>
        Public Overridable Property Opacity As Double
            Get
                Return Me.opacityB
            End Get
            Set(ByVal value As Double)
                If (value <= 0.0R) Then
                    value = 0.0R
                End If
                Me.opacityB = value
                If (Me.BackColor <> Color.Transparent) Then
                    Me.BackColor = Color.FromArgb(CByte(value * 255), Me.BackColor.R, Me.BackColor.G, Me.BackColor.B)
                End If
                Me.UpdateThumbnail()
            End Set
        End Property
        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' ( Backing Field )
        ''' The opacity level of the control.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Private opacityB As Double = 1.0

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets a value that determine the offsets of X and Y coordinates when drawing the DWM thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <Browsable(True)>
        <EditorBrowsable(EditorBrowsableState.Always)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Localizable(True)>
        <Category("Thumbnail")>
        <Description("A value that determine the offsets of X and Y coordinates when drawing the DWM thumbnail.")>
        Public Property Offset As Point

#End Region

#Region " Constructors "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Initializes a new instance of the <see cref="ElektroDwmThumbnail"/> class.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerNonUserCode>
        Public Sub New()
            Me.ResizeRedraw = True
            Me.Offset = Point.Empty
        End Sub

#End Region

#Region " Event Invocators (base class) "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Raises the <see cref="ElektroDwmThumbnail.Load"/> event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="e">
        ''' An <see cref="EventArgs"/> that contains the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            If (Me.ParentForm IsNot Nothing) Then
                AddHandler Me.ParentForm.LocationChanged, AddressOf Me.ParentForm_LocationChanged
                AddHandler Me.ParentForm.SizeChanged, AddressOf Me.ParentForm_SizeChanged
            End If
            MyBase.OnLoad(e)
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Raises the <see cref="ElektroDwmThumbnail.ParentChanged"/> event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="e">
        ''' An <see cref="EventArgs"/> that contains the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overrides Sub OnParentChanged(ByVal e As EventArgs)
            If (Me.ParentForm IsNot Nothing) Then
                AddHandler Me.ParentForm.LocationChanged, AddressOf Me.ParentForm_LocationChanged
                AddHandler Me.ParentForm.SizeChanged, AddressOf Me.ParentForm_SizeChanged
            End If
            MyBase.OnParentChanged(e)
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Raises the <see cref="ElektroDwmThumbnail.Paint"/> event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="e">
        ''' An <see cref="PaintEventArgs"/> that contains the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Me.UpdateThumbnail()
            MyBase.OnPaint(e)
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Raises the <see cref="ElektroDwmThumbnail.SizeChanged"/> event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="e">
        ''' An <see cref="EventArgs"/> that contains the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            Me.UpdateThumbnail()
            MyBase.OnSizeChanged(e)
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Raises the <see cref="ElektroDwmThumbnail.LocationChanged"/> event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="e">
        ''' An <see cref="EventArgs"/> that contains the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overrides Sub OnLocationChanged(ByVal e As EventArgs)
            Me.UpdateThumbnail()
            MyBase.OnLocationChanged(e)
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Raises the <see cref="ElektroDwmThumbnail.VisibleChanged"/> event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="e">
        ''' An <see cref="EventArgs"/> that contains the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
            Me.UpdateThumbnail()
            MyBase.OnVisibleChanged(e)
        End Sub

#End Region

#Region " Event-Handlers ( ParentForm ) "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Handles the <see cref="Form.LocationChanged"/> event of the <see cref="ElektroDwmThumbnail.ParentForm"/> control.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="sender">
        ''' The source of the event.
        ''' </param>
        ''' 
        ''' <param name="e">
        ''' The <see cref="EventArgs"/> instance containing the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overridable Sub ParentForm_LocationChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateThumbnail()
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Handles the <see cref="Form.SizeChanged"/> event of the <see cref="ElektroDwmThumbnail.ParentForm"/> control.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="sender">
        ''' The source of the event.
        ''' </param>
        ''' 
        ''' <param name="e">
        ''' The <see cref="EventArgs"/> instance containing the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overridable Sub ParentForm_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateThumbnail()
        End Sub

#End Region

#Region " Public Methods "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Creates a Desktop Window Manager (DWM) thumbnail that mirrors the specified window.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="pid">
        ''' The process identifier that owns the window.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Overridable Sub RegisterThumbnail(ByVal pid As Integer)
            Me.RegisterThumbnail(Process.GetProcessById(pid)?.MainWindowHandle)
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Creates a Desktop Window Manager (DWM) thumbnail that mirrors the specified window.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="process">
        ''' The <see cref="Diagnostics.Process"/> that owns the window.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Overridable Sub RegisterThumbnail(ByVal process As Process)
            Me.RegisterThumbnail(process?.MainWindowHandle)
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Creates a Desktop Window Manager (DWM) thumbnail that mirrors the specified window.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="hwnd">
        ''' A handle to the window.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Overridable Sub RegisterThumbnail(ByVal hwnd As IntPtr?)

            If (Me.DesignMode) Then
                Exit Sub
            End If

            If (Me.IsThumbnailRegistered) Then
                Throw New Exception("DWM thumbnail is already registered. You must call 'UnregisterThumbnail' method then call 'RegisterThumbnail' to register a new DWM thumbnail.")
            End If

            If Not (hwnd.HasValue) Then
                Throw New ArgumentNullException(paramName:=NameOf(hwnd))
            End If

            If Not NativeMethods.IsWindowVisible(hwnd.GetValueOrDefault()) Then
                Throw New ArgumentException(paramName:=NameOf(hwnd), message:="The specified window must be visible.")
            End If

            If (Me.ParentForm Is Nothing) Then
                Throw New Exception(String.Format("This {0} control must be hosted inside a Form to be able register a DWM thumbnail.", NameOf(ElektroDwmThumbnail)))
            End If

            Me.windowHandleB = hwnd.GetValueOrDefault()

            Dim thumbnailProps As DwmThumbnailProperties
            With thumbnailProps
                .Flags = DwmThumbnailPropertiesFlags.RectDestination Or
                         DwmThumbnailPropertiesFlags.Visible Or
                         DwmThumbnailPropertiesFlags.SourceClientAreaOnly Or
                         DwmThumbnailPropertiesFlags.Opacity

                .DstRectangle = Me.GetThumbnailRectangle()
                .Opacity = CByte(Me.Opacity * 255)
                .SourceClientAreaOnly = Not Me.nonClientAreaVisibleB
                .Visible = Me.Visible
            End With

            Dim dwmRegisterResult As Integer = NativeMethods.DwmRegisterThumbnail(Me.ParentForm.Handle, Me.windowHandleB.Value, Me.thumbnailIdB)
            If (dwmRegisterResult <> HResult.S_OK) Then
                Marshal.ThrowExceptionForHR(dwmRegisterResult, IntPtr.Zero)
            End If

            Dim dwmUpdateResult As Integer = NativeMethods.DwmUpdateThumbnailProperties(Me.thumbnailIdB, thumbnailProps)
            If (dwmUpdateResult <> HResult.S_OK) Then
                Marshal.ThrowExceptionForHR(dwmUpdateResult, IntPtr.Zero)
            End If

        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Unregisters the Desktop Window Manager (DWM) thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Overridable Sub UnregisterThumbnail()

            If (Me.DesignMode) Then
                Exit Sub
            End If

            If Not (Me.IsThumbnailRegistered) Then
                Throw New Exception("DWM thumbnail is not registered.")
            End If

            Dim result As Integer = NativeMethods.DwmUnregisterThumbnail(Me.thumbnailIdB)
            Select Case result

                Case HResult.S_OK, HResult.E_INVALIDARG ' E_INVALIDARG is returned when the hWnd does not point to a existing window.
                    Me.thumbnailIdB = IntPtr.Zero

                Case Else
                    Marshal.ThrowExceptionForHR(result, IntPtr.Zero)

            End Select

        End Sub

#End Region

#Region " Private Methods"

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the <see cref="Rectangle"/> for the DWM thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepperBoundary>
        Protected Function GetThumbnailRectangle() As Rectangle

            Dim relativePos As Point = Me.GetBoundsRelativeToForm().Location
            Dim thumbnailSize As Size

            If (Me.keepAspectRatioB) Then
                Dim rc As Rectangle = ImageUtil.GetRealWindowRect(Me.windowHandleB.GetValueOrDefault())

                Dim widthFactor As Double = (rc.Width / Me.ClientSize.Width)
                Dim heightFactor As Double = (rc.Height / Me.ClientSize.Height)
                Dim resizeFactor As Double = Math.Max(widthFactor, heightFactor)

                thumbnailSize = New Size(CInt(Math.Truncate(rc.Width / resizeFactor)),
                                         CInt(Math.Truncate(rc.Height / resizeFactor)))

                relativePos.Y = relativePos.Y + (Me.ClientSize.Height \ 2) - (thumbnailSize.Height \ 2)
                relativePos.X = relativePos.X + (Me.ClientSize.Width \ 2) - (thumbnailSize.Width \ 2)

            Else
                thumbnailSize = Me.ClientSize

            End If

            relativePos.X += Me.Offset.X
            relativePos.Y += Me.Offset.Y

            Dim dstRectangle As New Rectangle(relativePos, thumbnailSize)
            Return dstRectangle

        End Function

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Renews the location, size and opacity of the registered DWM thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepperBoundary>
        Protected Sub UpdateThumbnail()

            If Not (Me.IsThumbnailRegistered) Then
                Exit Sub
            End If

            If Not NativeMethods.IsWindow(Me.windowHandleB.GetValueOrDefault()) Then ' The hWnd does not exist aynmore.
                Me.UnregisterThumbnail()
                Exit Sub
            End If

            Dim thumbProps As DwmThumbnailProperties
            With thumbProps
                .Flags = DwmThumbnailPropertiesFlags.RectDestination Or
                         DwmThumbnailPropertiesFlags.Visible Or
                         DwmThumbnailPropertiesFlags.SourceClientAreaOnly Or
                         DwmThumbnailPropertiesFlags.Opacity

                .DstRectangle = Me.GetThumbnailRectangle()
                .Opacity = CByte(Me.Opacity * 255)
                .SourceClientAreaOnly = Not Me.nonClientAreaVisibleB
                .Visible = Me.Visible
            End With

            Dim result As HResult = NativeMethods.DwmUpdateThumbnailProperties(Me.thumbnailIdB, thumbProps)
            If (result <> HResult.S_OK) Then
                Marshal.ThrowExceptionForHR(result, IntPtr.Zero)
            End If

        End Sub

#End Region

#Region " IDisposable Implementation "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        ''' Releases unmanaged and, optionally, managed resources.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="isDisposing">
        ''' <see langword="True"/>  to release both managed and unmanaged resources; 
        ''' <see langword="False"/> to release only unmanaged resources.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overrides Sub Dispose(isDisposing As Boolean)

            MyBase.Dispose(isDisposing)

            Try
                Me.UnregisterThumbnail()
            Catch ex As Exception
            End Try

        End Sub

#End Region

    End Class

End Namespace

#End Region
