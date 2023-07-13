using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            gameObject.SetActive(false);
    }
}
