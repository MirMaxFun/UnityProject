using UnrealBuildTool;

public class MyProject23Target : TargetRules
{
	public MyProject23Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyProject23");
	}
}
