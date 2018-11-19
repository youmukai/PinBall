using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    private int score = 0;
    private GameObject scoreText;
    // Use this for initialization
    void Start () {
        this.scoreText = GameObject.Find("ScoreText");
        this.RefreshScoreText();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision other)
    {
        string tag = other.gameObject.tag;
        if (tag == "SmallStarTag")
            this.GetScore(1);
        else if (tag == "LargeStarTag" || tag == "SmallCloudTag")
        {
            this.GetScore(20);
        }
        else if (tag == "LargeCloudTag")
        {
            this.GetScore(160);
        }
    }
    private void GetScore(int getScore)
    {
        this.score += getScore;
        this.RefreshScoreText();
    }
    private void RefreshScoreText()
    {
        this.scoreText.GetComponent<Text>().text = "Score:" + (object)this.score;
    }
}
