using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject WinTextObject;
    void Start()
    {
        WinTextObject.SetActive(false);
    }

   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            WinTextObject.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
