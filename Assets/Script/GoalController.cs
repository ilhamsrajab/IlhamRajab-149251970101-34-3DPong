using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
  public SphereCollider ball;
  public ScoreManager manager;

  private void OnTriggerEnter(Collider col)
  {
    if (col == ball)
    {
      manager.AddScorePlayer2(1);
    }
  }
}
