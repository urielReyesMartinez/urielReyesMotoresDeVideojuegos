using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recoger : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itembutt;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i <inventory.slots.Length; i++)
            {
               // if (inventory.isFull[i]==false)
              //  {
              //      Instantiate(itembutt, inventory.slots[i].transform, false);
              //      inventory.isfull[i] = true;
              //      Destroy(gameObject);
               //     break;
               // }
               
            }
        }
    }
   

	

}
