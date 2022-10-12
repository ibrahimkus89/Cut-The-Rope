using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball _Ball;
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

                    _Ball.HingeControl["Center1"].enabled = false;
                }
               else if (hit.collider.CompareTag("Center2"))
                {
                    //Destroy(hit.collider.gameObject);

                    hit.collider.gameObject.SetActive(false);

                    _Ball.HingeControl["Center2"].enabled = false;
                }
            }

            
        }
    }
}
