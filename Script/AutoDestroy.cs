using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float lifetime=1f;
    // Start is called before the first frame update
    void Start()
    {
        // Phá h?y d?i tu?ng này sau 'lifetime' giây
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

