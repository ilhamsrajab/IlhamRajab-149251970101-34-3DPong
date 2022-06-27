using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameplayManager : MonoBehaviour
{
  public GameObject Panel;
  public GameObject ColorPlayerWin;
  public Text PlayerWin;
  public ScoreManager manager;

  private void Update()
  {
    if (manager.jumlahPlayer == 1)
    {
      PlayerWin.text = manager.PlayerWin + " Wins";

      if (manager.PlayerWin == "Player 1")
      {
        PlayerWin.GetComponent<Text>().color = new Color32(0, 0, 0, 255);
        ColorPlayerWin.GetComponent<Image>().color = new Color32(255, 255, 0, 255);
      }
      if (manager.PlayerWin == "Player 2")
      {
        PlayerWin.GetComponent<Text>().color = new Color32(255, 255, 255, 255);
        ColorPlayerWin.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
      }
      if (manager.PlayerWin == "Player 3")
      {
        PlayerWin.GetComponent<Text>().color = new Color32(255, 255, 255, 255);
        ColorPlayerWin.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
      }
      if (manager.PlayerWin == "Player 4")
      {
        PlayerWin.GetComponent<Text>().color = new Color32(0, 0, 0, 255);
        ColorPlayerWin.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
      }
    }
  }
  public void MenuButton()
  {
    SceneManager.LoadScene("MainMenu");
  }
  public void ReplayButton()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
