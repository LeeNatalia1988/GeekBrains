namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryProvider factoryProvider = new FactoryProvider();
            DealerProvider dealerProvider = new DealerProvider(factoryProvider);
            /*ComponentInfo componentInfo = dealerProvider.GetComponent(900003);
            //if (componentInfo != null)
            {
                Console.WriteLine(componentInfo.ToString());
            }*/
            while(true)
            {
                Console.WriteLine("Укажите номер детали: #");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number);
                if (number < 0)
                {
                    Console.WriteLine("Укажите корректный номер детали. Номер детали должен быть больше 0.");
                    continue;
                }
                try 
                {
                    ComponentInfo componentInfo = dealerProvider.GetComponent(number);
                    Console.WriteLine(componentInfo.ToString());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
