using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    //public GameObject basketPrefab2;
    //public GameObject basketPrefab3;
    public int numBasket = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    public List<GameObject> basketList;
    // Start is called before the first frame update
    void Start()
    {
        /*GameObject basket = Instantiate(basketPrefab);
        basket.transform.position = new Vector3(0, basketBottomY, 0);

        GameObject basket2 = Instantiate(basketPrefab2);
        basket2.transform.position = new Vector3(0, basketBottomY+basketSpacingY, 0);

        GameObject basket3 = Instantiate(basketPrefab3);
        basket3.transform.position = new Vector3(0, basketBottomY + 2*basketSpacingY , 0);*/
        basketList = new List<GameObject>();

        for (int i = 0; i < numBasket; i++) 
        {
            GameObject tBasketG0 = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketG0.transform.position = pos;
            basketList.Add(tBasketG0);
            //basket.transform.position = new Vector3(0, basketBottomY, 0);
            // basketBottomY += basketSpacingY;
        }
        
    }
    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }

        int basketIndex = basketList.Count - 1;
        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);

        if(basketList.Count ==0)
        {
            SceneManager.LoadScene("AppleGame");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
