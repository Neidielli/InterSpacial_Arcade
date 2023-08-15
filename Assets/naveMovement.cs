using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naveMovement : MonoBehaviour
{
    private Rigidbody2D rbd;
    public int vel;
    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        vel = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        this.rbd.velocity = new Vector2(x, y) * vel;
    }
}
