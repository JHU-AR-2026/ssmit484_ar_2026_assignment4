using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
// https://learn.unity.com/course/roll-a-ball/tutorial/displaying-score-and-text?version=6.3
public class PowerUpActivation: MonoBehaviour
{
    public GameObject PowerUpCapsule;
    //public GameObject winTextObject;
    private int count = 0;

void Start()
{
    PowerUpCapsule.SetActive(false);
    //winTextObject.SetActive(false);

}

void OnTriggerEnter(Collider other) 
    {
 // Check if the object the player collided with has the "PickUp" tag.
 if (other.gameObject.CompareTag("PickUp")) 
        {
 // Increment the count of "PickUp" objects collected.
            count = count + 1;
            Debug.Log("Count: " + count);
            Activate();
        }
    }

    void Activate() 
    {

 // Check if the count has reached or exceeded the win condition.
 if (count >= 6)
        {
 // Display the capsule
            PowerUpCapsule.SetActive(true);
        }
    }

}

