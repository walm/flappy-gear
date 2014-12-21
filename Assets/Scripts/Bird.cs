using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

  public GameObject controller;

  Animator anim;

  bool isGameStart = false;
  bool isDead = false;
  bool isFlapping = false;

  // Use this for initialization
  void Start () {
    anim = GetComponent<Animator>();
    isFlapping = true;
    Invoke("Flap", 0.2f);
  }

  void Awake () {
    // rigidbody2D.isKinematic = true;
  }

  // Update is called once per frame
  void Update () {

    if (isGameStart && !isDead && Input.GetMouseButtonDown(0)) {
      if (!isFlapping) Flap();

    } else if (!isGameStart) {
      if (!isFlapping) {
        isFlapping = true;
        Invoke("Flap", 1.2f);
      }
    }

  }

  void OnCollisionEnter2D(Collision2D coll) {
    Die();
  }

  void Flap () {
    rigidbody2D.velocity = Vector2.zero;
    rigidbody2D.AddForce(new Vector2(0, 200));
    anim.SetTrigger("Flap");
    isFlapping = false;
  }

  void Die () {
    isDead = true;
    rigidbody2D.isKinematic = true;
    controller.BroadcastMessage("GameOver");
  }

  void GameStart () {
    rigidbody2D.isKinematic = false;
    isGameStart = true;
  }

}
