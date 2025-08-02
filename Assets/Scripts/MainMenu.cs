using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject levels,Option,MainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){    
            levels.SetActive(true);
        MainCanvas.SetActive(false);
        Option.SetActive(false);
    }
    public void BackFromSelectLevel(){
                   levels.SetActive(false);
        MainCanvas.SetActive(true);
        Option.SetActive(false);
    }
    public void Options(){
      levels.SetActive(false);
        MainCanvas.SetActive(false);
        Option.SetActive(true);
    }
    public void BackFromOptions(){
              levels.SetActive(false);
        MainCanvas.SetActive(true);
        Option.SetActive(false);
    }
    public void Exit(){
        Application.Quit();
    }
    
}
