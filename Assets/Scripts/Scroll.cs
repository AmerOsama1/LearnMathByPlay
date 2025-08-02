using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    [SerializeField] private RawImage _img;
    [SerializeField] private float speedX, speedY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rect uvRect = _img.uvRect;
        uvRect.position += new Vector2(speedX, speedY) * Time.deltaTime;
        _img.uvRect = uvRect;
    }
}
