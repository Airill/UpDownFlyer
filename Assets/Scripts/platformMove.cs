using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour
{
    public float Xspeed = 4f;
    //public GameObject platform;
    float platformPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
   

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.left * Xspeed * Time.deltaTime); // Движение по оси X

       // platformPos = transform.position.x;
      //  Debug.Log(platformPos); // вывод Х в консоль
      //  if (platformPos < -11.55f)  // Проверка на выход за левый предел экрана
      //  {
      //      transform.position = new Vector3(12f, transform.position.y, transform.position.z); // перемещение за правый предел экрана
      //  }
    }
}
