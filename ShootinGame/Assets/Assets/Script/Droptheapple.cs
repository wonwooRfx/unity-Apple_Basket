using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droptheapple : MonoBehaviour
{
    public float SecondsBetweenAppleDrops;
    public GameObject applePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DropApple", 2f, SecondsBetweenAppleDrops);
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab); 
        apple.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
