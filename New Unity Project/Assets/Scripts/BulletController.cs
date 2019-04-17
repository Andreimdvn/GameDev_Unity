using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bullet;
    public GameObject explosion;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        bullet.position += Vector3.up * speed;
        if (bullet.position.y >= 10)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 10;
            print(PlayerScore.playerScore.ToString());
        }
        else if (other.tag == "Base")
        {
            Debug.Log("Hit base!");
            Destroy(gameObject);
            
        }
    }
}
