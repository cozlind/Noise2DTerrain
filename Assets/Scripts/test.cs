using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    for(int i = 0; i < 20; i++)
        {
            Debug.Log(Mathf.PerlinNoise(i+0.1f,1));
        }
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
