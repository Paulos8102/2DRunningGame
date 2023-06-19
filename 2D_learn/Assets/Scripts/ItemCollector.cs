//PaulJabez_LevelGame2D
//For collecting pineapples

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int treats = 0;

    [SerializeField] private Text treatsText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Treat"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            treats++;
            treatsText.text = "Treats: " + treats;
        }
    }
}
