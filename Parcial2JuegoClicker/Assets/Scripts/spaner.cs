using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaner : MonoBehaviour
{
    public Transform enemigos;
    public Transform enemigos2;
    public Transform enemigos3;
    public Transform enemigos4;
    public Transform enemigos5;

    public GameObject[] enemyPrefab;
    public float tiemspawner=1;
    public float repeatspawner = 1;
    private int count1 = 0;
    // public float tiempdristr = 1;

    // inicializar el spawner
    void Start()
    {
        InvokeRepeating("spawnerenemies",tiemspawner,repeatspawner);
        //InvokeRepeating("destrucion", tiempdristr, tiemspawner);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //dretuir game object
    //private void Destroy(GameObject[] enemyPrefab)
    //{
       // throw new System.NotImplementedException();
    //}

    //posicionar donde apareceran los fantasmas en prefab
    public void spawnerenemies()
    {
        Vector3 spawposition = new Vector3(0, 0,0);
        spawposition = new Vector3(Random.Range(enemigos2.position.x, enemigos4.position.x), Random.Range(enemigos.position.y, enemigos5.position.y),0);
        GameObject enemy = Instantiate(enemyPrefab[Random.Range(0,enemyPrefab.Length)],spawposition,gameObject.transform.rotation);
        enemy.name = "ENEMIGOS" + count1++;
        Destroy(enemy, 4f);
    }
    
}
