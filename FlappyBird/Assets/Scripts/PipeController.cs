using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed = 0.01f;

    public float span = 20.0f;
    public float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * speed;

        delta += Time.deltaTime;
        if(delta > span)
        {
            Destroy(gameObject);
        }
    }

}
