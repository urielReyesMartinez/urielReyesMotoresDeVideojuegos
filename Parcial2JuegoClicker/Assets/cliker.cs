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
    public void AddClikers()
    {
        totalclikes++;
        clikertotaltext.text = totalclikes.ToString("0");
    }
    public void AutoclickUpgrade()
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

