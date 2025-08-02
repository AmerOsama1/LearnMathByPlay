using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelController : MonoBehaviour
{
    public GameObject[] Levels;
    int i = 0 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
}

public void CurrentLevel(int level){
SceneManager.LoadScene(level);

}
    
    public void Next(){
    
        if(i<=Levels.Length){
            Levels[i].SetActive(false);

            i++;   
              if(i>Levels.Length-1){
        i=Levels.Length-1;
    }
Levels[i].SetActive(true);
}
    }
    public void Previous(){
      
        if(i<=Levels.Length&&i>=0){
                        Levels[i].SetActive(false);

            i--; 
               if(i<0){
    i=0;}
Levels[i].SetActive(true);
}

    }}

