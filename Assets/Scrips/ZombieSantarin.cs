using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSantarin : MonoBehaviour
{
    public float velocityX = 0;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            rb.velocity = new Vector2(0, rb.velocity.y + 40);
        }
    
    }
}
