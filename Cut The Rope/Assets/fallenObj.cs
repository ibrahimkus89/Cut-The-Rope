using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallenObj : MonoBehaviour
{
    [SerializeField] private AudioSource sound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            sound.Play();
        }
    }
}
