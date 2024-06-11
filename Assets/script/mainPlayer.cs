using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainPlayer : MonoBehaviour
{
    Text text;
    [SerializeField] float Hp = 5f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpPower = 5f;
    [SerializeField] GameObject nextlv;
    [SerializeField] GameObject Hptex;
    
    public float level = 1f;
    Rigidbody2D rb;
   public int bazzarl = 0;
    float move;
    int weapon = 1;
    float nextlev;
    
    // Start is called before the first frame update
    void Start()
    {
       

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Text Hplih = Hptex.GetComponent<Text>();
        Hplih.text ="HP" +  Hp.ToString();




        nextlev = level * 100;
        Text nextlevel = nextlv.GetComponent<Text>();
        nextlevel.text ="NextLv" + nextlev.ToString();
        
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
