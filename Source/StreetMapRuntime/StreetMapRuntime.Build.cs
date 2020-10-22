// Copyright 2017 Mike Fricker. All Rights Reserved.

using UnrealBuildTool;

public class StreetMapRuntime : ModuleRules
{
    public StreetMapRuntime(ReadOnlyTargetRules Target) : base(Target)
    {
        PrivateDependencyModuleNames.AddRange(
            new string[] {
                "Core",
                "CoreUObject",
                "Engine",
                "RHI",
                "RenderCore",
            }
        );

        PrivateIncludePaths.AddRange(new string[]{"StreetMapRuntime/Private"});

        if (Target.bBuildEditor == true)
        {
            //@TODO: Needed for FPropertyEditorModule::NotifyCustomizationModuleChanged()
            //@TODO: To move/implement in FStreetMapComponentDetails
            PrivateDependencyModuleNames.Add("PropertyEditor");
        }
    }
}
