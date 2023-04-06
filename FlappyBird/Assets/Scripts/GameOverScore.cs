using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    public static int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Score: "+ScoreManager.score.ToString();
        if(ScoreManager.score > bestScore )
        {
            bestScore = ScoreManager.score;
        }
        ScoreManager.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
