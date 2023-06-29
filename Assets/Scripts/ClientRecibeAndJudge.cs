using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientRecibeAndJudge : MonoBehaviour
{
    public string myGift;
    public string myColor;
    public ClientBehavior client;
    [SerializeField]
    private ScoreManager scoreManager;
    private HealthManager healthManager;

    private bool alreadyDamaged;
    

    // Start is called before the first frame update
    void Start()
    {
    alreadyDamaged = false;
    ItemInBox myItem = gameObject.GetComponent<ItemInBox>(); //sacar el nombre del regalo que tiene
    myGift = myItem.getData();
    myColor = gameObject.tag; // sacar el tag del regalo que representa el color
    scoreManager = GameObject.Find("ScoreText").GetComponent<ScoreManager>();
    healthManager = GameObject.Find("HealthSystem").GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Client"))
        {
            Destroy(gameObject);
            client = other.gameObject.GetComponent<ClientBehavior>(); //sacar lo que quiere el cliente segun su script clientBehavior.
            if (client.GetDesiredGift().name+"(Clone)" == myGift && client.GetDesiredColor() == myColor)
            {
                print("Gracias.");
                //El jugador obtiene la puntuacion
                scoreManager.addScore(100);
                scoreManager.updateScore();
                

            }
            else
            {
                print("bato menso....");//si fue lo que queria desplegar un mensaje.

                if (!alreadyDamaged)
                {
                    healthManager.getDamaged();
                    alreadyDamaged=true;
                }
                
            }
        }
    }


}
