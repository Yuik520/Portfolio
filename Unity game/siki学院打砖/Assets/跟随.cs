using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 跟随 : MonoBehaviour
{ public Transform playTransform;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {//使相机移动的位置的距离=自身的位置-移动的位置
         offset = transform.position - playTransform.position; 
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playTransform.position  + offset;
    }
}
