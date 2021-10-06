using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poSITIONgeT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.x);
        Debug.Log(Time.time);
    }
}
