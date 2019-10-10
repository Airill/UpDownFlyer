using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject[] platform;
    public GameObject beacon;
  
    public float sMax;
    float colScale;
    int randomPlatform;

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        colScale = other.gameObject.transform.localScale.x;
        spawn();
    }

    void spawn()
    {
        float sCurrent = Random.Range(1, sMax - 1f);
        randomPlatform = Random.Range(0, platform.GetLength(0));
        Instantiate(platform[randomPlatform], new Vector3((this.gameObject.transform.position.x + this.gameObject.transform.localScale.x / 2 + colScale + sCurrent + platform[randomPlatform].transform.localScale.x / 2), beacon.transform.position.y, beacon.transform.position.z), Quaternion.identity);
    }
}
