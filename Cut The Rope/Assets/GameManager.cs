using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //[SerializeField] private Ball _Ball;

    [SerializeField] private GameObject[] Rope_Centers;
    [SerializeField] private int totalNumberOfBalls;
    [SerializeField] private int fallTheObject;
    


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
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
                Debug.Log("Lost");

            }
            else if (fallTheObject == 0)
            {
                Debug.Log("Win");

            }
        }
        else
        {
            if (fallTheObject == 0)
            {
                Debug.Log("Win");

            }
        }

    }

    public void TargetObjectFall()
    {
        fallTheObject--;

        if (totalNumberOfBalls == 0 && fallTheObject == 0)
        {
            Debug.Log("Win");
        }

        else if (totalNumberOfBalls == 0 && fallTheObject > 0)
        {
            Debug.Log("Lost");

        }
    }

   

    }

