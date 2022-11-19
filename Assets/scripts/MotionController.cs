using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class MotionController : MonoBehaviour
{
    public float speed = 5.0f;
    public float cellSize = 2.0f;//размер ячейки, а также расстояни на которое нужно сдвинуться если была нажата кнопка
    bool isMoving = false;//находимся ли в движении
    Vector3 direction;//направление движения
    Vector3 destPos;//позиция куда двигаемся
    private Rigidbody rb;
    int current_direktion = 0;
    int new_direktion = 0;


    private void Start()
    {

    }

    void Update()
    {
        if (isMoving == true)
        {

            if (current_direktion != new_direktion)

            {


                Vector3 newRotation;
                switch (new_direktion)
                {
                    case 1:
                        newRotation = new Vector3(0, 90, 0);
                        break;
                    case 2:
                        newRotation = new Vector3(0, 180, 0);
                        break;
                    case 3:
                        newRotation = new Vector3(0, -90, 0);
                        break;
                    case 0:
                        newRotation = new Vector3(0, 0, 0);
                        break;
                    default:
                        newRotation = new Vector3(0, 0, 0);
                        break;
                }
                current_direktion = new_direktion;
                transform.eulerAngles = newRotation;
            }



                float step = speed * Time.deltaTime;//расстояние, которое нужно пройти в текущем кадре
            transform.position = Vector3.MoveTowards(transform.position, destPos, step);//двигаем персонажа
                                                                                        //достигли нужной позиции - отключаем движение, включаем ловлю нажатых клавиш
            if (transform.position == destPos) isMoving = false;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                //move up
                direction = Vector3.forward;
                destPos = transform.position + direction * cellSize;
                isMoving = true;
               

                new_direktion = 0;

            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                //move left
                direction = Vector3.left;
                destPos = transform.position + direction * cellSize;
                isMoving = true;
               
                new_direktion = 3;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                //move down
                direction = Vector3.back;
                destPos = transform.position + direction * cellSize;
                isMoving = true;
               
                new_direktion = 2;

            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                //move right
                direction = Vector3.right;
                destPos = transform.position + direction * cellSize;
                isMoving = true;
               
                new_direktion = 1;

            }
        }
    }
}