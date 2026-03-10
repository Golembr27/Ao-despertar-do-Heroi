using System.Collections.Generic;
using UnityEngine;
using static Dialogo;

public class SistemaDialogo : MonoBehaviour
{
    public static SistemaDialogo Instance;
    private void Awake()
    {
        Instance = this;
    }
    [Header("Lista de falas")]
    public List<Dialogo> dialogos = new List<Dialogo>();
}