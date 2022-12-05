using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguir : MonoBehaviour
{
    public float velocidadE = 6f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, player.position.y), velocidadE * Time.deltaTime);
    }
}
