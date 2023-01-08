using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public float speed;
    float h;
    

    Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");


        vec = new Vector3(h, 0, 0).normalized;
        transform.position += vec * speed * Time.deltaTime;
    }
}
