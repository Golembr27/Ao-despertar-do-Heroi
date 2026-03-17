using System.Collections;
using TMPro;
using UnityEngine;

public class DialogoAnimacao : MonoBehaviour
{
    public static DialogoAnimacao Instance;

    private void Awake()
    {
        Instance = this;
    }
    [SerializeField] private float tipoDelay = 0.5f;
    [SerializeField] public TextMeshProUGUI textoAnimacao;
    DialogoController dc;

    public bool animacao = false;

    public string textoCompleto;

    private void Start()
    {
        textoAnimacao = DialogoController.Instance.textoDialogo;
        dc = GetComponent<DialogoController>();
    }

    public void AnimacaoTexto()
    {
        StartCoroutine(TypeText());  
    }

    public IEnumerator TypeText()
    {
        dc.PararCorotinaDaAnimacao();
        textoAnimacao.maxVisibleCharacters = 0;
        for (int i = 0; i <= SistemaDialogo.Instance.dialogos[dc.num].listaTexto[dc.numLista].Length; i++)
        {
            textoAnimacao.maxVisibleCharacters = i;
            yield return new WaitForSeconds(tipoDelay);
        }
    }
}
