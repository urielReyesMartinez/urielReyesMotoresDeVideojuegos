using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrinci : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void JugarJuego()
    {
        SceneManager.LoadScene("escena2");
    }
    public void MenuStart()
    {
        SceneManager.LoadScene("Menustart");

    }
}
