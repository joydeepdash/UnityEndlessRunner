using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;
    [SerializeField] Text scoreText;

    [SerializeField] PlayerMov playerMovement;
    public void BronzeIncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        playerMovement.speed = playerMovement.speed + playerMovement.speedIncrease; 
    }

    public void GoldIncrementScore()
    {
        for (int i = 0; i < 3; i++)
        {
            score++;
            playerMovement.speed = playerMovement.speed + playerMovement.speedIncrease;
        }
        scoreText.text = "Score: " + score;
    }

    private void Awake()
    {
        inst = this;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
