using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask playermask;
    public Rigidbody2D rb;
    public float speed;
    float moveH;
    float moveV;
    public float jumpforce;
    public CircleCollider2D bc;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<CircleCollider2D>();
    }
    void Start()
    {
        //e
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal");
        moveV = Input.GetAxisRaw("Vertical");
        if(moveH != 0)
        {
           rb.velocity = new Vector2(speed * moveH, rb.velocity.y);
        }
        if(moveH == 0)
        {
            rb.velocity = new Vector2(speed * moveH, rb.velocity.y);
        }
        if(IsGrounded() && moveV != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, moveV * jumpforce);
        }
        if(moveV < 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, moveV * 20);
        }
    }
    private bool IsGrounded()
    {
        float extraheight = 0.05f;
        RaycastHit2D raycast = Physics2D.Raycast((Vector2)bc.bounds.center, Vector2.down, bc.bounds.extents.y + extraheight, playermask);
        RaycastHit2D raycast2 = Physics2D.Raycast((Vector2)bc.bounds.center + new Vector2(-0.4f,0), Vector2.down, bc.bounds.extents.y + extraheight, playermask);
        RaycastHit2D raycast3 = Physics2D.Raycast((Vector2)bc.bounds.center + new Vector2(+0.4f,0), Vector2.down, bc.bounds.extents.y + extraheight, playermask);
        Color raycolor;
        if(raycast.collider != null|| raycast3.collider != null || raycast3.collider != null)
        {
            raycolor = Color.green;
        }
        else
        {
            raycolor = Color.red;
        }
        Debug.DrawRay((Vector2)bc.bounds.center, Vector2.down * (bc.bounds.extents.y + extraheight), raycolor );
        Debug.DrawRay((Vector2)bc.bounds.center + new Vector2(-0.4f,0), Vector2.down * (bc.bounds.extents.y + extraheight), raycolor );
        Debug.DrawRay((Vector2)bc.bounds.center + new Vector2(+0.4f,0), Vector2.down * (bc.bounds.extents.y + extraheight), raycolor );
        if(raycast)
        {
            return raycast.collider != null;
        }
        else if(raycast2)
        {
            return raycast2.collider != null;
        }
        else if(raycast3)
        {
            return raycast3.collider != null;
        }
        else
        {
            return raycast.collider != null;
        }
    }
}
