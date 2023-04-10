using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject itemPrefab;
    public int TotalItemCount;
    // Start is called before the first frame update
    void Start()
    {
        TotalItemCount = Random.Range(1, 6);
        for(int loop = 0; loop < TotalItemCount; loop++)
        {
            GameObject item = Instantiate(itemPrefab);
            float x = Random.Range(-4, 4);
            float y = Random.Range(-0, 1.5f);
            float z = Random.Range(-4, 4);
            item.transform.position = new Vector3(x, y, z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
