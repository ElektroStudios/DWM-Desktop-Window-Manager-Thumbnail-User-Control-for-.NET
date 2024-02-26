<!-- Common Project Tags:
command-line 
console-applications 
desktop-app 
desktop-application 
dotnet 
dotnet-core 
netcore 
netframework 
netframework48 
tool 
tools 
vbnet 
visualstudio 
windows 
windows-app 
windows-application 
windows-applications 
windows-forms 
winforms 
 -->

# ElektroDwmThumbnail

### An user control for .NET providing DWM (Desktop Window Manager) thumbnail functionalities

------------------

## 👋 Introduction

**ElektroDwmThumbnail** is a .NET user-control written in VB.NET that enables the creation of dynamic real-time preview thumbnails for any window. It utilizes various DWM API functions and is provided as a user-control for easy and user-friendly implementation.

## 🎦 Videos

See a recorded video by clicking on the following button:
[![demoapplication](https://img.youtube.com/vi/fy3MLMpEUTg/0.jpg)](https://www.youtube.com/watch?v=fy3MLMpEUTg) 

## 📝 Requirements

- Visual Studio.

## 🤖 Getting Started

Download the latest release by clicking [here](https://github.com/ElektroStudios/DWM-Desktop-Window-Manager-Thumbnail-User-Control-for-.NET/releases/latest), and use it in Visual Studio.

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

## ⚠️ Disclaimer:

This Work (the repository and the content provided in) is provided "as is", without warranty of any kind, express or implied, including but not limited to the warranties of merchantability, fitness for a particular purpose and noninfringement. In no event shall the authors or copyright holders be liable for any claim, damages or other liability, whether in an action of contract, tort or otherwise, arising from, out of or in connection with the Work or the use or other dealings in the Work.

## 💪 Contributing

Your contribution is highly appreciated!. If you have any ideas, suggestions, or encounter issues, feel free to open an issue by clicking [here](https://github.com/ElektroStudios/DWM-Desktop-Window-Manager-Thumbnail-User-Control-for-.NET/issues/new/choose). 

Your input helps make this Work better for everyone. Thank you for your support! 🚀

## 💰 Beyond Contribution 

This work is distributed for educational purposes and without any profit motive. However, if you find value in my efforts and wish to support and motivate my ongoing work, you may consider contributing financially through the following options:

<br></br>
<p align="center"><img src="/Images/github_circle.png" height=100></p>
<p align="center">__________________</p>
<h3 align="center">Becoming my sponsor on Github:</h3>
<p align="center">You can show me your support by clicking <a href="https://github.com/sponsors/ElektroStudios/">here</a>, <br align="center">contributing any amount you prefer, and unlocking rewards!</br></p>
<br></br>

<p align="center"><img src="/Images/paypal_circle.png" height=100></p>
<p align="center">__________________</p>
<h3 align="center">Making a Paypal Donation:</h3>
<p align="center">You can donate to me any amount you like via Paypal by clicking <a href="https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=E4RQEV6YF5NZY">here</a>.</p>
<br></br>

<p align="center"><img src="/Images/envato_circle.png" height=100></p>
<p align="center">__________________</p>
<h3 align="center">Purchasing software of mine at Envato's Codecanyon marketplace:</h3>
<p align="center">If you are a .NET developer, you may want to explore '<b>DevCase Class Library for .NET</b>', <br align="center">a huge set of APIs that I have on sale. Check out the product by clicking <a href="https://codecanyon.net/item/elektrokit-class-library-for-net/19260282">here</a></br><br align="center"><i>It also contains all piece of reusable code that you can find across the source code of my open source works.</i></p>
<br></br>

<h2 align="center"><u>Your support means the world to me! Thank you for considering it!</u> 👍</h2>
