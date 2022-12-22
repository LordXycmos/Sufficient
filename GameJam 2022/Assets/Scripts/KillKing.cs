using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillKing : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject king;
    public GameObject deadKing;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(-5f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "King")
        {
            king.SetActive(false);
            deadKing.SetActive(true);
            Destroy(gameObject);
        }
    }
}
