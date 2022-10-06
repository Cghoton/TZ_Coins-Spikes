using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    private TMP_Text coinsCounter;
    [SerializeField]
    private TMP_Text winningText;

    [SerializeField]
    public Button restartButton;

    public float amountOfObjects = 10;

    private int Coins;

    public static UIScript Instance;

    private void Start()
    {
        Instance = this;
    }
    public void AddCoin()
    {
        Coins++;
        coinsCounter.text = Coins.ToString();
        if (Coins >= amountOfObjects)
        {
            Time.timeScale = 0;
            winningText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
