using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public static Vida Instace;
    private void Awake()
    {
        Instace = this;
    }

    public int vidaAtua = 3;
    public int vidaMaxima = 7;

    [SerializeField] RawImage[] imageVida;
    [SerializeField] public Texture vidaCheia;
    [SerializeField] public Texture vidaVazia;

    private void Start()
    {
        MudarDeVida();
    }

    public void MortePlayer()
    {
        if(vidaAtua <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void MudarDeVida()
    {
        if (vidaAtua <= vidaMaxima)
        {
            for (int i = 0; i < imageVida.Length; i++)
            {
                if (i < vidaAtua)
                {
                    imageVida[i].texture = vidaCheia;
                }
                else imageVida[i].texture = vidaVazia;

                if (i < vidaMaxima)
                {
                    imageVida[i].enabled = true;
                }
                else imageVida[i].enabled = false;
            }
        }
        else if (vidaAtua > vidaMaxima) { vidaAtua = vidaMaxima; }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
