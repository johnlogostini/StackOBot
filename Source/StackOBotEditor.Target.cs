using UnrealBuildTool;
using System.Collections.Generic;

public class StackOBotEditorTarget : TargetRules
{
	public StackOBotEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		ExtraModuleNames.Add("StackOBot");
	}
}