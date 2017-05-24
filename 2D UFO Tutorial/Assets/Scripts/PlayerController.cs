using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Vector2 movement = new Vector2();
    private Rigidbody2D rb2d;
    public float speedMultiplier;


    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        movement.x = moveHorizontal;
        movement.y = moveVertical;
        rb2d.AddForce(movement * speedMultiplier);
    }

}
