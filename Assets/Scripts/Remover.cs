using UnityEngine;
using System.Collections;

public class Remover : MonoBehaviour {

  void OnTriggerEnter2D(Collider2D other) {
    other.gameObject.SendMessageUpwards("Remove", SendMessageOptions.DontRequireReceiver);
  }
}
