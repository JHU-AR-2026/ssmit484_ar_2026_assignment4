using UnityEngine;

public class BreakWall : MonoBehaviour
{
    void OnCollisionEnter( Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<PlayerControl>().powerupactivated)
            {
                Destroy(gameObject);
            }
        }
    }
}
