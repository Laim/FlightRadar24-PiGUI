# pi24gui
This is GUI for pi24 (FlightRadar24) that you can leave open and it'll refresh automatically if configured.

![pi24gui-gif](https://github.com/Laim/pi24gui/assets/14845036/f8819acd-da41-433e-8ab4-250f828c972c)

# Usage
Download the latest release and open pi24gui.exe, enter your feeder URL and port (default port is 8754) and click connect.

Please note that you need to include http://, so if your feeder url is 192.168.1.12, enter http://192.168.1.12.

See [HELP.md](HELP.md) for more information.

# Build from Source
Download Visual Studio 17.8.3 or later and ensure .NET 8 is installed. 

Build from command line with the below

`dotnet build pi24gui.sln -c Release /property:Version=1.0.46`

You can replace 'Release' with 'Debug' and ensure the version is incremented with each build.