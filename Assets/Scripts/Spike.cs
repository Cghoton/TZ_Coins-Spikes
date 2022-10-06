using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            UIScript.Instance.restartButton.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}
