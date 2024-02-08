using UnityEngine;

public class Fruit : MonoBehaviour
{
    static Rigidbody2D rb;
    public GameObject explosionParticles;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        rb.angularVelocity = 200;
    }

    void Update()
    {
        if (transform.position.y < -7)
        {
            print(":(");
            Destroy(gameObject);
        }
    }

    public void Miss()
    {
        print(":(");
        Destroy(gameObject);
    }

    public void Slice()
    {
        var particles = Instantiate(explosionParticles);
        particles.transform.position = transform.position;
        Destroy(gameObject);
    }
}