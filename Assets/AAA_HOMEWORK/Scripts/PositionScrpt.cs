using UnityEngine;

namespace AAA_HOMEWORK.Scripts
{



    [CreateAssetMenu(fileName = "new PosConf", menuName = "HOMEWORK/PosScript", order = 0)]
    public class PositionScrpt : ScriptableObject
    {
      
        [Range(0,7)]
        [SerializeField] private int x, y;


        public int X => x;
        public int Y => y;
    }
}