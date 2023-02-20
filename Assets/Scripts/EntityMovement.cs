using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

}
