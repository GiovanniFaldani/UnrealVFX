// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnrealVFX : ModuleRules
{
	public UnrealVFX(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"UnrealVFX",
			"UnrealVFX/Variant_Platforming",
			"UnrealVFX/Variant_Platforming/Animation",
			"UnrealVFX/Variant_Combat",
			"UnrealVFX/Variant_Combat/AI",
			"UnrealVFX/Variant_Combat/Animation",
			"UnrealVFX/Variant_Combat/Gameplay",
			"UnrealVFX/Variant_Combat/Interfaces",
			"UnrealVFX/Variant_Combat/UI",
			"UnrealVFX/Variant_SideScrolling",
			"UnrealVFX/Variant_SideScrolling/AI",
			"UnrealVFX/Variant_SideScrolling/Gameplay",
			"UnrealVFX/Variant_SideScrolling/Interfaces",
			"UnrealVFX/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
