# menustrip-example
A simple MenuStrip example for showing WindowsForms accessibility degradation.

## The Story
Before, in .Net Framework, there was a classic [MainMenu](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.mainmenu?view=netframework-4.8) control that provided a classic native menu bar. It was super accessible, all screen readers read it correctly, the *Escape* key was processed automatically, as was the *Alt* key (it toggled the focus between the menu bar and the main window). to put it short, it was analogous to a menu bar written in pure Windows API.

However now, in .Net 6, there is only this [MenuStrip](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.menustrip?view=windowsdesktop-6.0) class which behaves differently:
* JAWS for Windows reports each item of the horizontal menu bar as having a submenu. Each vertical dropdown menu, when entered, is reported as context menu which is wrong. NVDA reports those items as collapsed, which is also wrong, they are just menu bar items. Narrator is super verbose in any menu bar, so I would suggest to try the other two.
* The *Escape* key seems to have effect but the screen readers do not report "leaving menus" and the menu status seem to persist. At least, JAWS reports "leaving menus" only when alt-tabbing out of the sample application. The *Alt* key seems to have no effect.
* The checked status of a checkable menu item is reported only by Narrator. As it is reported correctly in native menu bars, the issue is in the custom control itself.
* The menu bar implemented this way lacks the system menu with elements like Move, Size, Minimize, Maximize etc. Alt+Space also does not work. With the native menu bar this menu is given free of charge.
