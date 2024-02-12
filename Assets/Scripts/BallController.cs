using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public float ballSpeed;
    public int xDirection = 0;
    public float yDirection = 1;

    public Main_1Player main;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        ballReset();
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(xDirection * ballSpeed * Time.deltaTime, yDirection * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Paddle"))
        { 
            xDirection *= -1;
            yDirection = (transform.position.y - collision.transform.position.y) * 1.65f;


            if (main.getDifficulty() == 0)
            {
                ballSpeed += 0.3f;
            }
            
        }
        else if (collision.transform.CompareTag("Top") || collision.transform.CompareTag("Bottom"))
        {
            yDirection *= -1;
        }
        else if (collision.transform.CompareTag("Left"))
        {
            //Restart
            main.incrementP1Score();
            ballReset();
        }
        else if (collision.transform.CompareTag("Right"))
        {
            //Restart
            main.incrementP2Score();
            ballReset();
        }
    }

    private void ballReset()
    {
        transform.position = Vector2.zero;

        while (xDirection == 0)
        {
            xDirection = (int)Random.Range(-1, 2);
        }

        yDirection = Random.Range(-1.0f, 1.0f);

        // default speed
        if (main.getDifficulty() == 0)
        {
            ballSpeed = 4;
        }
        else if (main.getDifficulty() == 1)
        {
            ballSpeed = 5;
        }
        else if (main.getDifficulty() == 2)
        {
            ballSpeed = 6;
        }
    }


}
