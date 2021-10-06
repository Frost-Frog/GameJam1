using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatic : MonoBehaviour
{
    Vector2 startposition;
    public Transform player;
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            player.transform.position = new Vector2(startposition.x, startposition.y);
        }
    }
}
