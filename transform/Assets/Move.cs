using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        }

    }
}
