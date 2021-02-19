using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timelimit = 1.0f;
    public float timer;

    // Update is called once per frame
    void Update()
    {
         timer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer > timelimit)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0;
        }
    }
}
