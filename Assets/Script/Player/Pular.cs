using UnityEngine;

public class Pular : MonoBehaviour
{
    /*
    Animator an;

    [SerializeField] private bool estaNoChao;
    [SerializeField] private Transform peDoPersonagem;
    [SerializeField] private LayerMask colisaoLayer;
    [SerializeField] private float forcaPulo = 3f;
    private CharacterController cc;

    [SerializeField] private float forcaY = -9.81f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        an = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        estaNoChao = Physics.CheckSphere(peDoPersonagem.position, 0.3f, colisaoLayer);
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            an.SetBool("podePular", true);
            forcaY = forcaPulo;
        }

        if (forcaY > -9.81f)
        {
            forcaY += -9.81f * Time.deltaTime;
        }
        cc.Move(new Vector3(0, forcaY, 0) * Time.deltaTime);

        if (!estaNoChao)
        {
            an.SetBool("podePular", false);
        }
    
    }
    */
    [SerializeField] private Transform peDoPersonagem;
    [SerializeField] private LayerMask colisaoLayer;
    [SerializeField] private float forcaPulo = 3f;
    [SerializeField] private bool estaNoChao;
    [SerializeField] private float forcaY = -9.81f;
    public KeyCode tecla = KeyCode.None;
    private CharacterController cc;
    Animator an;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        an = GetComponent<Animator>();
    }

    private void Update()
    {
        
        estaNoChao = Physics.CheckSphere(peDoPersonagem.position, 0.3f, colisaoLayer);
        an.SetBool("estanoChao", estaNoChao);
        if (Input.GetKeyDown(tecla) && estaNoChao)
        {
            forcaY = forcaPulo;
            an.SetTrigger("saltar");
        }

        if(forcaY > -9.81f)
        {
            forcaY += -9.81f * Time.deltaTime;
        }
        cc.Move(new Vector3(0f, forcaY, 0f) * Time.deltaTime);
    }
}
