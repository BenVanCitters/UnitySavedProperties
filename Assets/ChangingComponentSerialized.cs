using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MySerializedProperty : ScriptableObject
{
    public float FloatVar = 0.0f;
}

public class ChangingComponentSerialized : MonoBehaviour
{
    public MySerializedProperty obj;
    public SerializedObject serializedObject;
    public UnityEditor.SerializedProperty serializedPropertyFloatVar;

    // Use this for initialization
    void Start () {
        if (obj == null)
        {
            obj = ScriptableObject.CreateInstance<MySerializedProperty>();
        }
        serializedObject = new UnityEditor.SerializedObject(obj);
        serializedPropertyFloatVar = serializedObject.FindProperty("FloatVar");
    }
	
	// Update is called once per frame
	void Update () {        
        serializedObject.Update();
        serializedPropertyFloatVar.floatValue = Mathf.Sin(Time.fixedTime);
        serializedObject.ApplyModifiedProperties();
        Debug.Log("FloatVar " + serializedPropertyFloatVar.floatValue);
    }
}
