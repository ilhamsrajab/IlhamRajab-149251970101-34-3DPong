using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenuManager : MonoBehaviour
{
  public GameObject Panel;
  // Start is called before the first frame update
  public void PlayGame()
  {
    SceneManager.LoadScene("Gameplay");
  }

  // Update is called once per frame
  public void HowToPlay()
  {
    Debug.Log("Halaman How To Play");
    if (Panel != null)
    {
      bool isActive = Panel.activeSelf;
      Panel.SetActive(!isActive);
    }
  }

  public void Back()
  {
    SceneManager.LoadScene("MainMenu");
  }

  public void ExitGame()
  {
    // keluar jika berada pada build game
    Application.Quit();
    Debug.Log("Keluar dari game");

    // keluar playmode ketika berada pada unity editor
    // EditorApplication.ExitPlaymode();
  }
}
