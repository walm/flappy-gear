using UnityEngine;
using System.Collections;

public class OutsideTrigger : MonoBehaviour {

  void OnTriggerEnter2D(Collider2D other) {
    other.gameObject.SendMessage("Die", SendMessageOptions.DontRequireReceiver);
  }

}
