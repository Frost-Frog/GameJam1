using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatic : MonoBehaviour
{
    Vector2 startpos;
    public Transform player;
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            player.position = new Vector2(startpos.x, startpos.y);
        }
    }
}
