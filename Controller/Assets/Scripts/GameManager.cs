using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> groundTiles;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Color denyColor;
    private void Update()
    {
        CheckTilesColor();
    }
    private void CheckTilesColor()
    {
        bool isLevelCompleted = true;
        for (int i = 0; i < groundTiles.Count; i++)
        {
            if (groundTiles[i].color != denyColor)
                continue;
            else
            {
                isLevelCompleted = false;
                break;
            }
        }
        if (isLevelCompleted)
        {
            Debug.Log("YOU DA WINNER YOU DA WINNER!!!");
        }
    }
}
