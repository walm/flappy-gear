using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

  public Text scoreLabel;

  int score = 0;

  void OnTriggerEnter2D(Collider2D other) {
    if (other.gameObject.name == "tube1") AddScore();
  }

  void AddScore () {
    score += 1;
    scoreLabel.text = "Score: "+ score;
  }
}
