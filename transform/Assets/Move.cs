using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static float speed = 0.13f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽 키 눌림");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽 키 눌리는 중");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽 키 눌렸음");
        }*/

        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 vec = new Vector3(0.1f, 0.0f, 0.0f);
            transform.Translate(vec);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 vec = new Vector3(-0.1f, 0.0f, 0.0f);
            transform.Translate(vec);
        }
        if(Input.GetKey(KeyCode.UpArrow)) {
            Vector3 vec = new Vector3(0.0f, 0.1f, 0.0f);
            transform.Translate(vec);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 vec = new Vector3(0.0f, -0.1f, 0.0f);
            transform.Translate(vec);
        }*/

        Vector3 vec = new Vector3(speed * Input.GetAxis("Horizontal"), speed * Input.GetAxis("Vertical"), 0.0f);
        transform.Translate(vec);

        /*if(Input.GetAxis("Horizontal") < 0)
        {
            if(transform.localScale.x > 0)
            {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            }
        } 
        else if(Input.GetAxis("Horizontal") > 0)
        {
            if(transform.localScale.x < 0)
            {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            }
        }*/

        if(Input.GetAxis("Horizontal") < 0)
        {
            if(transform.localScale.x > 0)
            {
                Vector3 characterScale = transform.localScale;
                characterScale.x *= -1;
                transform.localScale = characterScale;
            }
        }
        else if(Input.GetAxis("Horizontal") > 0)
        {
            if (transform.localScale.x < 0)
            {
                Vector3 characterScale = transform.localScale;
                characterScale.x *= -1;
                transform.localScale = characterScale;
            }
        }


        if(Input.GetKeyDown(KeyCode.P))
        {
            
            Vector3 characterScale = transform.localScale;
            if(characterScale.x < -0)
            {
                characterScale.x -= 0.2f;
                characterScale.y += 0.2f;
            } else
            {
                characterScale.x += 0.2f;
                characterScale.y += 0.2f;
            }
            
            transform.localScale = characterScale;
        }

        if(Input.GetKeyDown(KeyCode.M))
        {
            Vector3 characterScale = transform.localScale;
            if(characterScale.x > 0.2f && characterScale.y > 0.2f ) {
                characterScale.x -= 0.2f;
                characterScale.y -= 0.2f;
               
            } else if(characterScale.x < -0.2f && characterScale.y > 0.2f)
            {
                characterScale.x += 0.2f;
                characterScale.y -= 0.2f;
            }
            transform.localScale = characterScale;
        }

    }
}
