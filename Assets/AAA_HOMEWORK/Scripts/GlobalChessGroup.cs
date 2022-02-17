using UnityEngine;

namespace AAA_HOMEWORK.Scripts
{
    public class GlobalChessGroup : MonoBehaviour
    {
        [SerializeField] private WhiteOrBlackObj whiteGroups;
        [SerializeField] private WhiteOrBlackObj blackGroups;

        public WhiteOrBlackObj GetBlackGroup()
        {
            return whiteGroups;
        }
        
        public WhiteOrBlackObj GetWhiteGroup()
        {
            return blackGroups;
        }
    }
}