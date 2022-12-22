using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject guardOne;
    public GameObject guardTwo;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            door.SetActive(true);
            guardOne.SetActive(false);
            guardTwo.SetActive(false);
        }
    }
}
