using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
  public float speed = 3f;
  public SpawnManager manager;
  private Vector3 direction;
  private Rigidbody rig;
  // Start is called before the first frame update
  void Start()
  {
    rig = GetComponent<Rigidbody>();

    this.direction = new Vector3(Random.Range(0.5f, 1f), 0f, Random.Range(0.5f, 1f));
    // this.direction = new Vector3(Random.Range(manager.DirectionXMin, manager.DirectionXMax), 0f, Random.Range(manager.DirectionZMin, manager.DirectionZMax));
    rig.velocity = direction * speed;
  }

  void Update()
  {
    this.transform.position += direction * speed;
  }

  // agar bola mantul
  private void OnCollisionEnter(Collision col)
  {
    Vector3 normal = col.contacts[0].normal;
    direction = Vector3.Reflect(direction, normal);
  }

  public void ResetBall()
  {
    Debug.Log("Reset Ball");

    // Destroy(gameObject);
  }

}
