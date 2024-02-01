
using TarodevController;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    public int health = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("trans"))
        {
            SceneManager.LoadScene(collision.gameObject.name);
            SceneManager.LoadScene("UI", LoadSceneMode.Additive);
        }
        else if (collision.CompareTag("Damage"))
        {
            Destroy(collision.gameObject);
            Damage(1);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    public void Damage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }

}