using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ChainDistance = 0.2f;

    public Dictionary<string, HingeJoint2D> HingeControl = new Dictionary<string, HingeJoint2D>();
    public void LastChain(Rigidbody2D lastchainn,string hingeName)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        HingeControl.Add(hingeName,joint);
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = lastchainn;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f,-ChainDistance);


    }
}
