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
            // Tính toán v? trí n? (nâng cao hon di?m va ch?m)
            Vector3 explosionPosition = col.contacts[0].point; // Ði?m va ch?m
            explosionPosition.y += 1.0f; // Tang giá tr? y d? n? cao hon
            // T?o hi?u ?ng n? t?i v? trí va ch?m
            Instantiate(explosion, explosionPosition, transform.rotation);
            // Phá h?y trái banh sau khi n?
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

