using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public int vidaAtua = 3;
    public int vidaMaxima = 7;

    [SerializeField] RawImage[] imageVida;
    [SerializeField] public Texture vidaCheia;
    [SerializeField] public Texture vidaVazia;
    

    // Update is called once per frame
    void Update()
    {
        if(vidaAtua <= vidaMaxima)
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
        else if(vidaAtua > vidaMaxima) { vidaAtua = vidaMaxima; }
    }
}
