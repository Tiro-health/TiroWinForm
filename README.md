# TiroWinForm
WinForm integration demo of the TiroApp.

To construct this demo integration of a web app into a WinForm application I mainly followed these two tutorials:
- [Get started with WebView2 in Windows Forms](https://docs.microsoft.com/en-us/microsoft-edge/webview2/get-started/winforms)
- [WebView2 Reference - CoreWebView2.AddHostObjectToScript(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.addhostobjecttoscript?view=webview2-dotnet-1.0.818.41#Microsoft_Web_WebView2_Core_CoreWebView2_AddHostObjectToScript_System_String_System_Object_)

## How to build this demo
1. Make sure you have the Webview 2 Runtime and Visual Studio 2017 or later installed. For more info see: [WebView 2 - Prerequisites](https://docs.microsoft.com/en-us/microsoft-edge/webview2/get-started/winforms#prerequisites)
3. Open Visual Studio
4. Install the WebView 2 SDK with the NuGet package manager as described in the tutorial: [Step 2 - Install WebView2 SDK](https://docs.microsoft.com/en-us/microsoft-edge/webview2/get-started/winforms#step-2---install-webview2-sdk)
5. Open the project in this repository
6. Press build and you should be able to see the demo.

## How to integrate this in my application:
Take a look here [this page](./EmbeddedAPI.md) which describes how to embed the Tiro web app into your .NET application..


