using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball _Ball;

    [SerializeField] private GameObject[] Rope_Centers;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);

            if (hit.collider!=null)
            {
                if (hit.collider.CompareTag("Center1"))
                {
                    //Destroy(hit.collider.gameObject);
                    hit.collider.gameObject.SetActive(false);

                    //_Ball.HingeControl["Center1"].enabled = false;

                    foreach (var item in Rope_Centers)
                    {
                        if (item.GetComponent<RopeManagement>().hingeName =="Center1")
                        {
                            foreach (var item2 in item.GetComponent<RopeManagement>().connectionPool)
                            {
                                item2.SetActive(false);
                            }
                        }
                    }
                }
               else if (hit.collider.CompareTag("Center2"))
                {
                    //Destroy(hit.collider.gameObject);

                    hit.collider.gameObject.SetActive(false);

                    // _Ball.HingeControl["Center2"].enabled = false;

                    foreach (var item in Rope_Centers)
                    {
                        if (item.GetComponent<RopeManagement>().hingeName == "Center2")
                        {
                            foreach (var item2 in item.GetComponent<RopeManagement>().connectionPool)
                            {
                                item2.SetActive(false);
                            }
                        }
                    }
                }
            }

            
        }
    }
}
