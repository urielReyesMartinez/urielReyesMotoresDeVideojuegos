using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class evento : MonoBehaviour
{
    public TMP_Text notificacion;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GiveNotifi()
    {
        Debug.Log("GiveNotifi");

        if (counter== 15)
        {
            notificacion.text = "new goal 25 xp";
            Debug.Log("new goald 25 xp");
            PlayerPrefs.SetString("logros", notificacion.text);
        }
    }

    public void leaveGame()
    {
        PlayerPrefs.SetInt("points", counter);
        SceneManager.LoadScene("learderboard");
    }
}
