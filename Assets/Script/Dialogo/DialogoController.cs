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
    [SerializeField] private bool pularDialogo = false;

    public int dialogoMaximo;
    public int trocarDialogo;

    public List<Dialogo> dialogos;

    [SerializeField] public int num;
    [SerializeField] public int numLista;
    private void Start()
    {
        numLista = 0;
    }

    public void QualNPC()
    {
        for (int i = -1; i <= trocarDialogo; i++)
        {
            num = trocarDialogo;
            tmNome.text = SistemaDialogo.Instance.dialogos[num].textoNome;
            imagemPerfil.texture = SistemaDialogo.Instance.dialogos[num].imagemDoPerfil;
            textoDialogo.text = SistemaDialogo.Instance.dialogos[numLista].listaTexto[numLista];
            DialogoAnimacao.Instance.AnimacaoTexto();
        }
    }

    public void ProximoDialogo()
    {
        numLista++;
        textoDialogo.text = SistemaDialogo.Instance.dialogos[num].listaTexto[numLista];
        DialogoAnimacao.Instance.AnimacaoTexto();
        pularDialogo = true;
    }

    public void ReiniciarDialogo()
    {
        pularDialogo = true;
        numLista = 0;
        QualNPC();
    }

    public void PararCorotinaDaAnimacao()
    {
        if(pularDialogo == true && Input.GetKeyDown(KeyCode.E))
        {
            StopCoroutine(DialogoAnimacao.Instance.TypeText());
            pularDialogo = false;
        }
    }

    public void AcabarComOTexto()
    {
        PararCorotinaDaAnimacao();
        DialogoAnimacao.Instance.textoAnimacao.maxVisibleCharacters = SistemaDialogo.Instance.dialogos[num].listaTexto[numLista].Length;
        pularDialogo = false;
    }
    private void Update()
    {
        if (ativarDialogo && Input.GetKeyDown(KeyCode.E) && numLista <= dialogos.Count + 1)
        {
            pularDialogo = true;
            ProximoDialogo();
        }
    }
}
