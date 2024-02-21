# ATEN-Calculator
This repository contains a password calculator tool designed to generate passwords for ATEN command using a combination of seed and the last octet of the router's MAC address. The tool is particularly useful for certain routers manufactured by ZyXEL and TP-LINK.
## Requirements
Visual Studio (for building the project)

.NET 8.0

Windows operating system
## Usage
Obtain the seed and the last octet of the MAC address of your router.

Generate seed via ATSE command

Input the seed and last MAC octet into the program

Click Generate button

The tool will generate ATEN command with corresponding password.

![Usage](Usage1.png)

## Building
Clone or download the repository to your local machine.

Open the project in Visual Studio.

Build the project to generate the executable file.

## Executable
You can directly download the compiled executable from the Releases section.
