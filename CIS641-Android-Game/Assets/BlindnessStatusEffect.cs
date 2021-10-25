using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindnessStatusEffect : MonoBehaviour
{
    public string blindnessSpriteName = "BlindnessEffect";
    public GameObject blindnessSprite;

    public void startBlindness()
    {
        blindnessSprite.SetActive(true);
    }

    public void stopBlindness()
    {
        blindnessSprite.SetActive(false);
    }





    // Start is called before the first frame update
    void Start()
    {
        blindnessSprite = GameObject.Find(blindnessSpriteName);
        stopBlindness();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
