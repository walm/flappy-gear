using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

  public GameObject startText;
  public GameObject gameOverText;

  bool isGameStart = false;
  bool isGameOver = false;

  // Use this for initialization
  void Start () {
    startText.SetActive(true);
  }

  // Update is called once per frame
  void Update () {

    if (!isGameStart && Input.anyKey) {
      StartGame();
    }

  }

  public void Retry () {
    Application.LoadLevel(Application.loadedLevel);
  }

  public void StartGame () {
    isGameStart = true;
    startText.SetActive(false);
    BroadcastMessage("GameStart", SendMessageOptions.DontRequireReceiver);
  }

  void GameOver () {
    isGameOver = true;
    gameOverText.SetActive(true);
  }
}
