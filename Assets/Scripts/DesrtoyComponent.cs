using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesrtoyComponent : MonoBehaviour
{

    [System.Obsolete] // to silence warning
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<Score>().UpdateScore();
            DestroyObject(gameObject);
        }
    }
}
