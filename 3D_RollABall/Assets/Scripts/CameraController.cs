using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 1.5f, -3.5f);
    // Start is called before the first frame update
    void Start()
    {
        //offset = new Vector3(0, 1.5f, -3.5f);
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;   
    }
}
