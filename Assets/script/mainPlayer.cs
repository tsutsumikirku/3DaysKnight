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
        //ジャンプのインターバルのプログラム
        jumpti = jumpin;
        
     







        //ゲットコンポーネント
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        string hps = hp.ToString();
        hptex.text = "HP" + hps;

        leveltex.text = "Level" + level.ToString();

        jumpti += Time.deltaTime;
        //テキストボックスの表示プログラム
        

        //移動のプログラム
        move = Input.GetAxis("Horizontal");

        rb.AddForce(Vector2.right * move * moveSpeed);


        if (move < 0.5 || move > -0.5)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }


        //バザールと武器管理のプログラム予定
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



    //ジャンプ処理
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
