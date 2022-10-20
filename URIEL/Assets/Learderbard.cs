using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Learderbard : MonoBehaviour
{
    public int Points = 0;
    public int Logro;
    public TMP_Text PointsText;
    public TMP_Text logroText;

    // Start is called before the first frame update
    void Start()
    {
        Points = PlayerPrefs.GetInt("points");
        Logro = PlayerPrefs.GetInt("logro");
        PointsText.text = Points.ToString();
        logroText.text = Logro.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
