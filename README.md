# Background Changer

Swap Background based on background provider, uses NASA's astronomy picture of the day currently. 
https://github.com/nasa/apod-api
API key can be gotten from https://api.nasa.gov/

Makes use of 
https://github.com/microsoft/CsWin32


## Setup
- Use .net 5.0
- place APOD apikey in a file named `APODApiKey.txt` in project's top level directory
- by default uses `APODBackgroundProvider` can be swapped to `StaticBackgroundProvider` by changing main method (for now)
- StaticBackgroundProvider will randomly choose a file in the `background` folder 
- new `BackgroundProvider`'s can be added by implementing the `IBackgroundProvider` interface and adding to the `BackgroundProviderFactory` as well as the `Provider` enum

