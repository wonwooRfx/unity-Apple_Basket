using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousemove : MonoBehaviour
{
    public float speed;
    float h;
   
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

   
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

        //this.transform.position = new Vector3(mousePos3D.x, this.transform.position.y, 0);



        //h = Input.GetAxis("Fire1");
        //h = h * speed * Time.deltaTime;
        //basket.transform.Translate
    }
}
