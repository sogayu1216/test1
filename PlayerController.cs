using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 5.0f;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called once per fixed time.
    void FixedUpdate()
    {
        rigid.velocity = transform.right * Input.GetAxisRaw("Horizontal") * speed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Egg")
        {
            Score.score++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Bomb")
        {
            if (Score.score > 0)
            {
                Score.score--;
            }
            Destroy(collision.gameObject);
        }
    }
}
