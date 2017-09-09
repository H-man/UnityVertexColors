using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{

  Camera _cam;

  public LayerMask HitLayer;
  void Start()
  {
    _cam = Camera.main;
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      RaycastHit hit;
      Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
      if (Physics.Raycast(ray, out hit, 100.0f, HitLayer))
      {
        var rotator = hit.transform.GetComponent<SimpleRotator>();
        if (rotator.Speed != Vector3.zero)
        {
          rotator.Speed = Vector3.zero;
        }
        else
        {
          rotator.Speed = Random.insideUnitSphere;
        }

        Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
      }
    }

  }
}
