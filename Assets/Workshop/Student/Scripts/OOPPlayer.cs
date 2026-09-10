using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

namespace Solution
{

    public class OOPPlayer : Character
    {
        public Inventory inventory;
        private InputAction moveAction;
        private InputAction fireAction;
        public override void SetUP()
        {
            base.SetUP();
            moveAction = InputSystem.actions.FindAction("Move");
            fireAction = InputSystem.actions.FindAction("Fire");
            PrintInfo();
            GetRemainEnergy();
            inventory = GetComponent<Inventory>();
        }

        public void Update()
        {
            if (moveAction.triggered)
            {
                Vector2 direction = moveAction.ReadValue<Vector2>();
                Move(direction);
            }
            if (fireAction.triggered)
            {
                UseFireStorm();
            }
        }
        public override void Move(Vector2 direction)
        {
            base.Move(direction);
            mapGenerator.MoveEnemies();
        }

        public void UseFireStorm()
        {
            if (inventory.HasItem("FireStorm",1))
            {
                //stundent exercise: use FireStorm to attack 3 lower energy enemies on map
            }
            else
            {
                Debug.Log("No FireStorm in inventory");
            }
        }
        public OOPEnemy[] SortEnemiesByRemainningEnergy1()
        {
            var enemies = mapGenerator.GetEnemies();
            //stundent exercise: sort enemies by remainning energy

            return enemies;
        }

        public OOPEnemy[] SortEnemiesByRemainningEnergy2()
        {
            var enemies = mapGenerator.GetEnemies();
            //stundent exercise: sort enemies by remainning energy

            return enemies;
        }
        public void Attack(OOPEnemy _enemy)
        {
            _enemy.TakeDamage(AttackPoint);
            Debug.Log(_enemy.name + " is energy " + _enemy.energy);
        }
        protected override void CheckDead()
        {
            base.CheckDead();
            if (energy <= 0)
            {
                Debug.Log("Player is Dead");
            }
        }

    }

}