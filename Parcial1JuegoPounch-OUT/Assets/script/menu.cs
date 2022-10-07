using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject menuPrinci;
    public GameObject config;
    public GameObject menuTodo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
        menuTodo: SetActive(false);
        }
    }
    public void EnablemenuPrinci()
    {
        config.SetActive(false);
        menuPrinci.SetActive(true);
    }
    public void DeblemenuPrinci()
    {
        config.SetActive(true);
        menuPrinci.SetActive(false);
    }
}
