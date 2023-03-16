using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public float rotSpeed = 0;
    public bool isRoll = false;

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
            isRoll = true;
        }
        
        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.99f; // °¨¼è°è¼ö

        if (isRoll && rotSpeed < 0.01f)
        {
            int minIdx = 0;
            float minZAngle = 360.0f;
            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                {
                    if (transform.GetChild(i).eulerAngles.z < minZAngle)
                    {
                        if (360.0f - transform.GetChild(6).eulerAngles.z < transform.GetChild(i).eulerAngles.z)
                        {
                            minZAngle = transform.GetChild(6).eulerAngles.z;
                            minIdx = 6;
                        }
                        else
                        {
                            minIdx = 0;
                            minZAngle = transform.GetChild(0).eulerAngles.z;
                        }
                    }
                }
                else
                {
                    if (transform.GetChild(i).eulerAngles.z < minZAngle)
                    {
                        if (360.0f - transform.GetChild(i - 1).eulerAngles.z < transform.GetChild(i).eulerAngles.z)
                        {
                            minZAngle = transform.GetChild(i - 1).eulerAngles.z;
                            minIdx = i - 1;
                        }
                        else
                        {
                            minIdx = i;
                            minZAngle = transform.GetChild(i).eulerAngles.z;
                        }

                    }
                }




            }
            Debug.Log(minZAngle);
            Debug.Log(transform.GetChild(minIdx).name);
            isRoll = false;
        }

    }
}
