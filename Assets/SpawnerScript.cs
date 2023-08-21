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
        height = height * Camera.main.aspect;

        InvokeRepeating("respawn", 0,1);
    }
    
    void respawn()
    {
        float x = Random.Range(-height, height);
        Debug.Log(x);
        Vector2 pos = new Vector2(x, height + 2);
        Instantiate(enemy, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
