using System.Collections;
using System.Collections.Generic;
using UnityEditor;          // allows us to give commands to the editor
using UnityEngine;

public class makeTowerObject 
{
    // gives us ability to create a tower object using the assets dropdown
    [MenuItem("Assets/Create/Tower Object")]
    public static void Create()
    {
        TowerObject asset = ScriptableObject.CreateInstance<TowerObject>();
        AssetDatabase.CreateAsset(asset, "Assets/NewTowerObject.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
}
