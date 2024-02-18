# Help

You can access your userSettings.json file here: `C:\Users\%username%\AppData\Local\pi24gui`

## Usage
Once connected to your Receiver, which you can do by following the 'Usage' section in the README, there's a few things that you can do.

To access your pi24 web page from the application, click on the Local IP(s) in the Overview tab.  To access your Data Sharing page for the current radar on FlightRadar24's website, double click on your Radar Code once connected which is also available in the Overview tab.

To go to a specific flight being shown under the Tracked Aircraft tab, double click on the aircrafts data row (anywhere you want) and it will open the aircraft on the FlightRadar24 website.

## FlightAlert
FlightAlert will send you a System Notification or System Beep (both if both are selected) every time a callsign you specify appears in the Tracked Aircraft list.

This feature requires the GUI to be open or running in the background.

## Options
This just explains what each setting does

### Save Feeder
This saves your feeder configuration, i.e URL and Port. This is seperate from other options, meaning you can have the other settings configured without needing to have a permanent feeder URL defined.

### Automatic Refresh
Will refresh the data from your pi24 based on the interval you provide, which by default is 5 seconds if enabled.

### Append Log
Appends the log from your pi24 so you can have more than the top 100, each time it refreshes it will just add the current log to the already pulled one.  Please note however that it is not smart and you will definitely get duplicate log data.
