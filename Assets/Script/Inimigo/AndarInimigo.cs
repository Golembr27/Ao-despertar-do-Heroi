using UnityEngine;

public class AndarInimigo : MonoBehaviour
{
    public bool esquerda = false;
    public bool direita = false;
    public float numeAleatorio;
    public Vector3 varlorDeslocamento;
    private CharacterController cc;
    public float timer = 5f;
    public float velocidade = 2f;

    float moviX = 1f;
    float moviZ = 1f;

    private void Update()
    {
        
        timer-= Time.deltaTime;
        if (timer <= 0)
        {
            numeAleatorio = Random.Range(1, 3);
            Conta();
            cc.Move(varlorDeslocamento * velocidade * Time.deltaTime);
            timer = 5;
        }
    }

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        numeAleatorio = Random.Range(1, 3);
    }

    public void Conta()
    {
        if(numeAleatorio == 1)
        {
            Debug.Log("Foi Direita");
            esquerda = true;
            varlorDeslocamento = new Vector3(moviX, 0, 0);
        }
        if (numeAleatorio == 2)
        {
            Debug.Log("Foi Esquerda");
            direita = true;
            varlorDeslocamento = new Vector3(0, 0, moviZ);
        }
    }
}
