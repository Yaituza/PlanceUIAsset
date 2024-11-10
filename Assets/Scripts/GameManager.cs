using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject cloud;
    public GameObject Coin;
    private int score;
    private int lives;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
        CreateSky();
        InvokeRepeating("CreateCoin", 0.5f, 2f);
        lives = 3;
        score = 0;
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 7.5f, 0), Quaternion.identity);
    }

    void CreateSky()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(cloud, transform.position, Quaternion.identity);
        }
    }

    public void EarnScore(int howMuch)
    {
        score = score + howMuch;
        scoreText.text = "Score: " + score;
    }

    void CreateCoin()
    {
        Instantiate(Coin, new Vector3(Random.Range(-9f, 9f), 7.5f, 0), Quaternion.identity);
    }
    public void LoseLife(int howMuch)
    {
        lives = lives - howMuch;
        livesText.text = "Lives: " + lives;
    }
  }
