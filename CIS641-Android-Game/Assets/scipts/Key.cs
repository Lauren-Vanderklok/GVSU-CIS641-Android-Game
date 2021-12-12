using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public string ID;
    public bool isShipPart;


    public Key (string ID)
    {
        this.ID = ID;
        isShipPart = false;
    }

     void OnTriggerEnter2D(Collider2D other)
    {

        Inventory inventory = other.gameObject.GetComponent<Inventory>();
        //TODO: NULL checking

        inventory.addKey(this);

        Destroy(gameObject);
        
        
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
