using System;
using UnityEngine;

namespace AAA_HOMEWORK.Scripts
{
    public class Chess_Init : MonoBehaviour
    {

        [SerializeField] private GameObject modelObj;
        [SerializeField] private _Name _nameObj;
        [SerializeField] private int idObj;
        [SerializeField] private int x, y;

        [SerializeField] private CheesInfo cheesInfo;
        [SerializeField] private PositionScrpt posScr;
        private void Start()
        {
            ReciveChesData();
            StandOnDesk();
        }

        private void StandOnDesk()
        {
            x = posScr.X;
            y = posScr.Y;

            Instantiate(modelObj, new Vector3(x*100, 0, y*100), Quaternion.identity);
        }

        private void ReciveChesData()
        {
            modelObj = cheesInfo.Model;
            _nameObj = cheesInfo.Name;
            idObj = cheesInfo.ID;
           
            
        }


    }
}