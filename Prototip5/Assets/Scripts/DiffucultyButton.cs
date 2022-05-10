using UnityEngine;
using UnityEngine.UI;

public class DiffucultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;

    public int diffuculty;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " clicked");
        gameManager.StartGame(diffuculty);
    }
}
