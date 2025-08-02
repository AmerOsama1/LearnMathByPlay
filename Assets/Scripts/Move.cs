using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 20f;
    public Joystick joyStick;
    private Rigidbody2D rb;

    public float Force = 5f;
    int number_boast;
        // private float currentRotation = 0f;
        public float rotationSpeed = 200f;
[SerializeField] private  GameObject fire;
float inputX;
float inputY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        number_boast=PlayerPrefs.GetInt("boast",1);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
        
    }

    void MovePlayer()
    {   
         inputX = joyStick.Horizontal;
         inputY = joyStick.Vertical;
        Vector2 movement = new Vector2(inputX, inputY);
        rb.velocity = new Vector2(movement.x * speed, movement.y*speed);
Debug.Log(inputX + " " + inputY);
        if (inputX <0||inputY > 0)
        {
           fire.SetActive(true);
        }
        else {
                       fire.SetActive(false);

        }

       

        
    }
    void RotatePlayer()
    {   


float angle = Mathf.Atan2(inputX, inputY) * Mathf.Rad2Deg;
Quaternion targetRotation = Quaternion.Euler(0, 0, -angle);
float rotationSpeed = 5.0f; 
transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);


       
    }
     public void UseBoast()
    {
        int number_boast = PlayerPrefs.GetInt("boast", 0);
        if (number_boast > 0)
        {
            Debug.Log("aa");
            number_boast--;
            PlayerPrefs.SetInt("boast", number_boast);
            rb.AddForce(new Vector2(joyStick.Horizontal, joyStick.Vertical) * Force,ForceMode2D.Impulse);
        }
    }
}
