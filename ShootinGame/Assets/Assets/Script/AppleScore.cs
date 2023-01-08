using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AppleScore : MonoBehaviour
{
    GameObject obj;
    private Text txtScore;
    private int totScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Text");
        txtScore = obj.GetComponent<Text>();

      
    }

    public void DispScore(int score)
    {
        totScore += score;

        txtScore.text = "Score: " + totScore.ToString();
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    
}
