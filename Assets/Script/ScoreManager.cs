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

  public void AddScorePlayer1(int increment)
  {
    ball.ResetBall();

    scorePlayer1 += increment;

    if (scorePlayer1 >= maxScore)
    {
      GameOver();
    }
  }
  public void AddScorePlayer2(int increment)
  {
    ball.ResetBall();

    scorePlayer2 += increment;

    if (scorePlayer2 >= maxScore)
    {
      GameOver();
    }
  }
  public void AddScorePlayer3(int increment)
  {
    ball.ResetBall();

    scorePlayer3 += increment;

    if (scorePlayer3 >= maxScore)
    {
      GameOver();
    }
  }
  public void AddScorePlayer4(int increment)
  {
    ball.ResetBall();

    scorePlayer4 += increment;

    if (scorePlayer4 >= maxScore)
    {
      GameOver();
    }
  }

  public void GameOver()
  {
    SceneManager.LoadScene("MainMenu");
  }
}
