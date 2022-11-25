using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cliker : MonoBehaviour
{
    public Text clikertotaltext;
    float totalclikes;
    //bool hasupgrade;
    //public int autoclicksPersecond;
    //public int mininumckstoulock;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    public void AddClikers()//EL TOTAL DE LOS CLIKER QUE DAN EN EL BOTON
    {
        totalclikes++;
        clikertotaltext.text = totalclikes.ToString("0");
    }
    public void AutoclickUpgrade()//SUPUESTO BOTON DONDE PODRIA HACER UN AUTOCLIKER PERO NO COMO MULTIPLICADOR
    {
        //if(!hasUpgrade && totalclikes>=mininumckstoulockUpagrade)
        {
            //totalclikes -= mininumckstoulockUpgrade;
           // hasUpgrade = true;
        }
    }
    public void Update()
    {
        //if (hasUpgrade)
        {
           // totalclikes += autoclicksPersecond * Time.deltaTime;
            //clikertotaltext.text = totalclikes.ToString("0");
        }
    }
}

