using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrPuzzle : MonoBehaviour
{
    public Sprite state1;
    public Sprite state2;
    public Sprite state3;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = state1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            ProgressPuzzleState();

    }

    void ProgressPuzzleState()
    {
        if (spriteRenderer.sprite == state1)
        {
            spriteRenderer.sprite = state2;
        }
        else if (spriteRenderer.sprite == state2)
        {
            spriteRenderer.sprite = state3;
        }
        else if (spriteRenderer.sprite == state3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
