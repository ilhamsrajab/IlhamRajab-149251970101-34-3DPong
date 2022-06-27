using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float speed = 5f;
  public KeyCode leftKey;
  public KeyCode rightKey;
  public KeyCode upKey;
  public KeyCode downKey;
  private Rigidbody rig;

  // Start is called before the first frame update
  void Start()
  {
    rig = GetComponent<Rigidbody>();
  }

  // Update is cal  void Update()
  private void FixedUpdate()
  {
    Vector3 movement = GetInput();
    MoveObject(GetInput());
  }

  private Vector3 GetInput()
  {
    if (Input.GetKey(leftKey))
    {
      return Vector3.left * speed;
    }
    else if (Input.GetKey(rightKey))
    {
      return Vector3.right * speed;
    }
    else if (Input.GetKey(upKey))
    {
      return Vector3.forward * speed;
    }
    else if (Input.GetKey(downKey))
    {
      return Vector3.back * speed;
    }
    return Vector3.zero;
  }

  private void MoveObject(Vector3 movement)
  {
    // rig.MovePosition(transform.position + movement * Time.deltaTime * speed);

    rig.velocity = movement;

    // transform.Translate(movement * Time.deltaTime * speed);
  }

}
