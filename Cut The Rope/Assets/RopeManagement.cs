using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeManagement : MonoBehaviour
{
    public Rigidbody2D first_hook;
    public Ball _ball;
    public int numberofConnections = 5;
    public GameObject[] connectionPool;
    void Start()
    {
        RopeCreate();
    }

    void RopeCreate()
    {
        Rigidbody2D previousConnection = first_hook;

        for (int i = 0; i < numberofConnections; i++)
        {
            connectionPool[i].SetActive(true);

            
            HingeJoint2D joint = connectionPool[i].GetComponent<HingeJoint2D>();
            joint.connectedBody = previousConnection;


            if (i < numberofConnections - 1)
            {
                previousConnection = connectionPool[i].GetComponent<Rigidbody2D>();
            }
            else
            {
                _ball.LastChain(connectionPool[i].GetComponent<Rigidbody2D>());
            }
        }
    }
}