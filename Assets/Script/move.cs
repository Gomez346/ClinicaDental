using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    private Animator a;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            a.SetTrigger("saltar");
            Debug.Log("espacio");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            sr.flipX = true;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            sr.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
        {
            a.SetBool("run", true);
            Debug.Log("D");

        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            a.SetBool("run", false);
        }

    }
}

