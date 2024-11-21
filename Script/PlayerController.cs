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
        //Ki?m tra xem có nh?n phím di chuy?n hay không
        float moveHorizontal=Input.GetAxis("Horizontal"); //Di chuy?n ngang
        float moveVertical=Input.GetAxis("Vertical"); //Di chuy?n d?c
        //T?o 1 vector3 theo 2 tr?c X,Z
        Vector3 move=new Vector3(moveHorizontal,0.0f,moveVertical);

        //Cho d?i tu?ng du?c gán Scripts này di chuy?n t?i ví tí vector3 v?i t?c d? movespeed
        transform.Translate(move*movespeed*Time.deltaTime);

        // Quay qua trái khi nh?n phím Q
        if (Input.GetKey(KeyCode.Q))
        {
            // Quay trái
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        //Quay qua ph?i khi nh?n phím E
        else if (Input.GetKey(KeyCode.E))
        {
            // Quay ph?i
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

    }

}


