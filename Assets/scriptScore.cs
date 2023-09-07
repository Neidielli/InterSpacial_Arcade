using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class scriptScore : MonoBehaviour
{
    private static float score = 0;
    private static float life = 20;
    private static GameObject txtScore;
    private static GameObject txtLife;
    // Start is called before the first frame update
    void Start()
    {
        txtScore = GameObject.Find("txtScore");
        txtLife = GameObject.Find("txtLife");
    }

    public static void addScore(int s)
    {
        // Quando for atualizado, incrementa o placar
        score += s;
        txtScore.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
    } 

    public static void decreaseLife(int l)
    {
        life -= l;
        txtLife.GetComponent<TextMeshProUGUI>().text = "Life: " + life;
        
        // Lógica para npc morrer
        if (life <= 0)
        {
            Debug.Log("Game Over");
            // Mostrar tela de game over
            SceneManager.LoadScene("GameOver");
        }
    }

}
