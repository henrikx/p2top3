# P2 to P3

This program will help you converting a DJI Phantom 2 Vision log file to a Phantom 3 Professional log file. The purpose of this
is to trick HealthyDrones.com to read the file, even if Phantom 2 logs are not supported

# System requirements
* .NET Framework 4.6 or higher. (Should already be installed.
If not you can download it here: https://www.microsoft.com/en-us/download/details.aspx?id=49982)
* If you get a "Could not find Chilkat" error, please download the 32 bit version of https://www.microsoft.com/en-hk/download/details.aspx?id=40784

# Downloads
https://github.com/henrikx/p2top3/releases

# Images
http://puu.sh/p2vPd/60c15efb8c.png

# What doesn't work on HealthyDrones
* Battery info is incomplete
  - (Bad tempetature readings) Fixed in latest version!
  - Minutes per battery and Miles per battery not working
  - Battery cells not working (not logged)
  - Initial capacity showing 0 mAh (?)
  - Serial numbers (can be modified in CSV to be correct if you want to go through the effort, but it's not very useful)
  - Wrong battery type detected
* Incorrect reading of drone type (obviously)
* Sensors
  - Signal map not working
  - Signal score not working
  - (+) GPS works, but is showing bad GPS score, because HD is used to P3+ which pick up more sats.
  - (+) Compass seems to be working (confirm?)
* Controls tab is not working
* Not sure about wind since I don't have HD premium, but most likely isn't working. (Confirm?)

# Todo
* Fix bugs
* Automatic upload to HealthyDrones.com

# Bugs
* Specifying an incorrect file throws exception.
* You tell me!
