using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainPlayer : MonoBehaviour
{

    [SerializeField] float hp = 5f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpPower = 5f;
    [SerializeField] float jumpin;
    public int level = 1;
    [SerializeField] Text hptex;
    [SerializeField] Text leveltex;
    public int bazzarl = 0;
    float jumpti;
    Rigidbody2D rb;
    float move;
    int weapon = 1;

    // Start is called before the first frame update
    void Start()
    {
        //�W�����v�̃C���^�[�o���̃v���O����
        jumpti = jumpin;
        
     







        //�Q�b�g�R���|�[�l���g
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        string hps = hp.ToString();
        hptex.text = "HP" + hps;

        leveltex.text = "Level" + level.ToString();

        jumpti += Time.deltaTime;
        //�e�L�X�g�{�b�N�X�̕\���v���O����
        

        //�ړ��̃v���O����
        move = Input.GetAxis("Horizontal");

        rb.AddForce(Vector2.right * move * moveSpeed);


        if (move < 0.5 || move > -0.5)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }


        //�o�U�[���ƕ���Ǘ��̃v���O�����\��
        if (weapon == 1 && bazzarl == 0)
        {

        }
        if (weapon == 2 && bazzarl == 0)
        {

        }
        if (weapon == 3 && bazzarl == 0)
        {

        }
    }



    //�W�����v����
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "floor" )
        {
            if(Input.GetButton("Jump") && jumpin < jumpti )
            {
                jumpti = 0;
                rb.AddForce(Vector2.up * jumpPower * 3);
            }
        }
    }
}
