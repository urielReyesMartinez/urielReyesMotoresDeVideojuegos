using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaner : MonoBehaviour
{
    public Transform enemigos;
    public Transform enemigos2;
    public Transform enemigos3;
    public Transform enemigos4;

    public GameObject[] enemyPrefab;
    public float tiemspawner=1;
    public float repeatspawner = 1;
    private int count1 = 0;
  

    // inicializar el spawner
    void Start()//REFERENCIAR EL SAPANER
    {
        InvokeRepeating("spawnerenemies",tiemspawner,repeatspawner);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //posicionar donde apareceran los fantasmas en prefab
    public void spawnerenemies()//SPAWNER DE ENEMIGOS EN ALEATORIO COMO SU TIEMPO DE DESTRUCCION Y LA POCICION ALEATORIA CON UN CONTER DE ENEIMGOS
    {
        Vector3 spawposition = new Vector3(0, 0,0);
        spawposition = new Vector3(Random.Range(enemigos2.position.x, enemigos4.position.x),0);
        GameObject enemy = Instantiate(enemyPrefab[Random.Range(0,enemyPrefab.Length)],spawposition,gameObject.transform.rotation);
        enemy.name = "ENEMIGOS" + count1++;
        Destroy(enemy, 4f);
    }
    
}
