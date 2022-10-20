# COMPSCI 715 - LASER Project - Loss Aversion Strategy Exergame

## How to build and run the project?
1. Download this repository to your local machine and import the entiry project to your Unity (recommended Unity version: `Unity 2021.3.8f1`)
2. The project contains two scenes, one is for loss aversion strategy version, another is for reward strategy version.
3. Open one of the scenes that you want to build, and then
4. Go to File -> Build Settings -> Switch to Android Platform
5. Configure the build settings:\
5.1 Go to Player Settings -> Android settings -> Other Settings -> Rendering. Untick the `Auto Graphics API` option and only include `OpenGLES3` Graphics API in the Graphics APIs list.
![Auto Graphics API](/Screenshots/Auto-Graphics-API.png "Auto Graphics API")\
5.2 Go to Player Settings -> Android settings -> Other Settings -> Rendering. Untick the `Multithreaded Rendering` option.
![Multithreaded Rendering](/Screenshots/Multithreaded-rendering.png "Multithreaded Rendering")\
5.3 Go to Player Settings -> Android settings -> Other Settings -> Identification. On the `Minimum API Level` setting, select `Android 7.0 'Nougat' (API level 24)`. `Target API Level` select `Automatic`.\
5.4 Go to Player Settings -> Android settings -> Other Settings -> Configuration. On the `Scripting Backend` setting, select `IL2CPP`. And, for the `Target Architectures`, tick `ARMv7` and `ARM64` options, and untick `x86 (Chrome OS)` and `x86-64 (Chrome OS)`.
![Identification-and-Configuration](/Screenshots/Identification-and-Configuration.png "Identification-and-Configuration")
5.3 Keep everything else as default!
6. After configure the Project Settings, you may start to build the project.
7. After building the project, Unity should produce a .apk file at your pre-selected location.
8. Copy and paste the .apk file to your smartphone, and install it as a normal application.
9. Remeber to allow all permissions when install the App and allow all permissions when you first time open the App (for Android runtime permission request).
10. Repeat same processes for anthor version.

## Hardware Requirements
* This project will only run on Android devices that has Android Operating System version  below 10 (or below Android API level 29). The Android device that we were used to do the user study is `Vivo x9` smartphone with Android OS 7.1.2.
* Any Android device that wants to install and run this project must support GPS and accelerometer. When running the App, we recommend you connect to the internet for better GPS accuracy.

## Data Recording and Data Location
* The program will automatically record the following data: `Time, Exercise Intensity Value (GPS), Average Moving Steps, Magnet Energy, Level of Reward, Number of Gems, Number of Dragon Babies, Number of Adult Dragons`.
* `Exercise Intensity Value (GPS)` represents the value that is measured and calculated by using the GPS data. `Average Moving Steps` represents the value that is measured and calculated by using the step counter.
* The data recording will start when the GPS position adjustment process finished.
* The program will automatically write the data to a csv data file, you can find the csv data file in the `files` folder under the program main directory. The name of the csv file starts with the words: `Exercise_Intensity_Data`.
