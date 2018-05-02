
## Install Cake

Windows:
```
Invoke-WebRequest https://cakebuild.net/download/bootstrapper/windows -OutFile build.ps1
```

OS X:
```
curl -Lsfo build.sh https://cakebuild.net/download/bootstrapper/osx
```

## Run scripts

Build solution:
```
.\build.ps1 --target=Build
```

Publishing new version:
```
.\build.ps1 --target=Publish --NugetApiKey=<api-key> --PublishRemotely=true
```