using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Win_LoseSystem : MonoBehaviour
{
    public NumberController number;
    public int AmountToWin=1;
    public int AmountToLose=5;
    public GameObject Lose,Win;
    // Start is called before the first frame update
    void Start()
    {
                        Time.timeScale=1;

    }

    // Update is called once per frame
    void Update()
    {
        if(AmountToLose<=number.Number_false){
            Debug.Log("lose");
            Lose.SetActive(true);
            Time.timeScale=0;
        }
        else if(AmountToWin<=number.Number_true){
                        Invoke("ww",.5f);
        }
        
    }
    public void WinN(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name+1);
                Time.timeScale=1;

    }
    public void los(){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale=1;

    }
    public void Exit(){
        Application.Quit();
    }
    void ww(){
        Debug.Log("win");

            Win.SetActive(true);
            Time.timeScale=0;
    }
}
