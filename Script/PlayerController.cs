using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //T?o bi?n t?c d? xoay 
    public float rotationSpeed=10f;
    //T?o bi?n t?c d? d?ch chuy?n
    public float movespeed=2f;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //Ki?m tra xem c� nh?n ph�m di chuy?n hay kh�ng
        float moveHorizontal=Input.GetAxis("Horizontal"); //Di chuy?n ngang
        float moveVertical=Input.GetAxis("Vertical"); //Di chuy?n d?c
        //T?o 1 vector3 theo 2 tr?c X,Z
        Vector3 move=new Vector3(moveHorizontal,0.0f,moveVertical);

        //Cho d?i tu?ng du?c g�n Scripts n�y di chuy?n t?i v� t� vector3 v?i t?c d? movespeed
        transform.Translate(move*movespeed*Time.deltaTime);

        // Quay qua tr�i khi nh?n ph�m Q
        if (Input.GetKey(KeyCode.Q))
        {
            // Quay tr�i
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        //Quay qua ph?i khi nh?n ph�m E
        else if (Input.GetKey(KeyCode.E))
        {
            // Quay ph?i
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

    }

}


