using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelController : MonoBehaviour
{
    public float accelForce;
    public Vector3 dir;


    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.GetComponent<Rigidbody>().AddForce(dir*accelForce);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
