using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> backgroundSprites;
    public float speed = 0.015f; 
    private float sprite;

    private void Start()
    {
        sprite = backgroundSprites[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x;
    }

    private void Update()
    {
        foreach (SpriteRenderer sprite in backgroundSprites)
        {
            sprite.transform.Translate(Time.deltaTime, 0, 0);
        }

        if (backgroundSprites[0].transform.position.x > sprite)
        {
            backgroundSprites[0].transform.position = new Vector3(backgroundSprites[1].transform.position.x - sprite, 0, 0);
        }
        if (backgroundSprites[1].transform.position.x > sprite)
        {
            backgroundSprites[1].transform.position = new Vector3(backgroundSprites[0].transform.position.x - sprite, 0, 0);
        }

    }
}
