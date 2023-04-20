using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    CubeGenerator gen;
    MeshRenderer MR;
    int colorIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Setup(CubeGenerator gen)
    {
        this.gen = gen;
        MR = GetComponent<MeshRenderer>();
        MR.material.color = this.gen.cubeColors[colorIndex];
        colorIndex = 0;
    }
    public void ChangeColor()
    {
        if (colorIndex < gen.cubeColors.Length - 1) colorIndex++;
        else colorIndex = 0;
        MR.material.color = gen.cubeColors[colorIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        MeshRenderer r = other.GetComponent<MeshRenderer>();
        if(MR.material.color == r.material.color)
        {
            Checker.correct++;
        } else
        {
            Checker.wrong++;
        }
    }
}
