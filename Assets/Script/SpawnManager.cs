using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public Transform spawnArea;
  public int spawnInterval;
  public int maxBall;
  public Vector3 areaMin;
  public Vector3 areaMax;
  private float timer;

  // Start is called before the first frame update
  private void Start()
  {
    timer = 0;
  }

  // Update is called once per frame
  private void Update()
  {
    timer += Time.deltaTime;

    if (timer > spawnInterval)
    {
      timer -= spawnInterval;
    }
  }

  public void GenerateSpawnBall()
  {
    GenerateSpawnBall(new Vector3(Random.Range(areaMin.x, areaMax.x), Random.Range(areaMin.y, areaMax.y)));
  }

  public void GenerateSpawnBall(Vector3 position)
  {
    if (true)
    {

    }
  }
}
