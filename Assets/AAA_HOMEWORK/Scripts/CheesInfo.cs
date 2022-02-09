using UnityEngine;

namespace AAA_HOMEWORK.Scripts
{
    [CreateAssetMenu(fileName = "new ChesInfo", menuName = "HOMEWORK/ChessInfo", order = 0)]
    public class CheesInfo : ScriptableObject
    {
        [SerializeField] private GameObject model;

        public GameObject GetMeshModel()
        {
            return model;
        }
    }
}