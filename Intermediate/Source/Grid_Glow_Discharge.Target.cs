using UnrealBuildTool;

public class Grid_Glow_DischargeTarget : TargetRules
{
	public Grid_Glow_DischargeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Grid_Glow_Discharge");
	}
}
