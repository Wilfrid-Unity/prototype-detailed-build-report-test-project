using UnityEditor;
using UnityEngine;

public class DetailedBuildReportExample : MonoBehaviour
{
    [MenuItem("Build/DetailedBuildReport example")]
    public static void MyBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[]
        {
            "Assets/Scenes/Cube.unity",
            "Assets/Scenes/Planes.unity",
            "Assets/Scenes/Sphere.unity"
        };
        buildPlayerOptions.locationPathName = "DetailedReportBuild/MyGame.exe";
        buildPlayerOptions.target = BuildTarget.StandaloneWindows64;

        buildPlayerOptions.options = BuildOptions.Development | BuildOptions.DetailedBuildReport;
        
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
