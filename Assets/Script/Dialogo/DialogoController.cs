using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
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
    [SerializeField] TextMeshProUGUI tmNome;
    [SerializeField] RawImage imagemPerfil;
    [SerializeField] TextMeshProUGUI textoDialogo;
    public int i;
    [SerializeField] public bool ativarDialogo = false;
    public int dialogoMaximo;
    public List<Dialogo> dialogos;
    public int trocarDialogo;

    [SerializeField] int numLista;
    private void Start()
    {
        numLista = 0;
    }

    public void QualNPC()
    {
        
        for (i = -1; i <= trocarDialogo; i++)
        {
            num = trocarDialogo;
            tmNome.text = SistemaDialogo.Instance.dialogos[num].textoNome;
            imagemPerfil.texture = SistemaDialogo.Instance.dialogos[num].imagemDoPerfil;
            textoDialogo.text = SistemaDialogo.Instance.dialogos[numLista].listaTexto[numLista];

        }
    }

    public void ProximoDialogo()
    {
        
    }

    public void ReiniciarDialogo()
    {
        numLista = 0;
        QualNPC();
    }

    private void Update()
    {
        if (ativarDialogo && Input.GetKeyDown(KeyCode.E) && numLista <= dialogos.Count + 1)
        {
            numLista++;
            textoDialogo.text = SistemaDialogo.Instance.dialogos[num].listaTexto[numLista];
        }
    }
}
