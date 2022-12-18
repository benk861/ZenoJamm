/*******************************************************************************
The content of this file includes portions of the proprietary AUDIOKINETIC Wwise
Technology released in source code form as part of the game integration package.
The content of this file may not be used without valid licenses to the
AUDIOKINETIC Wwise Technology.
Note that the use of the game engine is subject to the Unreal(R) Engine End User
License Agreement at https://www.unrealengine.com/en-US/eula/unreal
 
License Usage
 
Licensees holding valid licenses to the AUDIOKINETIC Wwise Technology may use
this file in accordance with the end user license agreement provided with the
software or, alternatively, in accordance with the terms contained
in a written agreement between you and Audiokinetic Inc.
Copyright (c) 2022 Audiokinetic Inc.
*******************************************************************************/

using UnrealBuildTool;

public class WwiseSimpleExternalSource : ModuleRules
{
#if WITH_FORWARDED_MODULE_RULES_CTOR
	public WwiseSimpleExternalSource(ReadOnlyTargetRules Target) : base(Target)
#else
	public WwiseSimpleExternalSource(TargetInfo Target)
#endif
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "AkAudio", "WwiseFileHandler"});

		PrivateDependencyModuleNames.AddRange(new string[] { "WwiseSoundEngine", "WwiseResourceLoader",});
		if (Target.bBuildEditor )
		{
			PrivateDependencyModuleNames.AddRange(new string[] { "UnrealEd"});
		}
		if (Target.bBuildWithEditorOnlyData)
        {
			PrivateDependencyModuleNames.AddRange(new string[] { "WwiseProjectDatabase",  "WwiseResourceCooker"});
		}
	}
}