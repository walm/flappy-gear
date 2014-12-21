using UnityEngine;
using System.Collections;

public class Tube : MonoBehaviour {

  public Vector2 velocity = new Vector2(-1.5f, 0f);

  // Use this for initialization
  void Start () {
    rigidbody2D.velocity = velocity;
    transform.position = new Vector3(
      transform.position.x,
      Random.Range(-0.70f, 0.70f),
      transform.position.z
    );
  }

  void Remove () {
    Destroy(gameObject);
  }

  void GameOver () {
    rigidbody2D.velocity = Vector2.zero;
  }
}
