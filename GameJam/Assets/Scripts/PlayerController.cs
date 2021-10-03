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
            rb.velocity = new Vector2(rb.velocity.x, moveV * 3);
        }
    }
    private bool IsGrounded()
    {
        float extraheight = 0.01f;
        RaycastHit2D raycast = Physics2D.Raycast(bc.bounds.center, Vector2.down, bc.bounds.extents.y + extraheight, playermask);
        Color raycolor;
        if(raycast.collider != null)
        {
            raycolor = Color.green;
        }
        else
        {
            raycolor = Color.red;
        }
        Debug.DrawRay(bc.bounds.center, Vector2.down * (bc.bounds.extents.y + extraheight), raycolor );
        return raycast.collider != null;
    }
}
