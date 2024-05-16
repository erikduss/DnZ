using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Erikduss
{
    public class CharacterStatsManager : MonoBehaviour
    {
        CharacterManager character;

        protected virtual void Awake()
        {
            character = GetComponent<CharacterManager>();
        }

        protected virtual void Start()
        {

        }

        public int CalculateHealthBasedOnVitalityLevel(int vitality)
        {
            float health = 0;

            health = vitality * 15;

            return Mathf.RoundToInt(health);
        }
    }
}
