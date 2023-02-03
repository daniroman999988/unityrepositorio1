using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto : MonoBehaviour
{
    public float MoveSpeed;
    Rigidbody2D rb;
    [SerializeField] int jumpPower;
    public Transform groundCheck;
    public LayerMask GetLayer;
    bool isGrounded;



    public KeyCode Left = KeyCode.A;
    public KeyCode Right = KeyCode.D;
    public KeyCode Up = KeyCode.W;
    public KeyCode Down = KeyCode.S;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, rb.GetComponent<BoxCollider2D>().size,
               CapsuleDirection2D.Horizontal, 0, GetLayer);
           if (Input.GetButtonDown("Jump"))
            {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            }
        Move();
    }
    public void Move()
    {
        if (Input.GetKey(Left))
        {
            transform.Translate(Vector2.left * Time.deltaTime * MoveSpeed, Space.Self);
        }
        else if (Input.GetKey(Right))
        {
            transform.Translate(Vector2.right * Time.deltaTime * MoveSpeed, Space.Self);
        }
        /* else if (Input.GetKey(Up))
            {
               transform.Translate(Vector.up * Time.deltaTime * MoveSpeed, Space.Self);

            }*/
        else if (Input.GetKey(Down))
        {
            transform.Translate(Vector2.down * Time.deltaTime * MoveSpeed, Space.Self);
        }
    }
}

