using UnityEngine;

public class Movmento : MonoBehaviour
{
    public float velocidade = 3f;
    private Transform minhaCamera;
    private CharacterController cc;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
        minhaCamera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimentacao = new Vector3 (horizontal, 0f, vertical);

        if (movimentacao != Vector3.zero)
        {
            animator.SetBool("podeCorrer", true);
        }else animator.SetBool("podeCorrer", false);

        movimentacao = minhaCamera.TransformDirection(movimentacao);
        movimentacao.y = 0;
        cc.Move(movimentacao * Time.deltaTime * velocidade);
        if(movimentacao != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movimentacao), Time.deltaTime * 10);
        }
    }
}
