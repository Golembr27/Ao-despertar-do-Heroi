using TMPro;
using UnityEngine;

public class GameMenager : MonoBehaviour
{
    public static GameMenager Instance;

    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        coinQuantidade = 0;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    [SerializeField] TextMeshProUGUI tmCoin;
    public int coinQuantidade = 0;

    public void MudarTexto()
    {
        tmCoin.text = ($"{coinQuantidade}");
    }
}
