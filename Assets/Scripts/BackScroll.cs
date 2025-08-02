using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScroll : MonoBehaviour
{
    [Range(-1,1)]
    public float Speed = .5f;
    private float offset;
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat=GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset+=(Time.deltaTime*Speed)/10f;
 mat.SetTextureOffset("_MainTex", new Vector2(offset, offset));    }
}
