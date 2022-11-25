using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarraDeVida : MonoBehaviour
{
    public int vidaEnemy;
    public int damege;
    public Image barraVida;
    
    
    private void Update()
    {
        barraVida.fillAmount = vidaEnemy/damege;

        if (Input.GetKeyDown(KeyCode.E))
        {
            vidaEnemy -= damege;
        }
    }
}
