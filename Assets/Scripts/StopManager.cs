using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopManager : MonoBehaviour
{
    public GameObject options;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale = 1;

    }

    public void Complete()
    {
        Time.timeScale = 1;
this.gameObject.SetActive(false);
    }

    public void Setting()
    {
        options.SetActive(true);
    }
}
