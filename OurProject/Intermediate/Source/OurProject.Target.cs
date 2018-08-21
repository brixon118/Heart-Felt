using UnrealBuildTool;

public class OurProjectTarget : TargetRules
{
	public OurProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("OurProject");
	}
}
