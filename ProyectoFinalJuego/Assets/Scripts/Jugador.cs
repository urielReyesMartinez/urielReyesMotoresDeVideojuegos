using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [Header("Horizontal")]
    private float MovimientoHorizontal = 0f;
    [SerializeField] private float suavizadomovimiento;
    [SerializeField] private float velocidadmovimiento;
    private Vector3 velocidad = Vector3.zero;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        MovimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadmovimiento;
    }
    private void FixedUpdate()
    {
        Mover(MovimientoHorizontal * Time.fixedDeltaTime);

    }
    private void Mover(float mover)
    {
        Vector3 velocidadObjetivo = new Vector3(mover, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadObjetivo, ref velocidad, suavizadomovimiento);
    }
   
    
    private void OnTriggerEnter(Collider other)//matar al jugador con este script al jugador
    {
       if (other.CompareTag("enemy"))
       {
           Debug.Log("muerte jugador");

       }
    }
   
}
