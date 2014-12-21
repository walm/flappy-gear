using UnityEngine;
using System.Collections;

public class TubeGenerator : MonoBehaviour {

  public GameObject tube;

  bool isGameStart = false;
  bool isGameOver = false;

  // Use this for initialization
  void Start () {
    InvokeRepeating("CreateTubes", 1.0f, 1.5f);
  }

  void CreateTubes() {
    if (isGameStart && !isGameOver) {
      GameObject obj = (GameObject)Instantiate(tube);
      obj.transform.SetParent(transform);
    }
  }

  void GameStart () {
    isGameStart = true;
  }

  void GameOver () {
    isGameOver = true;
  }
}
