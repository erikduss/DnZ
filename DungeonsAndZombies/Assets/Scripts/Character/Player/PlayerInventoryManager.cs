using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Erikduss
{
    public class PlayerInventoryManager : CharacterInventoryManager
    {
        //Used to fetch the weapon that is equipped, basing their action, damage etc of these.
        [Header("Currently Equiped Weapons")]
        public WeaponItem currentRightHandWeapon;
        public WeaponItem currentLeftHandWeapon;

        //TODO: Does this need to be removed?
        [Header("Quick Slots")]
        public WeaponItem[] weaponsInRightHandSlots = new WeaponItem[3];
        public int rightHandWeaponIndex = 0;
        public WeaponItem[] weaponsInLeftHandSlots = new WeaponItem[3];
        public int leftHandWeaponIndex = 0;
    }
}
