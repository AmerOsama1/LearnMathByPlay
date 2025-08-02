using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class NumberController : MonoBehaviour
{
    public int Number_true;
        public int Number_false;


    public Sprite[] Numbers;
    public Sprite[] operation;
    public bool isPlus;
    public int MaxNumber;
    public Sprite QuestionMark;
    public int NumberX, NumberY, NumberZ;
    public Image X, Y, Z,op;
    public bool check = false;
    public GameObject trueImage, falseImage;
    GameObject Pre;
AudioSource source;
    public  AudioClip yesSound;
   public     AudioClip wrongSound;
   int randomOperation ;
    void Start()
    {
        GenerateRandomNumbers();
        source =GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        yes();
        Wrong();
    }

void GenerateRandomNumbers()
{         
    randomOperation = Random.Range(0, operation.Length);
    Operation();

    if (isPlus)
    {
        NumberX = Random.Range(0, MaxNumber);
        NumberY = Random.Range(0, MaxNumber);

        X.sprite = Numbers[NumberX];
        Y.sprite = Numbers[NumberY];

        // Update NumberZ and NumberP here
        NumberZ = 0;
    }
    else
    {
        do
        {
            NumberX = Random.Range(0, MaxNumber);
            NumberY = Random.Range(0, MaxNumber);
        } while (NumberX < NumberY);

        X.sprite = Numbers[NumberX];
        Y.sprite = Numbers[NumberY];

        // Update NumberZ and NumberP here
        NumberZ = 0;
    }
}


 

void Operation(){
if(randomOperation==0){
    op.sprite=operation[0];
isPlus=false;
}
else if(randomOperation==1){
        op.sprite=operation[1];
isPlus=true;
}

}
    void ResetSprites()
    {
        Z.sprite = QuestionMark;
    }

    void yes()
    {
      

        if ( NumberX + NumberY == NumberZ&&isPlus)
        {
            GenerateRandomNumbers();
            ResetSprites();
            Pre = Instantiate(trueImage, this.transform);
            Destroy(Pre.gameObject, .5f);
                        NumberZ = 0;
                        source.clip=yesSound;
                        source.PlayOneShot(yesSound);
                        check=false;
                        Number_true++;

        }
        else if( NumberX - NumberY == NumberZ&&!isPlus){
                   GenerateRandomNumbers();
            ResetSprites();
            Pre = Instantiate(trueImage, this.transform);
            Destroy(Pre.gameObject, .5f);
                        NumberZ = 0;
                        source.clip=yesSound;
                        source.PlayOneShot(yesSound);
                        check=false;
                        Number_true++;
        }

    }

  void Wrong()
{
    if (isPlus&& NumberX + NumberY != NumberZ  && check)
    {
        Debug.Log("You're wrong");
        CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
        ResetSprites();
        Pre = Instantiate(falseImage, this.transform);
        Destroy(Pre.gameObject, .5f);
        check = false;
           source.clip=wrongSound;
                        source.PlayOneShot(wrongSound);
                        Number_false++;
    }


    else if(!isPlus&& NumberX - NumberY != NumberZ  && check){
   Debug.Log("You're wrong");
        CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
        ResetSprites();
        Pre = Instantiate(falseImage, this.transform);
        Destroy(Pre.gameObject, .5f);
        check = false;
           source.clip=wrongSound;
                        source.PlayOneShot(wrongSound);
                        Number_false++;

    }
}
}
