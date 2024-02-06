# Dark-Mode-Forms
Apply Dark Mode to all Controls in a Form [WinForms]

![Preview](Screenshots/DarkModeForms_01.png)
- This will detect if dark mode color is enabled in Windows settings.
- Then iterate all the controls on your form and try to convert them to DarkMode (if enabled).
- [Optional] If you have icons on your menus or toolbars, they will be recolored to give you a lighter, more visible-in-the-dark version of your icons. (Works best with monochrome icons)
- You can access Windows Dark Colors and use them for whatever you need.
  
# Implementation
- No Nuggets, No external DLLs, Just 1 File: [DarkModeCS.cs](DarkModeCS.cs) Copy/Paste or Download and import it into your project.
- 2 Lines to implement it:

```csharp
DarkModeCS DM = null; //<- Line 1
....
public Form1()
{
	InitializeComponent();
	DM = new DarkModeCS(this); //<- Line 2
}
```
# Framework Compatibility
- .NET 4.8+
- .NET 6.0+
- Core ?? 
- Some stuff may only work on Windows 11+

# Dark Mode Colors
![Preview](Screenshots/WindowsColors.png)
