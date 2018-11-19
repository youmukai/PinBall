using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour {
    private float minEmission = 0.3f;
    private float magEmission = 2f;
    private int degree = 0;
    private int speed = 10;
    private Color defaultColor = Color.white;
    private Material myMaterial;
    // Use this for initialization
    void Start () {
        if (this.tag == "SmallStarTag")
            this.defaultColor = Color.white;
        else if (this.tag == "LargeStarTag")
            this.defaultColor = Color.yellow;
        else if (this.tag == "SmallCloudTag" || this.tag == "LargeCloudTag")
            this.defaultColor = Color.cyan;
        this.myMaterial = this.GetComponent<Renderer>().material;
        this.myMaterial.SetColor("_EmissionColor", this.defaultColor * this.minEmission);
    }
	
	// Update is called once per frame
	void Update () {
        if (this.degree < 0)
            return;
        this.myMaterial.SetColor("_EmissionColor", this.defaultColor * (this.minEmission + Mathf.Sin((float)this.degree * ((float)Mathf.PI / 180f)) * this.magEmission));
        this.degree -= this.speed;
    }

    private void OnCollisionEnter(Collision other)
    {
        this.degree = 180;
    }

}
