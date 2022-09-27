using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelImageController : MonoBehaviour
{
    public Image oldImage;
    public Sprite levelAImage;
    public Sprite levelBImage;
    public Sprite levelCImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateLevelImage(char currentLevel)
    {
        if (currentLevel == 'A') {

            oldImage.sprite = levelAImage;
            
        } else if (currentLevel == 'B') {

            oldImage.sprite = levelBImage;

        } else {

            oldImage.sprite = levelCImage;

        }
    }
}
