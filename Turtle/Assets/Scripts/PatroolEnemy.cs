using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatroolEnemy : MonoBehaviour
{

    public float speed;
    public float distance;

    private bool movingLeft = true;

    public Transform groudDetection;



    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groudDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false)
        {
            if(movingLeft == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingLeft = true;
            }
        }
    }

}
