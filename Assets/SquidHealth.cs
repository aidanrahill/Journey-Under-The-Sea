using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SquidHealth : MonoBehaviour
{
    int maxHealth;
    float maxBarWidth;
    public int hp;
    public RectTransform healthBar;
    private void Start()
    {
        maxHealth = hp;
        maxBarWidth = healthBar.sizeDelta.x;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Damage"))
        {
            hp--;
            healthBar.sizeDelta = new Vector2(maxBarWidth * ((float)hp / (float)maxHealth), healthBar.sizeDelta.y);
            if (hp <= 0)
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
