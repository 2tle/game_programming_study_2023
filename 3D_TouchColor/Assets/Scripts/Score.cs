using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Score: "+IncreaseScore.score.ToString();
        if(IncreaseScore.score > bestScore)
        {
            bestScore = IncreaseScore.score;
        }
        IncreaseScore.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
