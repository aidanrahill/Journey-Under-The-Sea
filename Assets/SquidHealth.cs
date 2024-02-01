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
                Invoke("Win", 3f);
                Destroy(gameObject.GetComponent<SpriteRenderer>());
                Destroy(gameObject.GetComponent<SquidBoss>());
            }
        }
    }
    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
}
