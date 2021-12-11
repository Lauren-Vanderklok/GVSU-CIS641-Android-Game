using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour
{


    public Vector2 speedVector;
    public float timeDelaySeconds;
    //private int startTime;
    private Rigidbody2D rigidbody;
    

    // Start is called before the first frame update
    void Start()
    {


        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        //rigidbody.gravityScale = 0f;
        rigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeDelaySeconds)
        {
            // rigidbody.gravityScale = 1f;
            rigidbody.constraints = RigidbodyConstraints2D.None;
            rigidbody.velocity = speedVector;
        }
    }
}
