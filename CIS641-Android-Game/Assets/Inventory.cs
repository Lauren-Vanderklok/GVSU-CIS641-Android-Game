using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private List<Key> inventory;

    public void addKey(Key key)
    {
        inventory.Add(key);
        //System.Console.WriteLine("here");
    }

    public void displayInventory()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        inventory = new List<Key>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
