using UnityEngine;
using System.Collections;
using UnityEditor;

public class MakeScriptableObject
{
    [MenuItem("Assets/Create/My Scriptable Object")]
    public static void CreateMyAsset()
    {
        MySerializedProperty asset = ScriptableObject.CreateInstance<MySerializedProperty>();

        AssetDatabase.CreateAsset(asset, "Assets/MySerializedProperty.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
}