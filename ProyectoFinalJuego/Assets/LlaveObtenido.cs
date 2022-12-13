using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LlaveObtenido : MonoBehaviour
{
    private int Llaves;
    public Text Llavetext;
    // Start is called before the first frame update
    void Start()
    {
        Llaves = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Lave")
        {
            Llaves++;
            Llavetext.text = "LLaves Optenido=" + Llaves;
        }
    }
}
