using UnityEngine;

namespace AAA_HOMEWORK.Scripts
{
    public enum _Name
    {
        King, 
        Queen,
        Tower,
        Elefant,
        Horse,
        Pawn
    }


    [CreateAssetMenu(fileName = "new ChesInfo", menuName = "HOMEWORK/ChessInfo", order = 0)]
    public class CheesInfo : ScriptableObject
    {
        [SerializeField] private GameObject model;
        [SerializeField] private _Name _name;
        [SerializeField] private int id;

        public GameObject Model => model;
        public int ID => id;
        public _Name Name => _name;


    }
}