# Dark-Mode-Forms
Apply Dark Mode to all Controls in a Form [WinForms]

![Preview](Screenshots/DarkModeForms_01.png)

- This will detect if Dark Mode Color is enabled in Windows Settings.
- Then iterate on all controls in your Form and attemp to turn them into DarkMode (if enabled).
- [Optional] If you have Icons in your Menus or Tool Bars, they will be re-colored into a Clear more visible in the dark version of your icons. (Works the best with monochromatic icons)
- No Nuggets, No external DLLs, Just 1 File: [DarkModeCS.cs](DarkModeCS.cs).
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
