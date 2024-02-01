using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float fadeDuration = 1.0f; // Duration of the fade
// public float delayBeforeFadeIn = 2.0f; // Delay before the item fades back in

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        // Ensure there is a SpriteRenderer component attached to the GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player sprite has collided with the collectable
        if (collision.gameObject.CompareTag("Player"))
        {
            // Start fading out the item
            StartCoroutine(FadeOut());
        }
    }

    private System.Collections.IEnumerator FadeOut()
    {
        float timer = 0f;
        Color originalColor = spriteRenderer.color;

        while (timer < fadeDuration)
        {
            // Calculate the alpha value based on the current time and duration
            float alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration);
            spriteRenderer.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);

            timer += Time.deltaTime;
            yield return null;
        }

        // Disable the GameObject temporarily
        gameObject.SetActive(false);

        // Wait for the specified delay before fading back in
       // yield return new WaitForSeconds(delayBeforeFadeIn);

        // Enable the GameObject and start fading it back in
        gameObject.SetActive(true);
        StartCoroutine(FadeIn());
    }

    private System.Collections.IEnumerator FadeIn()
    {
        float timer = 0f;
        Color originalColor = spriteRenderer.color;

        while (timer < fadeDuration)
        {
            // Calculate the alpha value based on the current time and duration
            float alpha = Mathf.Lerp(0f, 1f, timer / fadeDuration);
            spriteRenderer.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);

            timer += Time.deltaTime;
            yield return null;
        }
    }
}
