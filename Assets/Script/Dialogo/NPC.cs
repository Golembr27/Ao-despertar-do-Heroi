using UnityEngine;

public class NPC : MonoBehaviour
{
    public static NPC Instance;
    [SerializeField] GameObject objDialogo;
    private void Awake()
    {
        //objDialogo.gameObject.SetActive(false);
        Instance = this;
    }
    public int numNPC;

    private void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            DialogoController.Instance.ativarDialogo = true;
            objDialogo.gameObject.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider c)
    {
        DialogoController.Instance.ativarDialogo = false;
        objDialogo.gameObject.SetActive(false);
        DialogoController.Instance.ReiniciarDialogo();
    }
}
