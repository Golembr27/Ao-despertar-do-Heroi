using Unity.VisualScripting;
using UnityEngine;

public class AtacaInimigo : MonoBehaviour
{
    [SerializeField] int danoInimigo;

    private void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            Vida.Instace.vidaAtua -= danoInimigo;
            Vida.Instace.MudarDeVida();
            Vida.Instace.MortePlayer();
        }
    }
}
