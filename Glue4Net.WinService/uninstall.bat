echo setup
set DOTNETFX4=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX4%
echo UnInstalling beetle server...
echo ---------------------------------------------------
InstallUtil /u Glue4Net.WinService.exe
echo ---------------------------------------------------
echo Done.