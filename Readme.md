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

[![properties](https://i.imgur.com/kApXj4o.png) 

# **Donations**

##### Through Paypal:
If you like my work and want to support it, then please consider to deposit a donation through **Paypal** by clicking on the next button:

<a href="https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=E4RQEV6YF5NZY" target="_blank">![](https://www.paypalobjects.com/en_US/ES/i/btn/btn_donateCC_LG.gif)</a>

You are free to specify whatever amount of money you wish. That money will be sent to my **Paypal** account.

##### Through Envato:
If you are a .NET programmer, then maybe you would like to consider the purchase of 
'**DevCase for .NET Framework**', a powerful set of APIs for .NET developers, created by me. 

You can click the next button to go to the product specifications and the purchase page:

<a href="https://codecanyon.net/item/elektrokit-class-library-for-net/19260282" target="_blank">![DevCase for .NET Framework](Images/DevCase%20Banner.png)</a>

Note that all the source-code within the namespace 'DevCase' included in this **GitHub** repository, was freely extracted and distributed from the commercial library '**DevCase for .NET Framework**'.

<u>**Thanks in advance for your consideration!**</u> :thumbsup: