using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            Debug.Log("A WINNER IS YOU!");
            SceneManager.LoadScene("Level02");
        }
    }
}
