using UnityEngine;

namespace Player
{
    // INHERITANCE
    public class BobController : PlayerController
    {
        // Start is called before the first frame update
        void Start()
        {
            DeleteTextAddName();
            SetMaterialColorGreen(0.5f);
        }

        // Update is called once per frame
        void Update()
        {
            HandleMovement();
        }

        // POLYMORPHISM
        protected override void DeleteTextAddName()
        {
            base.DeleteTextAddName();
            GetComponentInChildren<TextMesh>().text += "'s Bob";
        }
    }
}