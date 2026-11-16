using UnityEngine;

public class GerenciadorDeInimigos : MonoBehaviour
{
    public GameObject[] prefabsInimigos;

    void Start()
    {
        CriarTodos();
    }

    void Update()
    {
        MovimentoDosInimigos[] inimigos =
            FindObjectsByType<MovimentoDosInimigos>(
                FindObjectsSortMode.None
            );

        if (inimigos.Length == 0)
        {
            CriarTodos();
        }
    }

    void CriarTodos()
    {
        for (int i = 0; i < prefabsInimigos.Length; i++)
        {
            if (prefabsInimigos[i] != null)
            {
                Vector3 posicao = new Vector3(
                    10f,
                    3f - (i * 2.5f),
                    0f
                );

                float rotacao = (i == 0) ? -90f : 90f;

                Instantiate(
                    prefabsInimigos[i],
                    posicao,
                    Quaternion.Euler(0f, 0f, rotacao)
                );
            }
        }
    }
}