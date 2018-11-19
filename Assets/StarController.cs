using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {
    private float rotSpeed = 1f;
    // Use this for initialization
    void Start () {
        this.transform.Rotate(0.0f, (float)Random.Range(0, 360), 0.0f);
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0.0f, this.rotSpeed, 0.0f);
    }
}
