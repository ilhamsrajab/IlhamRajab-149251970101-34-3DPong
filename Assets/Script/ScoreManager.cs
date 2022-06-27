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
  public GameObject BlockWallPlayer1;
  public GameObject BlockWallPlayer2;
  public GameObject BlockWallPlayer3;
  public GameObject BlockWallPlayer4;
  public BallController ball;
  public GameplayManager manager;
  private bool player1Lose;
  private bool player2Lose;
  private bool player3Lose;
  private bool player4Lose;
  private int jumlahPlayer = 4;

  private void Update()
  {
    if (jumlahPlayer == 1)
    {
      ResultScreen();
    }
  }

  public void AddScorePlayer1(int increment)
  {
    ball.ResetBall();

    scorePlayer1 += increment;

    if (scorePlayer1 >= maxScore)
    {
      BlockWallPlayer1.SetActive(true);

      player1Lose = true;
      jumlahPlayer -= 1;
      Debug.Log("Player 1 Lose = " + player1Lose);
    }
  }
  public void AddScorePlayer2(int increment)
  {
    ball.ResetBall();

    scorePlayer2 += increment;

    if (scorePlayer2 >= maxScore)
    {
      BlockWallPlayer2.SetActive(true);

      player2Lose = true;
      jumlahPlayer -= 1;
      Debug.Log("Player 2 Lose = " + player2Lose);
    }
  }
  public void AddScorePlayer3(int increment)
  {
    ball.ResetBall();

    scorePlayer3 += increment;

    if (scorePlayer3 >= maxScore)
    {
      BlockWallPlayer3.SetActive(true);

      player3Lose = true;
      jumlahPlayer -= 1;
      Debug.Log("Player 3 Lose = " + player3Lose);
    }
  }
  public void AddScorePlayer4(int increment)
  {
    ball.ResetBall();

    scorePlayer4 += increment;

    if (scorePlayer4 >= maxScore)
    {
      BlockWallPlayer4.SetActive(true);

      player4Lose = true;
      jumlahPlayer -= 1;
      Debug.Log("Player 4 Lose = " + player4Lose);
    }
  }
  public void ResultScreen()
  {
    // SceneManager.LoadScene("MainMenu");
    if (manager.Panel != null)
    {
      manager.Panel.SetActive(true);
    }
  }
}
