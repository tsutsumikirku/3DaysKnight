using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextLv : MonoBehaviour
{
    Text text;
    [SerializeField] GameObject mainplayer = null;
    [SerializeField] int next = 100;
    int nextlv;
    // Start is called before the first frame update
    void Start()
    {
        
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       nextlv =       
      text.text = nextlv.ToString();
    }
}
