
var target = Argument("target", "Build");
var configuration = Argument("configuration", "Release");
var nugetApiKey = Argument("NugetApiKey", "");
var publishRemotely = Argument("PublishRemotely", false);

var nuspecName = "Com.Rohitss.Uceh.UCEHandler.nuspec";
var slnPath = "../example/UCEHandlerApp.sln";

Task("Build")
	.Does(() =>
{
	NuGetRestore(slnPath);
	DotNetBuild(slnPath, x => x
        .SetConfiguration(configuration)
        .SetVerbosity(Verbosity.Minimal)
        .WithTarget("build")
        .WithProperty("TreatWarningsAsErrors", "false")
    );
});

Task("Pack")
	.IsDependentOn("Build")
	.Does(()=> 
{
	var packageDir = @"..\package";
	var artefactsDir = @"..\.artefacts";

	EnsureDirectoryExists(packageDir);
	CleanDirectory(packageDir);

	EnsureDirectoryExists(artefactsDir);
	CleanDirectory(artefactsDir);
	
	CopyFiles(@"..\src\bin\" + configuration + @"\*.dll", artefactsDir);
	CopyFiles(@"..\src\bin\" + configuration + @"\*.pdb", artefactsDir);
	CopyFileToDirectory(@"..\nuget\" + nuspecName, artefactsDir);

	NuGetPack(new FilePath(artefactsDir + @"\" + nuspecName), new NuGetPackSettings
	{
		OutputDirectory = packageDir
	});
});

Task("Publish")
	.IsDependentOn("Pack")
	.WithCriteria(publishRemotely)
	.Does(()=> 
{
	NuGetPush(GetFiles(@"..\package\*.nupkg").First(), new NuGetPushSettings {
    	Source = "https://api.nuget.org/v3/index.json",
    	ApiKey = nugetApiKey
 	});
});

RunTarget(target);
