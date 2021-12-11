using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Movment : MonoBehaviour
{
    public bool up;
    public bool down;
    public bool right;
    public bool left;
    public float speed;
    public bool slowdown;

    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Sprite[] sprites;

    public void setUpState (bool state)
    {
        up = state;
        animator.enabled = state;
        
        if (state == false)
        {
            spriteRenderer.sprite = sprites[1];
        }
    }

    public void setDownState(bool state)
    {
        down = state;
        animator.enabled = state;

        if (state == false)
        {
            spriteRenderer.sprite = sprites[0];
        }
    }

    public void setRightState(bool state)
    {
        right = state;
        animator.enabled = state;

        if (state == false)
        {
            spriteRenderer.sprite = sprites[2];
        }
    }

    public void setLeftState(bool state)
    {
        left = state;
        animator.enabled = state;

        if (state == false)
        {
            spriteRenderer.sprite = sprites[3];
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;

        spriteRenderer = GetComponent<SpriteRenderer>();

        sprites = Resources.LoadAll<Sprite>("Sprites/Alien+ship");

        //speed = .04f;
        slowdown = false;
    }

    // Update is called once per frame
    void Update()
    {
        //float x = Input.GetAxisRaw(“Horizontal”);
        //float y = Input.GetAxisRaw(“Vertical”);

        

        if (up)
        {
            gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + speed);

            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("AlienWalkingUp"))
            {
                animator.Play("AlienWalkingUp");
            }
        }
        else if (down)
        {
            gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + -speed);

            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("AlienWalkingDown"))
            {
                animator.Play("AlienWalkingDown");
            }
        }
        else if (right)
        {
            gameObject.transform.position = new Vector2(transform.position.x + speed, transform.position.y);

            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("AlienWalkingRight"))
            {
                animator.Play("AlienWalkingRight");
            }
        }
        else if (left)
        {
            gameObject.transform.position = new Vector2(transform.position.x + -speed, transform.position.y);

            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("AlienWalkingLeft"))
            {
                animator.Play("AlienWalkingLeft");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "slowdown")
        {
            slowdown = true;
            speed = .07f;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "slowdown")
        {
            slowdown = false;
            speed = .15f;
        }
            
    }
        
}

    