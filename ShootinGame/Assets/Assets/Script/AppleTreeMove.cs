using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTreeMove : MonoBehaviour
{
    public float speed;
    float width;
    float height;
    public float chanceToChangeDirection;

    public int maxCount = 20; //public maxCount = 2f;
    int count = 0;
   
  
   // Rigidbody  rbody;
    

    // Start is called before the first frame update
    void Start()
    {
        //rbody = GetComponent<Rigidbody>();
        var height = 2 * Camera.main.orthographicSize;
        width = height * Camera.main.aspect;

        //InvokeRepeating("MoveObj", speed, speed);
       
    }

    void Moveobj()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = transform.position;
        //pos.x += speed * Time.deltaTime;
        //transform.position = pos;

        //transform.position += Vector3.right * speed * Time.deltaTime;

        //transform.Translate(Vector3.right * speed * Time.deltaTime);

        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (transform.position.x >= width/2 )
        {
            speed = -speed;
        }
        if (transform.position.x <= -width/2)
        {
            speed = -speed;
        }

       
        
      
    }
    void FixedUpdate()
    {
        count++; //count += Time.delta.Time;
        if (count >= maxCount)
        {


            if (Random.value < chanceToChangeDirection)
            {
                speed *= -1; // speed *= -1;
            }
            count = 0;
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}

