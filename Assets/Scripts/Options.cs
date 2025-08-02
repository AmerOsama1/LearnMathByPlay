using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour
{
    	public AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Voulum( float vol){
mixer.SetFloat("vol",vol);
    }
//      public void SetFullScreen(bool IsFullScreen){
// Screen.fullScreen=IsFullScreen;

//     }

 public void Quality(int index){

        QualitySettings.SetQualityLevel(index);
    }
    public void OpYoutube(){
Application.OpenURL("https://www.youtube.com/@Nero_Dev");
    }
}
