using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    private float width;
    private float height;
    // Start is called before the first frame update
    void Start()
    {
        width = Camera.main.orthographicSize * Camera.main.aspect;
        height = Camera.main.orthographicSize + 1;

        InvokeRepeating("respawn",0.1f,1f);
    }
    
    void respawn()
    {
        float x = Random.Range(-height, height);
        Vector2 pos = new Vector2(x, height);
        Instantiate(enemy, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
