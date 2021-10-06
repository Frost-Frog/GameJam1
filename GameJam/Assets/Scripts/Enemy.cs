using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float increase;
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
    }

    // Update is called once per frame
    void Update()
    {
        increase += 1f * Time.deltaTime;
        transform.position = new Vector3(Mathf.PingPong(increase*speed,max-min)+min, transform.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            player.position = new Vector2(startposition.x, startposition.y);
        }
    }
}
