using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallMessenger : MonoBehaviour
{
    [SerializeField] private GameManager _GameManager;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TargetObject"))
        {
            _GameManager.TargetObjectFall();
        }
        else if (collision.CompareTag("Ball"))
        {
            _GameManager.BallFall();
        }
    }
}
