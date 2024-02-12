using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_AI : MonoBehaviour
{
    // Start is called before the first frame update

    float paddleSpeed;

    public Main_1Player main;
    public BallController ball;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if(main.getDifficulty() == 0)
        {
            paddleSpeed = 1;
        }
        else if (main.getDifficulty() == 1)
        {
            paddleSpeed = 2;
        }
        else if (main.getDifficulty() == 2)
        {
            paddleSpeed = 3;
        }
        else
        {
            Debug.Log("Wrong");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(rb.position.y < ball.transform.position.y)
        {
            rb.MovePosition(rb.position + new Vector2(0,  paddleSpeed * Time.deltaTime));

        }
        else if (rb.position.y > ball.transform.position.y)
        {
            rb.MovePosition(rb.position - new Vector2(0,  paddleSpeed * Time.deltaTime));

        }
    }
}
