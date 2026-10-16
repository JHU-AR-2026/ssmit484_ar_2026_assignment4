using UnityEngine;

public class CollectPowerUp : MonoBehaviour
{
    public GameObject PowerUpTextObject;
    public bool powerupactivated=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PowerUpTextObject.SetActive(false);
    }

   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            PowerUpTextObject.SetActive(true);
            other.GetComponent<Renderer>().material.color = Color.yellow;
            other.GetComponent<PlayerControl>().speedMultiplier = 2f;
            other.GetComponent<PlayerControl>().powerupactivated = true;
        }
    }
}
