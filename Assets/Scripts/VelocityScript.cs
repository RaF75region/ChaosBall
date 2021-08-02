using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{
    public float startSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigiBoduy = GetComponent<Rigidbody>();
        rigiBoduy.velocity = new Vector3(startSpeed, 0, startSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
