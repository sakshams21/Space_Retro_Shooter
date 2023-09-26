
using UnityEngine;
using System.Collections;

public class BasicMovement : MonoBehaviour {

  private Rigidbody2D objectRigidbody;
  public float speed;

  // Use this for initialization
  void OnEnable () {
	objectRigidbody = transform.GetComponent<Rigidbody2D>();
	objectRigidbody.velocity = transform.up * speed;
  }
}
