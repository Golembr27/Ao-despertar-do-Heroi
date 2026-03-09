using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogoController : MonoBehaviour
{
    public static DialogoController Instance;

    void Awake()
    {
        Instance = this;
    }
    [Header("num dar Sequencia ao dialogo pela lista")]
    [SerializeField] int num;

    public void QualNPC()
    {
        if(Dialogo.Instance.textoNome == "npc1")
        {
            //Dialogo.Instance.listaTexto = Dialogo.Instance.listaTexto[num];
        }
    }
}
