using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class Colision : MonoBehaviour
{
    public int Nivel;

    public void OnCollisionEnter2D(Collision2D objeto) {
        if (objeto.gameObject.name=="Pared")
        {
            transform.position = new Vector3(-7,-3,0);
        }

        if (objeto.gameObject.name=="Meta")
        {
            if (Nivel == 1)
            {
                SceneManager.LoadScene("Nivel 1",LoadSceneMode.Single);
            }if (Nivel == 2)
            {
                SceneManager.LoadScene("Nivel 2",LoadSceneMode.Single);
            }if (Nivel == 3)
            {
                SceneManager.LoadScene("Nivel 3",LoadSceneMode.Single);
            }
        }
    }

}
