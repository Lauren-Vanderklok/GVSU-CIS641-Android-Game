using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public string InventoryPanelName = "Inventory_Panel";
    public string InventoryScrollContentName = "ScrollContent";


    private List<Key> inventory;
    private GameObject panel;
    private GameObject content;

    public void addKey(Key key)
    {
        inventory.Add(key);
        //System.Console.WriteLine("here");
    }

    public void displayInventory()
    {


        if (panel.activeSelf)
        {
            panel.SetActive(false);
            
        }
        else
        {
            panel.SetActive(true);

            float xPos = 10;
            float yPos = -10;

           
            foreach (Key key in inventory)
            {
                RectTransform parentRect = content.GetComponent<RectTransform>();

                GameObject NewObj = new GameObject();
                Image NewImage = NewObj.AddComponent<Image>();
                NewImage.sprite = Resources.Load<Sprite>("Keys/" + key.ID);
                NewObj.GetComponent<RectTransform>().SetParent(content.transform); //Assign the newly created Image GameObject as a Child of the Parent Panel.
                NewObj.transform.SetParent(content.transform, false);

                 RectTransform childRect = NewObj.GetComponent<RectTransform>();

                //childRect.rect.width = 10;

                NewObj.transform.localPosition = new Vector3(
                     (-parentRect.rect.width / 2) + (childRect.rect.width / 2) + xPos,
                     (parentRect.rect.height / 2) + (-childRect.rect.height / 2) + yPos,
                    0);
                NewObj.SetActive(true); //Activate the GameObject

                xPos += 10 + childRect.rect.width;
                if (xPos > parentRect.rect.width) 
                {
                    xPos = 10;
                    yPos -= 10 + childRect.rect.height;
                }
            }

        }

        //add keys
    }


    // Start is called before the first frame update
    void Start()
    {
        inventory = new List<Key>();
        panel = GameObject.Find(InventoryPanelName);
        content = GameObject.Find(InventoryScrollContentName);
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
