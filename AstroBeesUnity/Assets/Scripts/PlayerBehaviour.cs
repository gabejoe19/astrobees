using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;

    public string[,] colorTraits = new string[1, 2];
    public string[,] stemTraits = new string[1, 2];
    public string[,] petalTraits = new string[1, 2];
    public string[,] thornsTraits = new string[1, 2];

    private bool onFlower = false;
    private GameObject flower;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        GrabGenes();
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        rb.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    void Movement()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down
    }

    void GrabGenes()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onFlower == true)
        {
            Debug.Log("here3");
            colorTraits = flower.GetComponent<FlowerBehaviour>().colorTraits;
            stemTraits = flower.GetComponent<FlowerBehaviour>().stemTraits;
            petalTraits = flower.GetComponent<FlowerBehaviour>().petalTraits;
            thornsTraits = flower.GetComponent<FlowerBehaviour>().thornsTraits;
            Debug.Log(colorTraits[0,0]);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("here");
        if (col.gameObject.CompareTag("flower"))
        {
            Debug.Log("here2");
            onFlower = true;
            flower = col.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("flower"))
        {
            onFlower = false;
        }
    }
}
