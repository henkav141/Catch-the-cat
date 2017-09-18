using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    private int scoreInt;
    public int catValue;


	// Use this for initialization
	void Start ()
	{
	    scoreInt = 0;
	    ScoreText.text = "Score:\n" + scoreInt;
        UpdateScore();
	}

    void OnTriggerEnter2D()
    {
        scoreInt += catValue;
        UpdateScore();

    }

    void UpdateScore () {
	    ScoreText.text = ScoreText.text = "Score:\n" + scoreInt;
    }
}
