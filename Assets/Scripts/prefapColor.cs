using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Rendering.Universal;
public class prefapColor : MonoBehaviour
{
 Light2D light2D;
     ChangeC changeScript;      
          public int Time=5;

    // Start is called before the first frame update
    void Start()
    {
        light2D=GetComponent<Light2D>();
        changeScript=GetComponent<ChangeC>();      
                  change();

                InvokeRepeating("change",Time,Time);


    }


    // Update is called once per frame
    void Update()
    {
        
    }
     public void change(){

light2D.color=new Color(changeScript.randomRed,changeScript.randomGreen,changeScript.randomBlue);
     }

}
