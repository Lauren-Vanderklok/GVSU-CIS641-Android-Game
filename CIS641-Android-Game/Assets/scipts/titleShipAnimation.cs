using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Vector2 speed;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D>();
        rigidbody.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
