using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingComponent : MonoBehaviour {

    public float FloatVar = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        FloatVar = Mathf.Sin(Time.fixedTime);
	}
}
