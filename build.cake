var target = Argument("target", "Default");
var projectPath = "./src/POGOProtos.NetStandard1";

Task("Build").Does(() =>
{
  DotNetCoreRestore(projectPath);

  var buildSettings = new DotNetCorePackSettings();
  buildSettings.VersionSuffix = "2.0.1";

  DotNetCorePack(projectPath, buildSettings);
});

RunTarget(target);