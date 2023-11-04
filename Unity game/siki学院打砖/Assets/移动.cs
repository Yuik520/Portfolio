using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 移动 : MonoBehaviour
{
    public Rigidbody qiu;

    // Start is called before the first frame update
    void Start()
    {
        qiu = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //qiu.AddForce(Vector3.right);
        //(x,y,z)(0,0,0) ;
        //forward(前进);back(后退); right(右);left(左);up(向上)
        //qiu.AddForce(new Vector3(10, 0, 0));

        
            
        float X = Input.GetAxis("Horizontal");
        //float(赋值一个小数) Input(输入)；GetAxis(轴"水平轴")；Horizontal(左右水平)
        float Z = Input.GetAxis("Vertical");
        Debug.Log(X);
        qiu.AddForce(new Vector3(X, 0, Z) * 2);
    }
}
