ScreenCaptureBehaviour
======================

## Unity C# Script for creating a bunch of screenshots

### To use:
In Unity, attach the script to a game object. I have mine on my game controller object, but any persistent object is fine.

When you want to start recording, check the Is Recording box.

### Options:
Use New Folder - When this is checked you use a new folder each time you turn on and off the script. Uncheck with *extreme* caution since it will overwrite existing screen-shots. I've left it in because sometimes I don't want a billion false start folders, but use with care.

Directory - Relative to the root of your project, it's where your screenshots will be saved.

Frame Rate - The rate of video capture it sets the playback frame-rate so real time doesn't influence time anymore. http://docs.unity3d.com/ScriptReference/Time-captureFramerate.html

Scale - The scale of your images relative to your screen size. I recommend leaving this at one.