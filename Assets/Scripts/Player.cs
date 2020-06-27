using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 mousepos;

    void Start()
    {
        Cursor.visible = false;
    }


    void Update()
    {
        Movement();
    }

    void Movement()
    {
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, mousepos.y);
    }
}
