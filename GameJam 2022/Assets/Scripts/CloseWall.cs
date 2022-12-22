using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWall : MonoBehaviour
{
    public GameObject wall;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            wall.SetActive(true);
            Destroy(gameObject);
        }
    }
}
