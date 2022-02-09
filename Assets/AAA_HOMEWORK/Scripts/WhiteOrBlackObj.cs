using UnityEngine;

namespace AAA_HOMEWORK.Scripts
{
    [CreateAssetMenu(fileName = "new WhiteOrBlack", menuName = "HOMEWORK/White or Black", order = 0)]
    public class WhiteOrBlackObj : ScriptableObject
    {
        [SerializeField] private Material chessMaterialColor;

        [SerializeField] private AmountCheesInGroup[] figureWithColor;
        
        public AmountCheesInGroup[] getFiguresWithColor()
        {
            return figureWithColor;
        }
       
    }
}