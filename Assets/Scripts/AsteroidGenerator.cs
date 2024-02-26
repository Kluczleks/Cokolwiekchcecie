using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AsteroidGenerator : MonoBehaviour
{   //model zawieraj�cy 3 kostki
    GameObject model;
    //wylosowana rotatacja /sekunde
    Vector3 rotation = Vector3.one;
    // Start is called before the first frame update
    void Start()
    {   //przypisuje do zmiennej model obiekt=pojemnik zawieraj�cy kostki
        //b�d�ce cz�ci� modelu asteroidy
        model = transform.Find("Model").gameObject;
        //przygotuj generator liczb losowych
        // Random r = new random();
        //nie robimy tego bo unity random jest statyczne random

        //iteruj przez cz�sci modelu
        foreach (Transform cube in model.transform)
        {
            //u�yj wbudowanego random.rotation
            cube.rotation = Random.rotation;

            //losowa liczba 
            float scale = Random.Range(0.9f, 1.1f);
            //przeskaluj
            cube.localScale = new Vector3 (scale, scale, scale); 
        }

        //wylosuj jednorazowo rotarcje/s naszej asteroidy
        rotation.x = Random.value;
        rotation.y = Random.value;
        rotation.z = Random.value;
        rotation *= Random.Range(10, 20);

    }

    // Update is called once per frame
    void Update()
    {
      //obr�� asteroid� w wyznaczonym (model) kierunku
      model.transform.Rotate (rotation * Time.deltaTime);    
    }
}
