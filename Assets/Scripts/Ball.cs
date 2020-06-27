using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    GameManager scoreManager;
    AudioSource audiotrigger;
    [SerializeField]
    AudioClip leftcolision;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(Vector2.right * speed,ForceMode2D.Impulse);
        scoreManager = FindObjectOfType<GameManager>();
        audiotrigger = GetComponent<AudioSource>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        audiotrigger.PlayOneShot(leftcolision);

        if(other.tag == "Palette") PaletaMovement(other.transform);

        if(other.tag == "Border") BordeMovement(other.transform);

        if(other.tag == "Goal")
        {
            scoreManager.SetPoints();
            Invoke("Respawn", 2);
        }

    }

    void PaletaMovement(Transform player)
    {
        rb2d.velocity = Vector2.zero;
        rb2d.AddForce(new Vector3(transform.position.x - player.transform.position.x, (transform.position.y - player.transform.position.y)/3.5f, 0).normalized * speed, ForceMode2D.Impulse);
    }

    void BordeMovement(Transform borde)
    {
         rb2d.AddForce(new Vector3(0, -(transform.position.y - borde.transform.position.y/3.5f), 0).normalized * speed, ForceMode2D.Impulse);
    }

    void Respawn()
    {
        transform.position = Vector3.zero;
        rb2d.velocity = Vector3.zero;
        rb2d.AddForce(Vector2.right * speed,ForceMode2D.Impulse);
    }
}
