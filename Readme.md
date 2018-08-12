# **ElektroDwmThumbnail**

**ElektroDwmThumbnail** is a .NET user-control written in VB.NET that can be used to create a dynamic real-time preview thumbnail for any window. It wraps some DWM API functions and is delivered as a user-control for friendly use.

See the video below if you have any doubts...

[![demoapplication](https://img.youtube.com/vi/fy3MLMpEUTg/0.jpg)](https://www.youtube.com/watch?v=fy3MLMpEUTg) 

Usage example in C#:

    // Register a DWM thumbnail for the main window of Notepad process.
    Process pr = Process.GetProcessesByName("Notepad").SingleOrDefault();
    IntPtr? hWnd = pr?.MainWindowHandle;
    ElektroDwmThumbnail1.RegisterThumbnail(hWnd);

    // Unregister the DWM thumbnail.
    ElektroDwmThumbnail1.UnregisterThumbnail();
  
Usage example in VB.NET:

    ' Register a DWM thumbnail for the main window of Notepad process.
    Dim pr As Process = Process.GetProcessesByName("Notepad").SingleOrDefault()
    Dim hWnd As IntPtr? = pr?.MainWindowHandle
    ElektroDwmThumbnail1.RegisterThumbnail(hWnd)

    ' Unregister the DWM thumbnail.
    ElektroDwmThumbnail1.UnregisterThumbnail()

Available properties in the control's property grid:

[!(https://i.imgur.com/kApXj4o.png)]

This user-control is shared for free as part of the commercial ElektroKit Framework for .NET, which you can buy from here: 

https://codecanyon.net/item/elektrokit-class-library-for-net/19260282
