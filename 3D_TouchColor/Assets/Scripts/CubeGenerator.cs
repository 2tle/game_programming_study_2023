using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public Color[] cubeColors;
    public GameObject cubePrefab;
    public Transform generatePos;
    public float span = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GenerateCubes");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GenerateCubes()
    {
        while(true)
        {
            GameObject c = Instantiate(cubePrefab, generatePos);
            MeshRenderer[] mrs = c.GetComponentsInChildren<MeshRenderer>();
            for(int i = 0; i < mrs.Length; i++)
            {
                int index = Random.Range(0, cubeColors.Length);
                mrs[i].material.color = cubeColors[index];
            }
            yield return new WaitForSeconds(span);
        }
    }
}
