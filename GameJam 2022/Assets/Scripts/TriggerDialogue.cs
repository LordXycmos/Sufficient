using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerDialogue : MonoBehaviour
{
    public GameObject Dialogue;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Dialogue.SetActive(true);
        }
    }
}
