using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyBoast : MonoBehaviour
{
    public TextMeshProUGUI number_boast_Text; 
    public int number_boast; 
    public MoneyManager money;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
        number_boast_Text.text = number_boast.ToString();
    }


    public void buy()
    {
     
        if (money.Money >= 200)
        {
          
            money.Money -= 200;
            number_boast++;
            PlayerPrefs.SetInt("boast",number_boast);
        }
    }
}
