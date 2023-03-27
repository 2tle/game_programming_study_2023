using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump = 100;
    public float walk = 10;
    public float maxWalkSpeed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jump);
        }

    }
}
