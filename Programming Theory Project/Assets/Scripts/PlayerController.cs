using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        // ENCAPSULATION setter validation
        public float speed
        {
            get { return m_Speed; }
            set
            {
                if (value > 0)
                {
                    m_Speed = value;
                }
                else
                {
                    Debug.LogError("Negative speed not allowed");
                }
            }
        }

        // ENCAPSULATION backing field
        private float m_Speed = 9;

        // ENCAPSULATION auto-implemented property
        public float m_horizontalInput { get; private set; }
        public float m_verticalInput { get; private set; }

        private void Start()
        {
            DeleteTextAddName();
            SetMaterialColorGreen();
        }

        void Update()
        {
            HandleMovement();

        }

        // ABSTRACTION
        protected void HandleMovement()
        {
            m_horizontalInput = Input.GetAxis("Horizontal");
            m_verticalInput = Input.GetAxis("Vertical");

            if (Mathf.Abs(m_horizontalInput) > 0 | Mathf.Abs(m_verticalInput) > 0)
            {
                transform.Translate(m_horizontalInput * speed * Time.deltaTime, 0, m_verticalInput * speed * Time.deltaTime);
            }
        }

        protected virtual void DeleteTextAddName()
        {
            TextMesh textMesh = GetComponentInChildren<TextMesh>();

            textMesh.text = null;
            textMesh.text += "Player";
        }

        public void SetMaterialColorGreen()
        {
            GetComponent<Renderer>().material.color = Color.green;

        }

        // Overload
        public void SetMaterialColorGreen(float addBlue)
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = new Color(0, 1, addBlue);
        }

    }
}
