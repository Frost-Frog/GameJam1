using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class Grid3 : MonoBehaviour
{
    public GameObject portal;
    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    { 
        GetComponent<Grid>().enabled = false;
        portal.SetActive(false);
        tile.SetActive(false);
        SceneManager.sceneLoaded+=Scene3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Scene3(Scene scene, LoadSceneMode mode)
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
            GetComponent<Grid>().enabled = false;
            portal.SetActive(false);
            tile.SetActive(false);
        }
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3"))
        {
            GetComponent<Grid>().enabled = true;
            portal.SetActive(true);
            tile.SetActive(true);
            portal.GetComponent<TilemapRenderer>().enabled = true;
            tile.GetComponent<TilemapRenderer>().enabled = true;
        }
    }
}
