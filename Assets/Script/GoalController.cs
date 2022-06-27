using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
  public SphereCollider ball;
  public bool isPlayer1;
  public bool isPlayer2;
  public bool isPlayer3;
  public bool isPlayer4;
  public ScoreManager manager;

  private void OnTriggerEnter(Collider col)
  {

    if (col == ball)
    {
      if (isPlayer1)
      {
        manager.AddScorePlayer1(1);
      }
      if (isPlayer2)
      {
        manager.AddScorePlayer2(1);
      }
      if (isPlayer3)
      {
        manager.AddScorePlayer3(1);
      }
      if (isPlayer4)
      {
        manager.AddScorePlayer4(1);
      }
    }
  }
}
