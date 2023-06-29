using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DesireGift : MonoBehaviour
{
    public Image desireGift;
    public Image desireColor;
    public ClientBehavior client;
    void Start()
    {
        desireGift.material = client.GetDesiredGift().GetComponent<Renderer>().sharedMaterial;
        desireColor.sprite = client.GetDesiredColor() switch
        {
            "YellowGift" => Resources.Load<Sprite>("Sprites/SantaGoldColor"),
            "SantaRedGift" => Resources.Load<Sprite>("Sprites/SantaRedColor"),
            "BlueGift" => Resources.Load<Sprite>("Sprites/SnowflakeBlueColor"),
            "SilverGift" => Resources.Load<Sprite>("Sprites/TreeSilverColor"),
            "GreenGift" => Resources.Load<Sprite>("Sprites/TreeGreenColor"),
            "SnowflakeRedGift" => Resources.Load<Sprite>("Sprites/SnowflakeRedColor"),
            _ => Resources.Load<Sprite>("Sprites/TreeGreenColor")
        };
        print(
            client.GetDesiredColor() + " -> " +
            desireColor.sprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
