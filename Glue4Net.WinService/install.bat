﻿echo setup
set DOTNETFX4=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX4%
echo Installing Beetle server to winservice...
echo ---------------------------------------------------
InstallUtil /i Glue4Net.WinService.exe
echo ---------------------------------------------------
echo Done.