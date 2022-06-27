using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject Ballprefab;
  GameObject ball;
  public int RandomTorque = 15;
  private float spawnInterval;
  public int maxBall = 1;
  public float DirectionXMin;
  public float DirectionXMax;
  public float DirectionZMin;
  public float DirectionZMax;
  public float timer;
  private List<GameObject> balls = new List<GameObject>();

  private void Start()
  {
    timer = 0;
    spawnInterval = Random.Range(0f, 15f);
  }

  private void Update()
  {
    timer += Time.deltaTime;

    if (timer > spawnInterval)
    {
      if (balls.Count < maxBall)
      {
        SpawnBall();
      }
      timer -= spawnInterval;
    }
  }

  private void SpawnBall()
  {
    ball = Instantiate(Ballprefab, transform.position, Quaternion.identity) as GameObject;
    ball.GetComponent<Rigidbody>().AddTorque(Random.Range(-RandomTorque, RandomTorque), Random.Range(-RandomTorque, RandomTorque), 0);
    ball.transform.parent = transform;

    balls.Add(ball);
  }
}
