using UnityEngine;
using UnityEngine.UI;//permite escribir codigo para los UI en Unity (textos)

public class Score : MonoBehaviour
{
    public Transform player; // se referencia el jugador al slot de player desde Unity
    public Text scoreText;// Text referencia a los textos en Unity

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");// Se pasa a String los valores de posicion ya que son Float
        // y se referencia el texto al slot de ScoreText desde Unity. Se pone 0 dentro para mostrar valores enteros
    }
}
