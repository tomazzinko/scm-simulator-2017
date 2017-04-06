﻿using System.Collections;
using UnityEngine;

namespace Event
{
    public class AlvaroEvent : RandomEvent
    {
        public GameObject Explosion;
        public float Delay = 3.0f;

        public override void Fire() {
            StartCoroutine ("DestroyAllIngredients");
        }
		
        private IEnumerator DestroyAllIngredients() {
            yield return new WaitForSeconds (Delay);

            var ingredients = FindObjectsOfType<Ingredient> ();

            foreach (var ingredient in ingredients) {
                if (ingredient.IsPickedUp || !ingredient.CanBePicked)
                {
                    continue;
                }
                ingredient.Explode(Explosion);
            }

            var boxes = FindObjectsOfType<Box.Box> ();
            foreach (var b in boxes) {
                if (!b.CanBePicked)
                {
                    b.EmptyBox();
                }
            }
        }
    }
}
