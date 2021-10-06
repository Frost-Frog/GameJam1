using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothspeed = 10f;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            if(GameObject.Find("Grid") != null)
        {
            Destroy(GameObject.Find("Grid"));
        }
            Destroy(GameObject.Find("Scoretext"));
            SceneManager.LoadScene("Level1");
            Time.timeScale = 1;
        }
    }
    void FixedUpdate()
    {
        Vector3 desiredposition = target.position + offset;
        Vector3 smoothedpos = Vector3.Lerp(transform.position, desiredposition, smoothspeed*Time.deltaTime);
        transform.position = smoothedpos;
    }
}   
