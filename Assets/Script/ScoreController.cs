using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
  public Text ScorePlayer1;
  public Text ScorePlayer2;
  public Text ScorePlayer3;
  public Text ScorePlayer4;
  public ScoreManager manager;

  private void Update()
  {
    ScorePlayer1.text = manager.scorePlayer1.ToString();
    ScorePlayer2.text = manager.scorePlayer2.ToString();
    ScorePlayer3.text = manager.scorePlayer3.ToString();
    ScorePlayer4.text = manager.scorePlayer4.ToString();
  }

  public void MenuButton()
  {
    SceneManager.LoadScene("MainMenu");
  }
}
