// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Advertisements;
// public class AddsController : MonoBehaviour
// {
//      string androidID ="5538225";
//          string iosID = "5538224";

//     // Start is called before the first frame update
//     void Start()
//     {
//         #if UNITY_ANDROID
//         Advertisement.Initialize(androidID);
//         #endif
//         #if UNITY_IOS
//         Advertisement.Initialize(iosID);
//         #endif
//     }

//     // Update is called once per frame
//      public void ShowInterstitial(){
        

// Advertisement.Show("Interstitial_Android");
//     }
//     public void ShowRewardedVideo(){
//         ShowOptions options = new ShowOptions{ resultCallback =HandleShowResult};
// Advertisement.Show("Rewarded_Android",options);

//     }
//     void HandleShowResult(ShowResult result){
// if(result ==ShowResult.Finished){
//     Debug.Log("Give the player hiw reward!");
// }
// else if(result ==ShowResult.Finished){
//     Debug.Log("Ad skipped!");
// }
// else if(result ==ShowResult.Finished){
//     Debug.Log("Ad failed!");
// }
//     }

// }
