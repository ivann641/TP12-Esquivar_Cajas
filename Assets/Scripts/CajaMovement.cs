using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
public float speed = 0.2f;
public float incremento = 0.05f;
private bool estaDetenido = false;

    void Update()
    {
        if (!estaDetenido)
        {
            transform.Translate(0, -speed, 0);
        }
    }

    public void AumentarVelocidad()
    {
        speed += incremento;
    }

}
