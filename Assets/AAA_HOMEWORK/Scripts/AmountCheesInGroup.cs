using UnityEngine;

namespace AAA_HOMEWORK.Scripts
{
    [CreateAssetMenu(fileName = "new AmountCheesInGroup", menuName = "HOMEWORK/AmountCheesInGroup", order = 0)]
    public class AmountCheesInGroup : ScriptableObject
    {
        [SerializeField] private CheesInfo[] figures;
        
        public CheesInfo[] getFigures()
        {
            return figures;
        }
    }
}