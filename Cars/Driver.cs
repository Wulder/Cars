//водитель, здесь реализуется управление автомобилем

//можно было бы использовать интерфейсы для вождения машины, но тогда интерфейс вождения автомобиля можно будет подключить к лошади и передать водителю, что не очень логично, хотя для этого существует паттерн адаптер
//так что используем методы базового класса автомобиля, потому что в любом случае все машины будут реализовывать методы необходимые для управления автомобилем

namespace Cars
{
    internal class Driver
    {
        private Car currentCar; //инкапсулированное поле, текущая машина водителя
        public Car CurrentCar { get { return currentCar; } private set { } }
        public Driver(Car c) //создаем водителя и передаем машину, в которой он будет сидеть
        {
            currentCar = c;
        }
        

        public void SeatOnCar(Car c)
        {
            currentCar = c;
        }

        #region Drive
        public void PushGas() //нажать педаль газа
        {
            currentCar.Gas();
        }
        public void PushStop() //нажать педаль тормоза 
        {
            currentCar.Stop();
        }
        public void TurnCar(float deg) //повернуть руль
        {
            currentCar.Turn(deg);
        }
        #endregion
    }
}
