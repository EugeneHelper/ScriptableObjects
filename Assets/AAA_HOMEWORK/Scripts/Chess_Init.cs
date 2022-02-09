using System;
using UnityEngine;

namespace AAA_HOMEWORK.Scripts
{
    public class Chess_Init : MonoBehaviour
    {
        public GameObject[] blackChess = new GameObject[8];
        public GameObject[] whiteChess = new GameObject[8];

        public GlobalChessGroup whGroup;
        public GlobalChessGroup blGroup;
        
        private AmountCheesInGroup[] _amountCheesInGroup= new AmountCheesInGroup[6];
        private CheesInfo[] _cheesInfos = new CheesInfo[16];
        private void Start()
        {
            ReciveChesData();
        }

        private void ReciveChesData()
        {

        _amountCheesInGroup = whGroup.GetWhiteGroup().getFiguresWithColor(); //6 белых групп

            for (int i = 0; i < _amountCheesInGroup.Length; i++)
            {
                _cheesInfos[i] = _amountCheesInGroup[i].getFigures();
            }
            
        }
    }
}