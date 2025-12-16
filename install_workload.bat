@echo off
set "InstallerPath=C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe"

if not exist "%InstallerPath%" (
    echo "VS Installer not found at %InstallerPath%"
    exit /b 1
)

echo Found VS Installer.
echo Attempting to detect VS 2022 Community...
set "VSPath=C:\Program Files\Microsoft Visual Studio\2022\Community"

if not exist "%VSPath%" (
    echo Community not found, checking Professional...
    set "VSPath=C:\Program Files\Microsoft Visual Studio\2022\Professional"
)

if not exist "%VSPath%" (
    echo Professional not found, checking Enterprise...
    set "VSPath=C:\Program Files\Microsoft Visual Studio\2022\Enterprise"
)

if not exist "%VSPath%" (
    echo "Could not find standard VS 2022 installation. Please install manually."
    exit /b 1
)

echo Installing 'Visual Studio extension development' workload to: %VSPath%
echo You may be prompted for Administrator permissions (UAC).
echo Please look for the VS Installer window.

"%InstallerPath%" modify --installPath "%VSPath%" --add Microsoft.VisualStudio.Workload.VisualStudioExtension --passive --norestart

echo Command sent.
