using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testAnimation : MonoBehaviour
{

    public AnimationClip rightWalking;
    //private Animation anim;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play("AlienWalkingLeft");


        //anim = GetComponent<Animation>();
        //anim.clip = rightWalking;
        //anim.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
