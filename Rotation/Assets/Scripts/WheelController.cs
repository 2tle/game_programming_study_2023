using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
        }
        
        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.99f; // °¨¼è°è¼ö

    }
}
