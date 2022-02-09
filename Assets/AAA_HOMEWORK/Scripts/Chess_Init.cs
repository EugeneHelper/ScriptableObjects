using System;
using UnityEngine;

namespace AAA_HOMEWORK.Scripts
{
    public class Chess_Init : MonoBehaviour
    {
        public Figure[] blackChess = new GameObject[8];
        public Figure[] whiteChess = new GameObject[8];

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
                _cheesInfos = _amountCheesInGroup[i].getFigures();
            }

            for (int i = 0; i < whiteChess.Length; i++)
            {
                whiteChess[i].model = _cheesInfos[i].GetMeshModel();
            }
            
        }
    }
}