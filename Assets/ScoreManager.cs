using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int tokenScore = 0;

    public Text scoreText;

    public void IncreaseScore()
    {
        tokenScore += 10;
        scoreText.text = "Score: " + tokenScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
