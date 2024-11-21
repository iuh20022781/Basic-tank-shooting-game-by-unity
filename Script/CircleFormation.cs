using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFormation : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfObject=20;
    public float radius=5f;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<numberOfObject;i++){
            //Tính góc c?a d?i tu?ng hi?n t?i trong vòng tròn
            float angle=i*Mathf.PI * 2 / numberOfObject;
            //Tính t?a d? x, z c?a d?i tu?ng hi?n t?i
            float x=radius*Mathf.Cos(angle);
            float z=radius*Mathf.Sin(angle);
            //T?o v? trí cho d?i tu?ng
            Vector3 pos=transform.position+new Vector3(x,0,z);
            //Chuy?n radian sang d? d? th?c hi?n rotation
            float angleDegress=-angle*Mathf.Rad2Deg;
            Quaternion rot=Quaternion.Euler(0,angleDegress,0);
            //T?o 1 b?n sao prfab v?i v? trí và góc quay dã du?c tính
            Instantiate(prefab,pos,rot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
