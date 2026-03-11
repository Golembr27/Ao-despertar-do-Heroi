using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] GameObject objDialogo;
    public int numNPC;

    private void Start()
    {
        DialogoController.Instance.trocarDialogo = numNPC;
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            DialogoController.Instance.trocarDialogo = numNPC;
            DialogoController.Instance.ativarDialogo = true;
            objDialogo.gameObject.SetActive(true);
            DialogoController.Instance.ReiniciarDialogo();
        }
    }

    private void OnTriggerExit(Collider c)
    {
        DialogoController.Instance.ativarDialogo = false;
        objDialogo.gameObject.SetActive(false);
        DialogoController.Instance.ReiniciarDialogo();
    }
}
