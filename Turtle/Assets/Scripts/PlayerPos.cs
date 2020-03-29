using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameMaster>();
        transform.position = gm.lastCheckPointPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
