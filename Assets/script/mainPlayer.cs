using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainPlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpPower = 5f;
    public int level = 1;
    Rigidbody2D rb;
   public int bazzarl = 0;
    float move;
    int weapon = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.AddForce(Vector2.right * move * moveSpeed);

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
