using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainPlayer : MonoBehaviour
{
    
    [SerializeField] float hp = 5f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpPower = 5f;
    public int level = 1;
    public int bazzarl = 0;

    public Text nextLevel;



    Rigidbody2D rb;
    float move;
    int weapon = 1;
    
    // Start is called before the first frame update
    void Start()
    {
       
        //�Q�b�g�R���|�[�l���g
        rb = GetComponent<Rigidbody2D>();
        nextLevel = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {

        //�ړ��̃v���O����
        move = Input.GetAxis("Horizontal");
        rb.AddForce(Vector2.right * move * moveSpeed);
        if(move < 0.5 || move > -0.5)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        
        //�o�U�[���ƕ���Ǘ��̃v���O�����\��
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



    //�W�����v����
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
