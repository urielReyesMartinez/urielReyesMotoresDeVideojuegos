using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private float rangoalerta =5f;
    public LayerMask capaJugador;
    private bool estarAlerta;
    public Transform jugador;
    public float velocidad;
    
    //public float minimoz;
    //public float maximoz;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, rangoalerta, capaJugador);

        if (Vector3.Distance(jugador.position,transform.position)<=rangoalerta)
        {
            Vector3 posijugador = new Vector3(jugador.position.x, jugador.position.y,transform.position.z);
            
           //transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.rotation.x,transform.rotation.y,transform.rotation.z));//codigo
            //transform.LookAt(jugador);
            transform.LookAt(posijugador);
            transform.position = Vector3.MoveTowards(transform.position, posijugador, velocidad * Time.deltaTime);
           
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoalerta);
    }
    
}
