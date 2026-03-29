using UnityEngine;

public class NPC : MonoBehaviour
{
    public static NPC Instance;
    private void Awake()
    {
        Instance = this;
    }

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
            AtivarDialogo();
            DialogoController.Instance.ReiniciarDialogo();
        }
    }

    private void OnTriggerExit(Collider c)
    {
        DialogoController.Instance.ativarDialogo = false;
        DesativarDialogo();
        DialogoController.Instance.ReiniciarDialogo();
    }

    public void AtivarDialogo()
    {
        objDialogo.gameObject.SetActive(true);
    }

    public void DesativarDialogo()
    {
        objDialogo.gameObject.SetActive(false);
    }
}
