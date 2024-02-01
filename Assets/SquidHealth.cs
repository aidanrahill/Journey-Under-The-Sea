using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SquidHealth : MonoBehaviour
{
    public int hp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("lol");
        if (!collision.CompareTag("Damage"))
        {
            hp--;
            if(hp <= 0)
            {
                Destroy(gameObject);
                Invoke("Win", 1);
            }
        }
    }
    void Win()
    {
        SceneManager.LoadScene("Win");
    }
}
