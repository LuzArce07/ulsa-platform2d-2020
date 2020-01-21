namespace Platform2DUtils.GameplaySystem
{
    using UnityEngine;

    public class GameplaySystem
    {
        ///<summary>
        /// Returns a Vector2 with Horizontal and Vertical axes.
        ///</summary>
        public static Vector2 Axis
        {
            get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }

        ///<summary>
        /// Moves player in Horizontal axis with keyboard inputs.
        ///</summary>
        ///<param name="t">Transform component of the player</param>
        ///<param name="moveSpeed">The coeficient of speed</param>
        public static void TMovement(Transform t, float moveSpeed)
        {
            t.Translate(Vector2.right * Axis.x * moveSpeed);
        }
        ///<summary>
        /// Moves player in Horizontal axis with keyboard inputs and multiplied by delta time.
        ///</summary>
        ///<param name="t">Transform component of the player</param>
        ///<param name="moveSpeed">The coeficient of speed</param>
        public static void TMovementDelta(Transform t, float moveSpeed)
        {
            t.Translate(Vector2.right * Axis.x * moveSpeed * Time.deltaTime);
        }
    }
}

