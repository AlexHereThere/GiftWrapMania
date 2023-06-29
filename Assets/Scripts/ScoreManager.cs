using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private int scoreValue;
    [SerializeField]
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int points)
    {
        scoreValue += points;
    }
    public void updateScore()
    {
        scoreText.text = "Score: " + scoreValue.ToString();
    }

    public int getScore()
    {
        return scoreValue;
    }
}
