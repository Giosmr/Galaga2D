using UnityEngine;

public class MovimentoDosInimigos : MonoBehaviour
{
    public float velocidade = 2f;
    public GameObject laser;
    public float intervaloTiro = 1f;
    public int vidaMaxima = 10;

    private int vidaAtual;

    void Start()
    {
        vidaAtual = vidaMaxima;

        if (laser != null)
            InvokeRepeating(nameof(Atirar), 1f, intervaloTiro);
    }

    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;

        if (transform.position.x < -10f)
        {
            transform.position = new Vector3(
                10f,
                transform.position.y,
                transform.position.z
            );
        }
    }

    public void ReceberDano()
    {
        vidaAtual--;

        Debug.Log("VIDA DO INIMIGO: " + vidaAtual);

        if (vidaAtual <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Atirar()
    {
        if (laser != null)
        {
            Instantiate(
                laser,
                transform.position,
                Quaternion.Euler(0f, 0f, 90f)
            );
        }
    }
}