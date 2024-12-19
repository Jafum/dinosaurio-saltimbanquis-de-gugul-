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
    [SerializeField] EnemigoControl enemigo1;
    [SerializeField] TMP_Text textoTiempo;
    [SerializeField] public bool activarCronometro = true;
    int minutos, segundos;
    // Start is called before the first frame update
    void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
        gameOver.SetActive(false);
        botonRestart.SetActive(false);  
    }
     void Update()
    {
        
        if (activarCronometro == true)
        {
            tiempo += Time.deltaTime;
            minutos = (int)tiempo / 60;
            segundos = (int)tiempo % 60;
        }
        textoTiempo.text = $"{minutos:D2}:{segundos:D2}";
    }
    public void perder()
    {
        jugador.SetActive(false);
        enemigo.SetActive(false);
        gameOver.SetActive(true);
        botonRestart.SetActive(true);
        activarCronometro = false;
    }
    public void reiniciarJuego()
    {
        puntuacionActual = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        gameOver.SetActive(false);
        botonRestart.SetActive(false);
        tiempo = 0;
        activarCronometro = true;
        enemigo1.IniciarEnemigo();
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
