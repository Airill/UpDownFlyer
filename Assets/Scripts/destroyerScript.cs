using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyerScript : MonoBehaviour
{

   void OnTriggerEnter2D(Collider2D other)
    {
       // Destroy(other);
        if (other.name == "Ball")   //Проверяем проигрышь
        {

            SceneManager.LoadScene(2);
            return;
        }
        //Ниже уничтожаем обьекты - не игрока - попадающие в уничтожитель
        if (other.gameObject.transform.parent)
        {
            Destroy (other.gameObject.transform.parent.gameObject);
            
        }
        else
        {
            Destroy (other.gameObject);
            
        }


    }
}