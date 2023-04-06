using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipePrefab;
    float span = 3.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            delta = 0;
            GameObject pipeObject = Instantiate(pipePrefab);
            float yPosition = Random.Range(-5.3f, -1.9f);
            pipeObject.transform.position = new Vector3(3.0f, yPosition, 0);



        }
    }
}
