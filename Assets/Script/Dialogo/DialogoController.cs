using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.Mathematics;
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
    [SerializeField] TextMeshProUGUI tmNome;

    [SerializeField] public TextMeshProUGUI textoDialogo;

    [SerializeField] RawImage imagemPerfil;

    [SerializeField] public bool ativarDialogo = false;
    [SerializeField] private bool proximoDialogo = false;
    [SerializeField] private bool acabouODialogo = false;

    public int dialogoMaximo;
    public int trocarDialogo;
    [SerializeField]int lista;

    public List<Dialogo> dialogos;
    public string[] listaTexto;

    [SerializeField] public int num;
    [SerializeField] public int numLista;
    [SerializeField] private int numDialogoFinal = 1;

    private void Start()
    {
        var dialogoAtual = SistemaDialogo.Instance.dialogos[num];
        lista = dialogoAtual.listaTexto.Count();
        acabouODialogo = false;
        numDialogoFinal = 0;
        numLista = 0;
        num = 0;
        //QualNPC();
    }

    public void QualNPC()
    {
        for (int i = -1; i <= trocarDialogo; i++)
        {
            if(proximoDialogo == false)
            {
                num = trocarDialogo;
                tmNome.text = SistemaDialogo.Instance.dialogos[num].textoNome;
                imagemPerfil.texture = SistemaDialogo.Instance.dialogos[num].imagemDoPerfil;
                MudarDialogo();
                proximoDialogo = true;
            }
        }
    }

    public void MudarDialogo()
    {
        if(lista > 0)
        {
            textoDialogo.text = SistemaDialogo.Instance.dialogos[num].listaTexto[numLista];
            AtivarAnimacaoTexto();
        }
    }

    public void ReiniciarDialogo()
    {
        var dialogoAtual = SistemaDialogo.Instance.dialogos[num];
        lista = dialogoAtual.listaTexto.Count();
        proximoDialogo = false;
        acabouODialogo = false;
        numDialogoFinal = 0;
        numLista = 0;
        num = 0;
        QualNPC();
    }

    public void ProximoDialogo()
    {
        if(lista > 0)
        {
            numLista++;
            MudarDialogo();
        }
    }

    public void AcabouDialogo()
    {
        lista--;
        if (lista <= 0)
        {
            acabouODialogo = true;
            NPC.Instance.DesativarDialogo();
        }
    }

    //VOID DialogoAnimacao
    public void DesativarAnimacaoTexto()
    {
        DialogoAnimacao.Instance.DesativarAnimacaoTexto();
    }

    public void AtivarAnimacaoTexto()
    {
        DialogoAnimacao.Instance.AtivarAnimacaoTexto();
    }
    //VOID DialogoAnimacao

    public void IniciarDialogo()
    {
        var dialogoAtual = SistemaDialogo.Instance.dialogos[num];
        if (acabouODialogo == false && ativarDialogo && Input.GetKeyDown(KeyCode.E))
        {
            if (proximoDialogo == false)
            {
                AcabouDialogo();
                QualNPC();
            }
            else if (proximoDialogo == true)
            {
                AcabouDialogo();
                ProximoDialogo();
            }
        }
    }

    private void Update()
    {
        IniciarDialogo();
    }
}
