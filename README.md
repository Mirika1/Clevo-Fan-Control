# Clevo Fan Control
A fan control app for Clevo laptops.

## Credits
This app was originally created by [oleuzop](https://github.com/oleuzop). I only made some changes and added some new features.

## New Features
* Redesigned the UI
* Added fan presets. Up to 6 fan presets can be created, and you can load them by clicking on the "Load Configuration" button or right-clicking on the system tray icon
  * When the app is started, the default fan preset (Preset 1) is always selected
* The minimum fan RPM is no longer 80% of the fan running at max RPM. Both fans can now be set to any speed without affecting the other
* Changed the app icon. The icon is from the discontinued Obsidian Fan Control app
* Added a Restart and Minimize button
## Existing Features
* Fan temperature check and RPM modification are executed every XXX ms (250ms by default)
* Temperature is taken in average of the last number of temperatures (configurable, 4 records by default)
* Increments in RPM are fast (configurable, by default 2.5%)
* Decrements in RPM are slow (configurable, by default 0.1%)
* Temperature can be configured from 0 to infinite, in steps of whatever is configured (by default 5 degrees)
* Any number of fans are configurable (2 by default, but more can be added and a scroll bar will appear).
* Extra fan RPM to force more fan power. I have not tested whether this actually allows the fans to run even faster, and I do not recommend trying unless you want to risk breaking your fans.

## Configuration
The configuration.json files contain all of the configurable values.

## Installation
* Download ClevoFanControl.zip from https://github.com/Mirika1/Clevo-Fan-Control/releases/
* Extract the folder
* Install NTPostDrvSetup
  * NTPort library might give you an error message during the installation, but this can be ignored as the driver should still be installed
* Launch Clevo Fan Control.exe
* The app will start minimized to the system tray

## Screenshot
![Screenshot 2024-05-07 192632 - Copy](https://github.com/Mirika1/Clevo-Fan-Control/assets/29027673/a28e2a81-d0fc-43ac-905d-fbe63383bbf7)
