// Copyright 2017 Mike Fricker. All Rights Reserved.

using UnrealBuildTool;

public class StreetMapImporting : ModuleRules
{
    public StreetMapImporting(ReadOnlyTargetRules Target) : base(Target)
    {
        PrivateIncludePaths.AddRange(
            new string[]{
                "StreetMapImporting/Private"
            }
        );
        PrivateDependencyModuleNames.AddRange(
            new string[] {
              "Core",
              "CoreUObject",
              "Engine",
              "UnrealEd",
              "XmlParser",
              "AssetTools",
              "Projects",
              "Slate",
              "EditorStyle",
              "SlateCore",
              "PropertyEditor",
              "RenderCore",
              "RHI",
              "RawMesh",
              "AssetTools",
              "AssetRegistry",
              "StreetMapRuntime"
            }
        );

    }
}
