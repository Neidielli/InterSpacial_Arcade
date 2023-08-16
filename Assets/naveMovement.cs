using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovement : MonoBehaviour
{
    private Rigidbody2D rbd;
    public int vel;
    private float heigth;
    private float width;
    private float altPc;

    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        vel = 10;
        heigth = Camera.main.orthographicSize; // Pega a altura da camera e atribui a uma variavel
        width = heigth * Camera.main.aspect; // Pega a largura da camera e atribui a uma variavel

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        altPc = sr.bounds.size.y / 2; // Pega metade do tamanho da nave
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        this.rbd.velocity = new Vector2(x, y) * vel;

        if(this.transform.position.x > width) { // Lógica de ir para o lado
            this.transform.position = new Vector2(-width, this.transform.position.y);
        } else if (this.transform.position.x < -width)
        {
            this.transform.position = new Vector2(width, this.transform.position.y);
        }

        if (this.transform.position.y < -heigth + altPc) // Lógica de ir para baixo
        {
            this.transform.position = new Vector2(this.transform.position.x, -heigth + altPc);
        }
        else if (this.transform.position.y > 0f)
        {
            this.transform.position = new Vector2(this.transform.position.x, 0f);
        }
    }
}
