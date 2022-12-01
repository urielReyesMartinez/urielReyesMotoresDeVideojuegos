using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perenemy : MonoBehaviour
{
    Vector2 enemypos;
    public GameObject playerm;
    bool perseguir;
    public int velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (perseguir)
        {
            transform.position = Vector2.MoveTowards(transform.position, enemypos, velocidad * Time.deltaTime);
        }
        if (Vector2.Distance(transform.position,enemypos)>12f)
        {
            perseguir = false;
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("player"))
        {
            enemypos = playerm.transform.position;
            perseguir = true;
        }
    }
}
