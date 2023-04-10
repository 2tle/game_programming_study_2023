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

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && rb.velocity.y==0)
        {
            rb.AddForce(Vector3.up * jumppower);
        }

        if (transform.position.y < -2 ) {
            SceneManager.LoadScene("Stage" + (manager.Stage).ToString());
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
