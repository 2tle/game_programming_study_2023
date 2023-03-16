using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    GameObject dinoskate, finish, distance;

    // Start is called before the first frame update
    void Start()
    {
        dinoskate = GameObject.Find("dinoskate");
        finish = GameObject.Find("finish");
        distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        
        float length = finish.transform.position.x - dinoskate.transform.position.x;
        if(length<=0.0f)
        {
            distance.GetComponent<Text>().text = "YOU DIED";
        }
        else distance.GetComponent<Text>().text = "낭떠러지까지 " + length.ToString("F2") + "m";
    }
}
