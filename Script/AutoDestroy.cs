using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float lifetime=1f;
    // Start is called before the first frame update
    void Start()
    {
        // Ph� h?y d?i tu?ng n�y sau 'lifetime' gi�y
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

