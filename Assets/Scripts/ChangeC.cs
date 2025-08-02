using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeC : MonoBehaviour
{
    public int Time=5;
    public  float randomRed ;
    public float randomGreen;

    public float randomBlue;
SpriteRenderer renderer;    // Start is called before the first frame update
    void Start()
    {
        renderer=GetComponent<SpriteRenderer>();      
           change();


        InvokeRepeating("change",Time,Time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public void change(){

  randomRed = Random.Range(0f, 1f);
             randomGreen = Random.Range(0f, 1f);
             randomBlue = Random.Range(0f, 1f);
           renderer.color = new Color(randomRed, randomGreen, randomBlue);
    }
}
