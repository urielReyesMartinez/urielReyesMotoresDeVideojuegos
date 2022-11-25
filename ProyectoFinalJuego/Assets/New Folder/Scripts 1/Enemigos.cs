using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemigos : MonoBehaviour
{

    public GameObject EnemyPrefab;
    public int vidaEnemy;
    public int damege;
    public Image barraVida;
    public Text clikertotaltext;
    private int Totalclikes=10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Vector2 randomSpawnposition = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
            Instantiate(EnemyPrefab, randomSpawnposition, Quaternion.identity);

        }
        barraVida.fillAmount = vidaEnemy / damege;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            vidaEnemy -= damege;
        }
    }
    public void Addlikers()
    {
        Totalclikes--;
        clikertotaltext.text = Totalclikes.ToString("0");
    }
}
