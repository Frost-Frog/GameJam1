using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVertical : MonoBehaviour
{
    public float verticalmax;
    public float verticalmin;
    public float min;
    public float max;
    public float speed;
   
    // Update is called once per frame
    Vector2 startposition;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        min=transform.position.x+min;
        max=transform.position.x+max;
        startposition = player.position;
        verticalmax = transform.position.y+verticalmax;
        verticalmin = transform.position.y+verticalmin;
    }

    // Update is called once per frame
    void Update()
    {
        if(min == transform.position.x && max == transform.position.x)
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time*speed,verticalmax-verticalmin)+verticalmin , transform.position.z);
        }
        else
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time*speed,max-min)+min, Mathf.PingPong(Time.time*speed,verticalmax-verticalmin)+verticalmin , transform.position.z);
        }
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            player.position = new Vector2(startposition.x, startposition.y);
        }
    }
}
