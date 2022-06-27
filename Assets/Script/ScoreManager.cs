using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
  public int scorePlayer1;
  public int scorePlayer2;
  public int scorePlayer3;
  public int scorePlayer4;
  public int maxScore;
  public BallController ball;
  public GameplayManager manager;
  public GameObject BlockWallPlayer1;
  public GameObject BlockWallPlayer2;
  public GameObject BlockWallPlayer3;
  public GameObject BlockWallPlayer4;

  public void AddScorePlayer1(int increment)
  {
    ball.ResetBall();

    scorePlayer1 += increment;

    if (scorePlayer1 >= maxScore)
    {
      BlockWallPlayer1.SetActive(true);

      bool player1Lose = true;

      //   if (player1Lose == false)
      //   {
      //     ResultScreen();
      //   }
    }
  }
  public void AddScorePlayer2(int increment)
  {
    ball.ResetBall();

    scorePlayer2 += increment;

    if (scorePlayer2 >= maxScore)
    {
      ResultScreen();
    }
  }
  public void AddScorePlayer3(int increment)
  {
    ball.ResetBall();

    scorePlayer3 += increment;

    if (scorePlayer3 >= maxScore)
    {
      ResultScreen();
    }
  }
  public void AddScorePlayer4(int increment)
  {
    ball.ResetBall();

    scorePlayer4 += increment;

    if (scorePlayer4 >= maxScore)
    {
      ResultScreen();
    }
  }

  public void ResultScreen()
  {
    // SceneManager.LoadScene("MainMenu");
    if (manager.Panel != null)
    {
      bool isActive = manager.Panel.activeSelf;
      manager.Panel.SetActive(!isActive);
    }
  }
}
