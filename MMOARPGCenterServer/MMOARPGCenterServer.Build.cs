// Copyright (C) RenZhai.2021.All Rights Reserved.

using UnrealBuildTool;

public class MMOARPGCenterServer : ModuleRules
{
	public MMOARPGCenterServer(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicIncludePaths.Add("Runtime/Launch/Public");

		PrivateIncludePaths.Add("Runtime/Launch/Private");      // For LaunchEngineLoop.cpp include

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Projects");

		PrivateDependencyModuleNames.Add("CoreUObject");
		PrivateDependencyModuleNames.Add("ApplicationCore");
		PrivateDependencyModuleNames.Add("SimpleMySQL");// 包含Engine/Plugins下本项目新增的且要用到的SimpleMySQL插件
		PrivateDependencyModuleNames.Add("SimpleNetChannel");
		PrivateDependencyModuleNames.Add("MMOARPGCommon");
	}
}
