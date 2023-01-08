using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyApple : MonoBehaviour
{

    AppleScore aS;
    // Start is called before the first frame update
    void Start()
    {
        aS = this.GetComponent<AppleScore>();
        aS.DispScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Apple")
        {
            
            Destroy(collision.gameObject);

            aS.DispScore(100);
        }

    }
}
