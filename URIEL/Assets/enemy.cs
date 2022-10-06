using LanguageExt.UnitsOfMeasure;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Time = UnityEngine.Time;
using System;

public class enemy : MonoBehaviour
{
    public int vida = 50;
    public int atack = 10;
    public randomAtack=0;
    public Transform;
    public velocidad=3;
    // Start is called before the first frame update
    void Start()
    {
        public randomAtack= Random.rangue(0,4);
    switch(randomatack)
    {
        case0;
        enemy.transform(velocidad* tiem.deltamine,0,0);
        break;
         case1;
         enemy.transform(velocidad* tiem.deltamine,0,0);
         break;
        case2;(atack)
        debug.log("golpe izquierdo");
        break;
        case3;(atack)
        debug.log("golpe derecho");
        break;
        default;
        break;
    }
    }
    

    // Update is called once per frame
    void Update()
    {

    }
    private void ontrigerenter2d(collicion2d collicion)
    {
    debug.log("movimiento");
    movimiento();
    atackP();
    }

}
