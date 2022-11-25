using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrinci : MonoBehaviour
{
    
    public void Jugar()
    {
        SceneManager.LoadScene("comojugar");
    }
    //public void Multijugador()
    //{
    //  SceneManager.LoadScene("Multijugador");
    //}
    //public void Creditos()
    //{
    //SceneManager.LoadScene("Creditos");
    //}
    public void Salir()
    {
        Application.Quit();

    }
    public void Seguir()
    {
        SceneManager.LoadScene("JuegoFinal");
    }
}
