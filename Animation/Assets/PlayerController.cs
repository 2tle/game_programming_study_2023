using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    public float jump = 100;
    public float walk = 10;
    public float maxWalkSpeed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       



        int dir = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) dir = -1;
        else if(Input.GetKey(KeyCode.RightArrow)) dir = 1;

        float speed = Mathf.Abs(rb.velocity.x);
        if(speed < maxWalkSpeed)
        {
            rb.AddForce(transform.right * dir* walk);
        }

        if(dir != 0)
        {
            transform.localScale = new Vector3(dir, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y==0)
        {
            rb.AddForce(transform.up * jump);
            anim.SetTrigger("JumpTrigger");
        }

        if (transform.position.y < -5)
        {
            SceneManager.LoadScene("GameScene");
        }

        if (rb.velocity.y == 0) { anim.speed = speed / 2.0f; }
        else anim.speed = 1.0f;

        

    }
}
