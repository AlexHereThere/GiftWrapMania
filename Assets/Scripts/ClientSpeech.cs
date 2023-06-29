using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSpeech : MonoBehaviour
{
    public ClientBehavior clientWantSource;
    public GameObject colorYellow,colorSantaRed,colorGreen,colorBlue,colorSilver,colorSFRed;
    public GameObject giftMii,giftPoly,giftX;

    // Start is called before the first frame update
    void Start()
    {
  
    if(clientWantSource.GetDesiredColor() == "YellowGift") colorYellow.SetActive(true);
    else if(clientWantSource.GetDesiredColor() == "GreenGift") colorGreen.SetActive(true);
    else if(clientWantSource.GetDesiredColor() == "BlueGift") colorBlue.SetActive(true);
    else if(clientWantSource.GetDesiredColor() == "SilverGfit") colorSilver.SetActive(true);
    else if(clientWantSource.GetDesiredColor() == "SantaRedGift") colorSantaRed.SetActive(true);
    else if(clientWantSource.GetDesiredColor() == "SnowflakeRedGfit") colorSFRed.SetActive(true);
    if(clientWantSource.GetDesiredGift().name == "Mii ifelse") giftMii.SetActive(true);
    else if(clientWantSource.GetDesiredGift().name == "PolyStation") giftPoly.SetActive(true);
    else if(clientWantSource.GetDesiredGift().name == "Xbox720") giftPoly.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
