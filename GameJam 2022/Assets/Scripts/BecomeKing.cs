using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeKing : MonoBehaviour
{
    public GameObject playerPeasant;
    public GameObject playerKing;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerPeasant.SetActive(false);
            playerKing.SetActive(true);
        }
    }
}
