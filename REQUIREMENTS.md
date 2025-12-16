# Prerequisites: Visual Studio Extension Development

You mentioned having only C# installed. To build and run VSIX extensions, you must install the **Visual Studio extension development** workload.

## How to Install

1. Open the **Visual Studio Installer** (press Windows Key and type "Installer").
2. Find your version of **Visual Studio 2022** in the list.
3. Click **Modify**.
4. In the **Workloads** tab, scroll down to the "Other Toolsets" section.
5. Check **Visual Studio extension development**.
    - It usually features a puzzle piece icon.
6. Click **Modify** (bottom right) to install it.

## Why is this needed?
This workload provides:
- The experimental instance (for debugging with F5).
- The VSIX build tools (to create the `.vsix` installer).
- The templates and SDK targets required for the project to load correctly in Visual Studio.
