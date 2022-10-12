using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ChainDistance = 0.2f;
    
    public void LastChain(Rigidbody2D lastchainn)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = lastchainn;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f,-ChainDistance);


    }
}
