using System;


namespace Cars
{
    abstract class Car : IDamagable
    {

        float strength;
        public float Strength { get { return strength; } private set { } }

        public float maxStrength { get; private set; }
        
        public void AddStrength(float count)
        {
            if(count > 0)
            {
                strength += count;
                strength = Math.Clamp(strength, 0, maxStrength);

            }
            
        }

        //любой автомобиль подрузамевает возможность ехать, но каждый автомобиль может делать это по-своему
        #region Drive 
        public virtual void Gas() //дать газу
        {
            
        }

        public virtual void Stop() //притормозить
        {

        }

        public virtual void Turn(float degrees) //повернуть колеса на n-градусов
        {

        }

        #endregion

        public virtual void GetDamage(float count)
        {
            strength -= count;
            if (strength <= 0)
                Destroy();
        }//получение повреждения

        public virtual void Destroy() //уничтожение автомобиля
        {
            Console.WriteLine("Машина больше не может ездить...");
        }

    }
}
