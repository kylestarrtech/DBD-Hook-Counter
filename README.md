# DBD-Hook-Counter
A Hook Counting program for streamers to use in their streams as Killer!

##Summary
The Hook Counter is meant for streamers who stream the game Dead by Daylight. When you're playing Killer, you can't actually see the hook stages of the other survivors - this program aims to remedy that for your viewers and let them see the hook stages as they pile on in your trials!

##Features
The settings let you adjust size, height .etc for a variety of UI scales. You can save these inside user profiles that track different settings for you. On top of that, the Hook Counter lets you send this data to a web server!

Here's a more detailed list of these features:

###INDIVIDUAL SURVIVOR TRACKING
Track **all four** survivors' hook states - if you mess up, simply continue to press past the third hook state and you can correct yourself quickly and easily. There is also a reset hotkey specifically for you to reset **all** survivors' hook states for a new game. Additionally, the Send Data hotkey will reset settings as well (more on that later!).

###CHROMA KEY CUSTOMIZATION
The way this program works is as a chroma key in OBS as a window capture, as a result the program offers you a feature to customize the colour of the chroma key. This may assist you in your chroma key settings on OBS so as to not lose the full quality of the image. By default, the color is (0, 255, 0) (or #00ff00) and is more than capable of keeping full quality of the image, however, you may choose to pick a different colour.

###CUSTOMIZABLE PADDING AND ICON SIZES
Dead by Daylight contains a variety of UI scales and a lot of different sizes as a result. Due to this, it's important to provide settings on the size of the hook icons and the spacing between them, these settings are titled "Hook Icon Size" (you may edit the X and the Y values individually) and "Survivor Padding" which is the vertical padding between each survivor.

###WEB SERVER COMPATABILITY
The Hook Counter contains support to send your data from the Hook Counter to a web server through a POST request. This lets you take that data in the web server and manipulate it as you wish! This is obviously a setting for advanced users, but offers the opportunity for plenty of creative use cases that make the data for the Hook Counter more than just a simple stream tracker.
