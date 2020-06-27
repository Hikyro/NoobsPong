using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Ball ball;
    [SerializeField]
    float speed;
    Rigidbody2D rb2d;
    [SerializeField]
    Vector3 direction;

    void Start()
    {
        ball = FindObjectOfType<Ball>();
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        FollowBall();
    }

    void FollowBall()
    {
        direction = new Vector3(0, gameObject.transform.position.y - ball.transform.position.y, 0).normalized;

        if(transform.position.x < ball.transform.position.x && ball.transform.position.x < 9)
        {
        transform.position -= direction * speed * Time.deltaTime;
        }
    }
}
