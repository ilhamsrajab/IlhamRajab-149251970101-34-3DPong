using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenuManager : MonoBehaviour
{
  // Start is called before the first frame update
  public void PlayGame()
  {
    SceneManager.LoadScene("Gameplay");
  }

  // Update is called once per frame
  public void HowToPlay()
  {
    Debug.Log("Halaman How To Play");
  }

  public void ExitGame()
  {
    // keluar jika berada pada build game
    Application.Quit();
    Debug.Log("Keluar dari game");

    // keluar playmode ketika berada pada unity editor
    EditorApplication.ExitPlaymode();
  }
}
