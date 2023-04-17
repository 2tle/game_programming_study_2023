using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RaycastEvent : UnityEvent<Transform> { }

public class Detector : MonoBehaviour
{
    public RaycastEvent raycastEvent = new RaycastEvent();
    public LayerMask lm;
    public Camera cam;
    public Ray ray;
    public RaycastHit hit;
    // Start is called before the first frame update
    private void Awake()
    {
        cam = Camera.main;        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit, Mathf.Infinity, lm))
            {
                raycastEvent.Invoke(hit.transform);
            }
        }
    }
}
