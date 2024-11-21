using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //T?o 1 hi?u ?ng n?
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Ki?m tra va ch?m
    void OnCollisionEnter(Collision col){
        if (col.gameObject)
        {
            // T�nh to�n v? tr� n? (n�ng cao hon di?m va ch?m)
            Vector3 explosionPosition = col.contacts[0].point; // �i?m va ch?m
            explosionPosition.y += 1.0f; // Tang gi� tr? y d? n? cao hon
            // T?o hi?u ?ng n? t?i v? tr� va ch?m
            Instantiate(explosion, explosionPosition, transform.rotation);
            // Ph� h?y tr�i banh sau khi n?
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

