using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10;
    public float jumppower = 100;
    public int itemCount = 0;
    public GameManager manager;
    public ItemGenerator itemGenerator;
    bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rb.AddForce(new Vector3(h, 0, v) * speed);
    }
    private void OnCollisionStay(Collision collision)
    {
        isGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isGround)
        {
            rb.AddForce(Vector3.up * jumppower);
        }

        if (transform.position.y < -5 ) {
            SceneManager.LoadScene("Stage" + (manager.Stage).ToString());
            //transform.position = new Vector3(0, 1, 0);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
        {
            if(itemGenerator.TotalItemCount == itemCount)
            {
                SceneManager.LoadScene("Stage"+(manager.Stage+1).ToString());
            } else
            {
                SceneManager.LoadScene("Stage" + (manager.Stage).ToString());
            }
        }
    }


}
