using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public string ID;
    public bool isShipPart;

    private void OnTriggerEnter(Collider other)
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
