using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float fly = 300;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(transform.up * fly);
        }

        if(transform.position.x <= -3.2 || transform.position.y > 5.25)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
