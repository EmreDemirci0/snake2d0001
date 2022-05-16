using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
    [SerializeField] GameObject Apple;
    [SerializeField] GameObject Speed;
    [SerializeField] GameObject Poison;
    float timerPoison,timerPear ;
   [SerializeField] float poisonHowManySec=3,pearHowManySec;
    void Start()
    {
        timerPoison = 0; 
        timerPear=0;
    }
    void Update()
    {
        float xPos = Random.Range(-10.2f, 10.2f);
        float yPos = Random.Range(-5.44f, 5.44f);
        if (SpeedController.isThereSpeed == false)
        {
            timerPear -= Time.deltaTime;
            if (timerPear < -1 * pearHowManySec)
            {
                Instantiate(Speed, new Vector2(xPos, yPos), Quaternion.identity);
                SpeedController.isThereSpeed = true;
                timerPear = 0;
            }
        }
        if (AppleController.isThereApple == false)
        {
            Instantiate(Apple, new Vector2(xPos, yPos), Quaternion.identity);
            AppleController.isThereApple = true;
        }
        if (PoisonController.isTherePoison == false)
        {
            timerPoison -= Time.deltaTime;
            if (timerPoison < -1*poisonHowManySec)
            {
                Instantiate(Poison, new Vector2(xPos, yPos), Quaternion.identity);
                PoisonController.isTherePoison = true;
                timerPoison = 0;
            }
        }
    }
}
