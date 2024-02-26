using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    Transform player;

    //prefab statycznej asteroidy 
    public GameObject staticAsteroid;
    float timeSinceSpawn;
    // Start is called before the first frame update
    void Start()
    {
        //znajdz gracz i przypisz go do zmiennej
        player = GameObject.FindWithTag("Player").transform;
        timeSinceSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        timeSinceSpawn += Time.deltaTime;
        if(timeSinceSpawn > 1) {
            GameObject asteroid = SpawnAsteroid(staticAsteroid);
            timeSinceSpawn = 0;
                }
    }
    GameObject SpawnAsteroid(GameObject prefab)
    {
        //generyczna funkcja sluzaca do wylosowania wspó³rzêdnych i umieszczania 
        //w tym miejscu asteroidy z prefaba
        //losowa pozycha w odleglosci 10 jednostek od srodka swiata
        Vector3 randomPosition = Random.onUnitSphere * 10;

        //naluz to na gracza 
        randomPosition += player.position;
        //stwórz zmienn¹ asteroid, zespawnuj nowy asteroid korzystajac z prefaba
        // w losowym miejscu, z rotacj¹ domysln¹
        GameObject asteroid = Instantiate(staticAsteroid, randomPosition, Quaternion.identity);
        //zwroc asteroide jako wynik dzialania 
        return asteroid;
    }
}

