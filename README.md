# Dark-Mode-Forms
Apply Dark Mode to all Controls in a Form [WinForms]

![Preview](Screenshots/DarkModeForms_01.png)

- This will detect if Dark Mode Color is enabled in Windows Settings.
- Then iterate on all controls in your Form and attemp to turn them into DarkMode (if enabled).
- [Optional: Default true] If you have Icons in your Menu or Tool Bars, they will be re-colored into a Clear version.
- No Nuggets, No external DLLs, Just 1 File: [DarkModeCS.cs](DarkModeCS.cs).
- Just 2 Lines to implement it:

```csharp
DarkModeCS DM = null;
....
public Form1()
{
	InitializeComponent();
	DM = new DarkModeCS(this);
}
```
