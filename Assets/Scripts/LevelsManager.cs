using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelsManager : MonoBehaviour
{
    public int CurrentLevel;
    public int SaveLevel;
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        SaveLevel=PlayerPrefs.GetInt("level",0);
        button=GetComponent<Button>();
    }   

    // Update is called once per frame
    void Update()
    {
                PlayerPrefs.SetInt("level",CurrentLevel);
                if(CurrentLevel<SaveLevel){
                    button.enabled=true;
                }
                else {
                    button.enabled=false;
                }

    }
}
