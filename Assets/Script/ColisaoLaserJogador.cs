using UnityEngine;

public class ColisaoLaserJogador : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D outro)
    {
        MovimentoDosInimigos inimigo =
            outro.GetComponent<MovimentoDosInimigos>();

        if (inimigo == null)
        {
            inimigo = outro.GetComponentInParent<MovimentoDosInimigos>();
        }

        if (inimigo != null)
        {
            inimigo.ReceberDano();
            Destroy(gameObject);
        }
    }
}