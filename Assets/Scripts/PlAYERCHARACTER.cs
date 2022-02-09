using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlAYERCHARACTER:Character

    {
        [SerializeField] private Transform enemyTransform;

        private void Update()
        {
            var dist = enemyTransform.position.x - transform.position.x;

            if (dist >= 1f || _characterInfo.Speed < 0f)
            {
                transform.Translate(Time.deltaTime*_characterInfo.Speed *transform.forward,Space.World);
            }
            
            
        }
    }
}