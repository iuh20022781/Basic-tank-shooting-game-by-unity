using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public float explosionForce = 500f; // Lực nổ
    public float explosionRadius = 5f; // Bán kính nổ

    void OnCollisionEnter(Collision collision)
    {
        // Kiểm tra xem có va chạm với đạn không
        if (collision.gameObject.CompareTag("VienDan"))
        {
            // Gọi phương thức nổ
            Explode();
            // Hủy đối tượng robot
            Destroy(gameObject,2f);
        }
    }
    void Explode()
    {
        // Lấy tất cả các bộ phận con của robot và nổ tung chúng
        foreach (Transform part in transform)
        {
            // Thêm Rigidbody cho từng bộ phận nếu chưa có
            Rigidbody rb = part.gameObject.AddComponent<Rigidbody>();
            rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
