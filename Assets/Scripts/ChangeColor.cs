using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeColor : MonoBehaviour
{
    public int Time=5;
    Image img;
    // Start is called before the first frame update
    void Start()
    {
        img=GetComponent<Image>();
        InvokeRepeating("change",Time,Time); 
               change();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void change(){

 float randomRed = Random.Range(0f, 1f);
            float randomGreen = Random.Range(0f, 1f);
            float randomBlue = Random.Range(0f, 1f);
           img.color = new Color(randomRed, randomGreen, randomBlue);
    }
}
