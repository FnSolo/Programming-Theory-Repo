using UnityEngine;

namespace Player
{
    // INHERITANCE
    public class BobsDog : BobController
    {
        void Start()
        {
            speed = 1;
            speed = -1; // to show setter validation preventing negative numbers

            DeleteTextAddName();
            SetMaterialColorGreen(1);
        }

        void Update()
        {
            HandleMovement();
        }

        // INHERITANCE & POLYMORPHISM
        protected override void DeleteTextAddName()
        {
            base.DeleteTextAddName();
            GetComponentInChildren<TextMesh>().text += "'s dog";
        }
    }
}
