using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Dialogo
{
    [Header("Nome do NPC")]
    public string textoNome;
    [Header("Foto normal de NPC")]
    public Texture imagemDoPerfil;
    [Header("Lista de todos os textos")]
    public string[] listaTexto;
    public int numMaximo;
}

