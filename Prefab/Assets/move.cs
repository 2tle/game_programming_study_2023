using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    private float speed = 0.3f;
    public float life = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.LeftArrow)) { transform.Translate(-3, 0, 0); }
        if(Input.GetKeyDown(KeyCode.RightArrow)) { transform.Translate(3, 0, 0); }*/



        if (Input.GetAxis("Horizontal") < 0)
        {
            if (transform.localScale.x > 0)
            {
                Vector3 characterScale = transform.localScale;
                characterScale.x *= -1;
                transform.localScale = characterScale;
            }
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            if (transform.localScale.x < 0)
            {
                Vector3 characterScale = transform.localScale;
                characterScale.x *= -1;
                transform.localScale = characterScale;
            }
        }
    }

    void FixedUpdate()
    {
        //Vector3 vec = new Vector3(speed * Input.GetAxis("Horizontal"), speed * Input.GetAxis("Vertical"), 0.0f);
        Vector3 vec = new Vector3(speed * Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.Translate(vec);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "meteor")
        {
            life -= 1f;
            if (life <= 0f)
            {
                Destroy(gameObject);
            }
        } else if(collision.tag == "item")
        {
            life += 1f;
        }
        Debug.Log(life.ToString());
        
    }
}
