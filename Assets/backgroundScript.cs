using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour
{
    Rigidbody2D rbd;
    public int vel;
    // Start is called before the first frame update
    void Start()
    {
        vel = -3;
        rbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.rbd.velocity = new Vector2(0, vel);

        if (transform.position.y < -Camera.main.orthographicSize - (gameObject.GetComponent<SpriteRenderer>().bounds.size.y) / 2)
        {
           transform.position = new Vector3(transform.position.x, Camera.main.orthographicSize + (gameObject.GetComponent<SpriteRenderer>().bounds.size.y) / 2, transform.position.z);
        }
            
    }
}
