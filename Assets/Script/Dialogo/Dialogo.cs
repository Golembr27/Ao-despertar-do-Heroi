using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogo
{
    public static Dialogo Instance;

    void Awake()
    {
        Instance = this;
    }
    [Header("Nome do NPC")]
    [SerializeField] public string textoNome;
    [Header("Foto normal de NPC")]
    [SerializeField] public RawImage imagemDoPerfil;
    [Header("Lista de todos os textos")]
    [SerializeField] public string[] listaTexto;
    public int num;
}