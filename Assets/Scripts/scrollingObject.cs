using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingObject : MonoBehaviour
{
 
    public float xSpeed = 4f;

 
    void Start()
    {
      
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.left * xSpeed * Time.deltaTime);
    }
    
   
}