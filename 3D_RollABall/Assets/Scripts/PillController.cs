using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 100 * Time.deltaTime, Space.World); // Time.deltaTime -> 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().itemCount++;
            gameObject.SetActive(false);
            Debug.Log("Get Item: "+gameObject.name+" | ItemCount : "+other.GetComponent<PlayerController>().itemCount);
        }
    }
}
