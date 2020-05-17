using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float fallMultiplier = 3f;
    public float lowJumpMultiplier = 3f;
    public float jumpVelocity = 4f;

    Rigidbody rigidPlayer2;
    // Start is called before the first frame update
    void Awake()
    {
        rigidPlayer2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        bool isPressSpace = Input.GetButtonDown("Jump");
        if(isPressSpace){
            rigidPlayer2.velocity = Vector3.up * jumpVelocity;
        }  
        if(rigidPlayer2.velocity.y < 0){
            rigidPlayer2.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rigidPlayer2.velocity.y > 0 && !Input.GetButton("Jump") && !isPressSpace){
            rigidPlayer2.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
}
