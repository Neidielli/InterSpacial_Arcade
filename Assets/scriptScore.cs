using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class scriptScore : MonoBehaviour
{
    private static float score = 0;
    private static GameObject txtScore;
    // Start is called before the first frame update
    void Start()
    {
        txtScore = GameObject.Find("txtScore");
    }

    public static void addScore(int s)
    {
        // Quando for atualizado, incrementa o placar
        score += s;
        Debug.Log(txtScore);
        txtScore.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
    } 

}
