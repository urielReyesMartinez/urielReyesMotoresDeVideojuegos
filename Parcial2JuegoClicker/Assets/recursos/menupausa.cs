using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menupausa : MonoBehaviour
{
    [SerializeField] private GameObject pausa;
    [SerializeField] private GameObject menupause;

    private bool juegopausa = false;
    private void Update()
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
    public void Pausa()
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
    }
    public void Cerrar()
    {
        Debug.Log("cerrando");
        Application.Quit();
    }
}
