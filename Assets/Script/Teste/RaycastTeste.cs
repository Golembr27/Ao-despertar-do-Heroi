using Unity.Mathematics;
using UnityEngine;

public class RaycastTeste : MonoBehaviour
{
    public Transform player;
    RaycastHit2D ray;
    public float distanciaAnterior;
    public float distancia = 2f;
    public bool mudarDistancia = false;
    public bool ligarDistanciaInfinita = false;
    public Vector3 direcaoVector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        distanciaAnterior = distancia;
    }

    // Update is called once per frame
    void Update()
    {
        distanciaAnterior = distancia;
        if (ligarDistanciaInfinita)
        {
            float numero = Mathf.Infinity;
            distancia = numero;
        }
        else if(!mudarDistancia)
        {
            distancia = distanciaAnterior;
        }
        
        Vector3[] distancoes = {transform.right, transform.forward, -transform.right, -transform.forward };

        foreach(Vector3 direcao in distancoes)
        {
            ray = Physics2D.Raycast(transform.position, direcao * distancia, distancia);
            Debug.DrawRay(transform.position, direcao * distancia, Color.green);
        }
        
    }
}
