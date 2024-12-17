using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual;
    [SerializeField] public int puntuacionMaxima;
    [SerializeField] public float tiempo;
    [SerializeField] public GameObject gameOver, botonRestart;
    [SerializeField] public GameObject jugador, enemigo;
    [SerializeField] TMP_Text textoTiempo;
    [SerializeField] public bool activarCronometro = true;
    // Start is called before the first frame update
    void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
        gameOver.SetActive(false);
        botonRestart.SetActive(false);  
    }
     void Update()
    {
        tiempo += Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        if (activarCronometro == true)
        {
            textoTiempo.text = $"{minutos:D2}: {segundos:D2}";
        }
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
