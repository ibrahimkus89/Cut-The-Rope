using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
   

    [SerializeField] private GameObject[] Rope_Centers;
    [SerializeField] private int totalNumberOfBalls;
    [SerializeField] private int fallTheObject;
    [SerializeField] private AudioSource[] Sounds;
    [SerializeField] private ParticleSystem WinEffect;
    [SerializeField] private ParticleSystem CutEffect;



    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Sounds[0].Play();
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Center1"))
                {
                    ChainTechProcess(hit, "Center1");

                }
                else if (hit.collider.CompareTag("Center2"))
                {
                    ChainTechProcess(hit, "Center2");

                }

                else if (hit.collider.CompareTag("Center3"))
                {
                    ChainTechProcess(hit, "Center3");

                }

                else if (hit.collider.CompareTag("Center4"))
                {
                    ChainTechProcess(hit, "Center4");

                }
            }


        }
    }



    void ChainTechProcess(RaycastHit2D hit, string HingeName)
    {
        hit.collider.gameObject.SetActive(false);
        CutEffect.transform.position = hit.collider.gameObject.transform.position;
        CutEffect.Play();
        foreach (var item in Rope_Centers)
        {
            if (item.GetComponent<RopeManagement>().hingeName == HingeName)
            {
                foreach (var item2 in item.GetComponent<RopeManagement>().connectionPool)
                {
                    item2.SetActive(false);
                }
            }
        }
    }


    public void BallFall()
    {
        totalNumberOfBalls--;
        if (totalNumberOfBalls == 0)
        {
            if (fallTheObject > 0)
            {
                Lost();

            }
            else if (fallTheObject == 0)
            {
                Win();

            }
        }
        else
        {
            if (fallTheObject == 0)
            {
                Win();

            }
        }

    }

    public void TargetObjectFall()
    {
        fallTheObject--;

        if (totalNumberOfBalls == 0 && fallTheObject == 0)
        {
            Win();
        }

        else if (totalNumberOfBalls == 0 && fallTheObject > 0)
        {
            Lost();

        }
    }

    void Win()
    {
        Debug.Log("Win");
        WinEffect.Play();
       
        Sounds[2].Play();
       
        Time.timeScale = 0;
    }

    void Lost()
    {
        Debug.Log("Lost");       
       
        Sounds[1].Play();
        
        Time.timeScale = 0;

    }



}

