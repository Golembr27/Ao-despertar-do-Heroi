using TMPro;
using UnityEngine;

public class ColetarCoin : MonoBehaviour
{
    [SerializeField] int coisQuantidade = 1;
    private void OnTriggerEnter(Collider c)
    {
        if(c != null && c.CompareTag("Player"))
        {
            GameMenager.Instance.coinQuantidade += coisQuantidade;
            GameMenager.Instance.MudarTexto();
            Destroy(gameObject);
        }
    }
}
