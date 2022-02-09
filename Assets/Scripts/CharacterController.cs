using System;
# if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace DefaultNamespace
{
    
    public class CharacterController : MonoBehaviour
    {
        [SerializeField] private CharacterData data;
        [SerializeField] private Transform[] legsTransforms;
        [SerializeField] private Transform[] kneeTransforms;
        [SerializeField] private Transform chestTransform;
        [SerializeField] private Transform neckTransform;
        [SerializeField] private Transform[] breastTransforms;

        private void Start()
        {
            UpdateCharacter();
        }

       # if UNITY_EDITOR
        private void Update()
        {
            if (Selection.activeGameObject !=gameObject)
            {
                return;
            }
            
            UpdateCharacter();
        }
        
        #endif

        private void UpdateCharacter()
        {
            foreach (var t in legsTransforms)
            {
                t.localScale = data.GetLegSize(t.localScale);
            }
            
            foreach (var t in kneeTransforms)
            {
                t.localScale = data.GetKneeSize(t.localScale);
            }
            
            foreach (var t in breastTransforms)
            {
                t.localScale = data.GetBreastSize;
            }

            chestTransform.localScale = data.GetChestSize;
            neckTransform.localScale = data.GetNeckSize;

        }
    }
}