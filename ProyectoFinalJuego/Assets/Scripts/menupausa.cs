using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menupausa : MonoBehaviour
{
    [SerializeField] private GameObject pausa;
    [SerializeField] private GameObject menupause;
    [SerializeField] private GameObject menuPrincipal;

    private bool juegopausa = false;
    private void Update()//PANEL DE PAUSA
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (juegopausa)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }
    }
    public void Pausa()//EL CONGELAR EL JUEGO PARA MOSTRAR LOS BOTONES Y SELECIONAR EL SCRIP
    {
        Time.timeScale = 0f;
        pausa.SetActive(false);
        menupause.SetActive(true);
        

    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        pausa.SetActive(false);
        menupause.SetActive(false);
        menuPrincipal.SetActive(false);

    }
    public void menuprinci()//CAMBIAR O REGRESAR ALA ESCENA DE MENI PRINCIPAL
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("menuprincipal");

    }
    public void Cerrar()
    {
        Debug.Log("cerrando");
        Application.Quit();
    }
}
