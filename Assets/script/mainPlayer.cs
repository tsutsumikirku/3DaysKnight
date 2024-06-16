using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainPlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpPower = 5f;
    public Text nextLevel;
    public int level = 1;
    public int bazzarl = 0;
    Rigidbody2D rb;
    float move;
    int weapon = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        nextLevel = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.AddForce(Vector2.right * move * moveSpeed);
        if(move == 0)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if(weapon == 1 && bazzarl == 0)
        {

        }
        if(weapon == 2 && bazzarl == 0)
        {

        }
        if (weapon == 3 && bazzarl == 0)
        {

        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.tag == "floor")
        {
            if(Input.GetButton("Jump"))
            {
                rb.AddForce(Vector2.up * jumpPower * 3);
            }
        }
    }
}
