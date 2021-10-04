using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject Tilemap;
    public GameObject Parent;
    public GameObject timer;
    public TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(Parent);
        SceneManager.sceneLoaded += SceneLoad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SceneLoad(Scene scene, LoadSceneMode mode)
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level4"))
        {
            timer = GameObject.Find("Scoretext");
            scoretext = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
            Parent.GetComponent<Grid>().enabled = false;
            gameObject.GetComponent<TilemapRenderer>().enabled = false;
            Tilemap.GetComponent<TilemapRenderer>().enabled = false;
            Time.timeScale = 0;
            timer.SetActive(false);
            scoretext.text = "Time: " + timer.GetComponent<Timer>().scoretime;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        
    }
}
