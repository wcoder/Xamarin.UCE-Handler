# Xamarin UCE Handler
### Android library which lets you take control of Android App's uncaught exceptions. View, Copy, Share, Save and Email exceptions details including other useful info easily.
Tracking down all exceptions is the crucial part of the development. We could just expect that we have handled all exceptions. But whatever we do, we come across it with the so-called pop-up saying “Unfortunately, App has stopped”, that is why it is called uncaught-exceptions.

Why should you use this library? Read the answer - [Handling Uncaught-Exceptions in Android](https://android.jlelse.eu/handling-uncaught-exceptions-in-android-d818ffb20181)

![Example Animation](https://github.com/RohitSurwase/UCE-Handler/raw/master/art/uce_feature.png)         ![Example Animation](https://github.com/RohitSurwase/UCE-Handler/raw/master/art/uce_handler_example.gif)

## Features
* Android App lifecycle aware.
* Catches all uncaught exceptions gracefully.
* Displays separate screen with multiple options whenever an App crashes.
* View, Copy, Share, and Save crash logs easily.
* Email crash log along with the .txt file with multiple developers/receipients.
* Completely close the crashed/unstable Application.

## Logged Information
* Device/mobile info.
* Application info.
* Crash log.
* Activity track. //optional
* All log files are placed in a separate folder.

### Each Log file is named upon App's name so you can identify and distinguish files easily if you have added this library in multiple projects/applications.

## Example
Download the example app [here](https://github.com/RohitSurwase/UCE-Handler/raw/master/UCE_Handler_Example.apk)

## Getting Started
Add this library to your Android project and initialize it in your Application class. Additionaly you can add developer's email addresses who will get the email of crash log along with the .txt file attached.

# Setup

// TODO:

In your Application class:
* Initialize library using builder pattern.

```csharp
[Application]
public class CustomApplication : Application
{
    // ...

    public override void OnCreate()
    {
        base.OnCreate();

        // Initialize UCE_Handler Library
        new UCEHandler.Builder(this).Build();
    }
}
```
	
##### For those of you who are still using Eclipse + ADT, you need to add UCEDefaultActivity manually in your App's manifest. (As suggested by [Caceresenzo](https://github.com/RohitSurwase/UCE-Handler/issues/2#issuecomment-385262850))

```xml
<application>
    ...
    <activity android:name="com.rohitss.uceh.UCEDefaultActivity" android:process=":error_activity"/>
</application>
```

### Optional Parameters
Method | Default | Description
-------|--------|--------
SetUCEHEnabled(true/false) | true | Enable/Disable UCE_Handler.
SetTrackActivitiesEnabled(true/false) | false | Choose whether you want to track the flow of activities the user/tester has taken or not.
SetBackgroundModeEnabled(true/false) | true | Choose if you want to catch exceptions while app is in background.
AddCommaSeparatedEmailAddresses("abc@gmail.com, pqr@gmail.com,...) | empty | Add comma separated email addresses who will receive the crash logs.

#### 'Save Error Log' will work only if your app already has storage permission as library does not ask for it.

## Authors & Contributers

* [**Rohit Surwase**](https://github.com/RohitSurwase) - *Initial work* - [API-Calling-Flow](https://github.com/RohitSurwase/API-Calling-Flow) , [AndroidDesignPatterns](https://github.com/RohitSurwase/AndroidDesignPatterns) , [News App Using Kotlin, MVP](https://github.com/RohitSurwase/News-Kotlin-MVP) ,  [Linkaive - Android App on Play Store](https://play.google.com/store/apps/details?id=com.rohitss.saveme)
* [**Yauheni Pakala**](https://github.com/wcoder) - Binding library for Xamarin.Android

## License

Copyright © 2018 Rohit Sahebrao Surwase.

This project is licensed under the Apache License, Version 2.0 - see the [LICENSE](LICENSE) file for details
