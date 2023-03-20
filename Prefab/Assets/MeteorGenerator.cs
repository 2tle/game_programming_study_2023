using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{
    public GameObject meteorPrefab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta> span)
        {
            delta = 0.0f;
            GameObject m = Instantiate(meteorPrefab); // 생성하다
            int x = Random.Range(-6, 7);
            m.transform.position = new Vector3(x, 7, 0);
        }
    }
}
