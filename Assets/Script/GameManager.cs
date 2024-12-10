using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual;
    [SerializeField] public int puntuacionMaxima;
    [SerializeField] public float tiempo;
    // Start is called before the first frame update
     void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
    }
     void Update()
    {
        tiempo += Time.deltaTime;
    }
    public void perder()
    {

    }
    public void reiniciarJuego()
    {

    }
    public void actualizarPuntuacion()
    {
        puntuacionActual++;
        if (puntuacionActual > puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion",puntuacionMaxima);
        }
    }
}
