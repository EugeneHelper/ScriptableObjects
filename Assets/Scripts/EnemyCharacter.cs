
using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class EnemyCharacter:Character
    {
        [SerializeField] private Transform player;
        [SerializeField] private FloatVeriable playerHp;

        private void Update()
        {
            if (Math.Abs(player.position.x - transform.position.x) > 1)
            {
                transform.Translate(Time.deltaTime*_characterInfo.Speed *transform.forward,Space.World);
                return;
            }

            playerHp.Value -= Time.deltaTime;
        }
    }
}