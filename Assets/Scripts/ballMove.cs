using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ballMove : MonoBehaviour
{
    public float Yspeed;
    bool go = true;
    public bool onPlatform = false;
    public GameObject ball;
    private SpriteRenderer mySpriteRenderer;

    private void Awake()
    {
        // Получение компонента SpriteRender
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.flipY = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && (onPlatform == true))   // Нажатие мыши для смены направления движения
        {
            changeDirection();
        }
    }

    void FixedUpdate()
    {
        ballMoveY();               
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        onPlatform = true; //остановка движения при касании платформы
        //обьявление крайних точек шара и платформы для проверки столкновения с торцом
        float otherMaxY = other.gameObject.transform.position.y + other.gameObject.transform.localScale.y / 2;
        float ballMinY = ball.gameObject.transform.position.y - ball.gameObject.GetComponent<BoxCollider2D>().size.y / 2 + 0.2f;
        float otherMinY = other.gameObject.transform.position.y - other.gameObject.transform.localScale.y / 2;
        float ballMaxY = ball.gameObject.transform.position.y + ball.gameObject.GetComponent<BoxCollider2D>().size.y / 2 - 0.2f;
        

        if ((ballMinY < otherMaxY) && (ball.gameObject.transform.position.y < 0f)) //проверка столкновения с торцом нижней платформы
        {
            Destroy(other.gameObject);
            onPlatform = false; //При уничтожении платформы игрок продолжает движение
        }

        else if ((ballMaxY > otherMinY) && (ball.gameObject.transform.position.y > 0f)) //проверка столкновения с торцом верхней платформы
        {
            Destroy(other.gameObject);
            onPlatform = false;  //При уничтожении платформы игрок продолжает движение
        }
    }

    void OnCollisionExit2D(Collision2D ball)
    {
        
        onPlatform = false; // при "отрыве" от платформы игрок возобновляет движение
    }

    void ballMoveY()
    {
        /* if (Input.GetMouseButtonDown(0) && (go == false))  // Нажатие мыши для начала движения
       {
           go = true;
       } */

        if ((go == true) && (onPlatform == false))  // Движение по оси Y
        {
            transform.Translate(Vector2.down * Yspeed * Time.deltaTime);
        }
    }

    void changeDirection()
    {
            Yspeed = Yspeed * -1;
            onPlatform = false;
            if (mySpriteRenderer.flipY == true)
            {
                mySpriteRenderer.flipY = false;
            }
            else { mySpriteRenderer.flipY = true; }        
    }
}
