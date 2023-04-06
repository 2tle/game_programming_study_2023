using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            ScoreManager.score += 1;
        }
    }
}
