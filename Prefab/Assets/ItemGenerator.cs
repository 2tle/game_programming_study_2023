using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{

    public GameObject itemPrefab;
    float span = 5.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0.0f;
            GameObject m = Instantiate(itemPrefab); // 생성하다
            int x = Random.Range(-6, 7);
            m.transform.position = new Vector3(x, 7, 0);
        }
    }
}
