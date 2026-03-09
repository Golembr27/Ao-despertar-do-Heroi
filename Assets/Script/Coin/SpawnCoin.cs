using System;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField] private Transform area;
    [SerializeField] private GameObject coin;
    [SerializeField] private float timerMaximo = 5f;
    [SerializeField] private float timerAtual = 0;
    

    private void Update()
    {
        tempoDeSpawnDoCoin();
    }

    private void tempoDeSpawnDoCoin()
    {
        timerAtual = timerAtual + 1 * Time.deltaTime;
        if(timerAtual >= timerMaximo)
        {
            GameObject spawnCoin = Instantiate(coin, area.position, area.rotation);
            timerAtual = 0;
        }
    }
}
