using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{   
    public int score;
    public int vida;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI textVida;
    void Start()
    {
        textVida.text = this.vida.ToString();
    }

    void Update()
    {
        
    }

    public void NoComestibleCollision() 
    {
        this.vida--;
        textVida.text = this.vida.ToString();

        if (vida == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void ComestibleCollision()
    {
        this.score += 10;
        scoreText.text = this.score.ToString();
    }
}
