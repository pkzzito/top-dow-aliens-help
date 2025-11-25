using UnityEngine;

public class CriadorDeInimigos : MonoBehaviour
{
    public GameObject[] inimigos;
    public Transform[] posicaoDoInimigo;
    
    public float tempoDoNovoInimigo = 10;
    
    private float cronometroDoInimigo;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        cronometroDoInimigo += Time.deltaTime;
        if (cronometroDoInimigo >= tempoDoNovoInimigo)
        {
            Transform ponto = posicaoDoInimigo[Random.Range(0, posicaoDoInimigo.Length)];

            GameObject inimigo = Instantiate(inimigos[Random.Range(0, inimigos.Length)],
                new Vector3(ponto.position.x, ponto.position.y, ponto.position.z),
                ponto.rotation);
            
            cronometroDoInimigo = 0;
        }
    }
}
