using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChangingComponentDirty : MonoBehaviour {

    public float FloatVar = 0.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {       
        EditorGUI.BeginChangeCheck();
        FloatVar = Mathf.Sin(Time.fixedTime);
        if (EditorGUI.EndChangeCheck())
        {
            UnityEditor.Undo.RecordObject(this, "Sin");
        }
    }
}
