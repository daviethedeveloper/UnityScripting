using UnityEngine;

namespace Classes
{
    public class Enemy : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var enemy1 = new CharacterClass("David", 20);

            var enemy2 = new CharacterClass();
         
            
            Debug.Log($"Name: {enemy1.name} | Experience: {enemy1.exp}");
        }
        
    }
}
