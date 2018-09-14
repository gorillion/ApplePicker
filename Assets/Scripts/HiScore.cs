using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiScore : MonoBehaviour {

    static public int score = 1000;

	// Use this for initialization
	void Start () {
		
	}

    void Awake()
    {
        if (PlayerPrefs.HasKey("HiScore"))
            score = PlayerPrefs.GetInt("HiScore");

        PlayerPrefs.SetInt("HiScore", score);
    }
	
	// Update is called once per frame
	void Update () {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;

        if (score > PlayerPrefs.GetInt("HiScore"))
            PlayerPrefs.SetInt("Hiscore", score);
	}
}
