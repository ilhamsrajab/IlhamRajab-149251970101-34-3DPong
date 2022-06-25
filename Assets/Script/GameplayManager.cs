using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameplayManager : MonoBehaviour
{
  public GameObject Panel;
  public void MenuButton()
  {
    SceneManager.LoadScene("MainMenu");
  }
  public void ReplayButton()
  {
    SceneManager.LoadScene("Gameplay");
  }
}
