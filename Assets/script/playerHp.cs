using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHp : MonoBehaviour
{
   
    // Start is called before the first frame update
    
    public int hp = 5;
    string hps;
    Text text;
    
    void Start()
    {
       text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hps = hp.ToString();
        text.text ="HP " + hps;
    }
}
