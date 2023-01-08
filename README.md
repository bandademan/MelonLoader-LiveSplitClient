# MelonLoader-LiveSplitClient
 MelonLoader-LiveSplitClient is a LiveSplit Client class used alongside MelonLoader to allow modders to develop autospliters using the LiveSplit Server component.

## Setup
For LiveSplit Server setup follow the LiveSplit Server README - https://github.com/LiveSplit/LiveSplit.Server

 - Download the code
 - Open the sln or csproj file within Visual Studio
 - Design the mod for any game using the LiveSplitClient API
 - Profit

## How to Use
LiveSplitClient is built with constructors to create and connect to the LiveSplit Server
  
The default constructor connects to the 'localhost' at port 16834 however if you want to change the ip or the port another constructor is available.
You can also choose to enable/disable logging to allow debugging when commands are sent to the Server.

Once the Client is connected you can uses methods to run any of the LiveSplit Server commands
 
LiveSplit Server Commands - https://github.com/LiveSplit/LiveSplit.Server#commands
 
## LiveSplit Client Methods
- StartTimer
- StartOrSplitTimer
- SplitTimer
- UnSplitTimer
- SkipSplitTimer
- PauseTimer
- ResumeTimer
- ResetTimer

For all other commands the LiveSplit Server allows use 
- SendCmd: Used to send any command to the server

## Examples of making a game run a LiveSplit command
### Harmony Patching
For a guide on Harmony Patching - https://melonwiki.xyz/#/
```
LiveSplitClient LSC;

[HarmonyPatch(typeof(ClassToPatch), "MethodToPatch")]
class Patch
{
     [HarmonyPrefix]
     internal static void Prefix()
     {
          LSC.StartTimer();
     }
     
     [HarmonyPostfix]
     internal static void Postfix()
     {
          LSC.StartTimer();
     }
     
}
```

### Example Game Use
Inside the Backrooms LiveSplit Mod - 
https://github.com/bandademan/ITBLiveSplitMod
