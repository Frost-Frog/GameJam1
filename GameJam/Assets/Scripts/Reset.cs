using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
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
}
