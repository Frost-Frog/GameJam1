using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    GameObject tilegrid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.R))
    {
        
        tilegrid = GameObject.Find("Grid3");
        tilegrid.GetComponent<Grid>().enabled = false;
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
        Destroy(GameObject.Find("Time"));
    } 
    }
}
