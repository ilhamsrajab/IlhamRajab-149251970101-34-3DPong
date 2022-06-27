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
  public PlayerController player1;
  public PlayerController player2;
  public PlayerController player3;
  public PlayerController player4;
  public BallController ball;
  public GameplayManager manager;
  public string PlayerWin;
  public int jumlahPlayer = 4;


  public void Update()
  {
    if (jumlahPlayer == 1)
    {
      if (BlockWallPlayer1.activeSelf != true)
      {
        PlayerWin = "Player 1";
      }
      if (BlockWallPlayer2.activeSelf != true)
      {
        PlayerWin = "Player 2";
      }
      if (BlockWallPlayer3.activeSelf != true)
      {
        PlayerWin = "Player 3";
      }
      if (BlockWallPlayer4.activeSelf != true)
      {
        PlayerWin = "Player 4";
      }

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

      jumlahPlayer -= 1;

      player1.PlayerLose();
    }
  }
  public void AddScorePlayer2(int increment)
  {
    ball.ResetBall();

    scorePlayer2 += increment;

    if (scorePlayer2 >= maxScore)
    {
      BlockWallPlayer2.SetActive(true);

      jumlahPlayer -= 1;
      player2.PlayerLose();
    }
  }
  public void AddScorePlayer3(int increment)
  {
    ball.ResetBall();

    scorePlayer3 += increment;

    if (scorePlayer3 >= maxScore)
    {
      BlockWallPlayer3.SetActive(true);

      jumlahPlayer -= 1;
      player3.PlayerLose();
    }
  }
  public void AddScorePlayer4(int increment)
  {
    ball.ResetBall();

    scorePlayer4 += increment;

    if (scorePlayer4 >= maxScore)
    {
      BlockWallPlayer4.SetActive(true);

      jumlahPlayer -= 1;
      player4.PlayerLose();
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
