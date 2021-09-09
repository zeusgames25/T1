using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCostado : MonoBehaviour
{
    public float velocityX = -10;
    public float velocityX2 = 10;
    public float jumpForce = 50;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.C))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
