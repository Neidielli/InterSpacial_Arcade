using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilShipMovement : MonoBehaviour
{
    private Rigidbody2D rbd;
    public int vel;

    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        vel = -5;
        this.rbd.velocity = new Vector2(0, vel);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -Camera.main.orthographicSize - 1)
            Destroy(this.gameObject);
        

    }
}
