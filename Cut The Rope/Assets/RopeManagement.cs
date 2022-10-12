using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeManagement : MonoBehaviour
{
    public Rigidbody2D first_hook;
    public Ball _ball;
    public int numberofConnections = 5;
    public GameObject connectionPrefab;
    void Start()
    {
        RopeCreate();
    }

    void RopeCreate()
    {
        Rigidbody2D previousConnection = first_hook;

        for (int i = 0; i < numberofConnections; i++)
        {
            GameObject connection = Instantiate(connectionPrefab, transform);
            HingeJoint2D joint = connection.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousConnection;


            if (i < numberofConnections - 1)
            {
                previousConnection = connection.GetComponent<Rigidbody2D>();
            }
            else
            {
                _ball.LastChain(connection.GetComponent<Rigidbody2D>());
            }
        }
    }
}