using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotator : MonoBehaviour
{

  public Vector3 Speed = new Vector3(0, 1, 0);


  void Update()
  {
    transform.RotateAround(transform.position, Speed, 10 * Time.deltaTime);
  }
}
