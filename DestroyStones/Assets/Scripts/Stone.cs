using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Altura a la que la piedra se destruira
    private const float yDie = -30.0f;
    // La explosion tras destruir una piedra
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yDie)
        {
            Destroy(gameObject);
        }
    }

    // Si se pulsa la piedra con el raton, se destruira
    void OnMouseDown()
    {
        // Se instanciara la explosion y se destruira en 3.3 segundos
        Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
        Destroy(gameObject);

        if (gameObject.tag == "Error")
        {
            GameManager.currentNumberLives -= 1;
        }
        else
        {
            // DestroyStones-VII-
            GameManager.currentNumberDestroyedStones++;
            GameManager.currentPoints++;
            if (gameObject.tag == "Extra")
            {
                GameManager.currentPoints++;
            }
        }
    }
}
