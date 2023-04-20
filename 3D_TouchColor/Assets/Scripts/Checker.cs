using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker : MonoBehaviour
{
    public CubeGenerator gen;
    public Controller[] touchCubes;

    public static int correct = 0;
    public static int wrong = 0;
    // Start is called before the first frame update
    void Start()
    {
        touchCubes = GetComponentsInChildren<Controller>();
        for(int i = 0; i < touchCubes.Length; i++)
        {
            touchCubes[i].Setup(gen);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(correct + wrong == touchCubes.Length)
        {
            if (wrong == 0) { 
                Debug.Log("성공");
                IncreaseScore.score++;
            }
            else { 
                Debug.Log("실패");
                //IncreaseScore.score--;
                SceneManager.LoadScene("EndingScene");
            }
        }
        correct = 0; wrong=0;

    }
}
