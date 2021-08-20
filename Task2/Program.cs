using System;

namespace Task2
{
        struct MyStruct
        {
            public int trainNumber;
            public string destination;
            public DateTime departureTime;

            public MyStruct(int numb, string dest, DateTime dep)
            {
                this.trainNumber = numb;
                this.destination = dest;
                this.departureTime = dep;
            }

        }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter information about 8 trains:");
            MyStruct[] myTrains = new MyStruct[3];
            for (int i =0; i< myTrains.Length; i++)
            {
                myTrains[i] = SetTrainInfo(i);
                Console.Clear();
            }

            SortTrainsByNumber(myTrains);

            Console.WriteLine("Sorted trains: ");
            PrintTrainsArray(myTrains);

            PrintTrainByNumber(myTrains);

            Console.ReadLine();
        }

        public static void PrintTrainByNumber(MyStruct[] myTrains)
        {
            Console.WriteLine("Choose train number which u want to print: ");
            int searchingOption = int.Parse(Console.ReadLine());
            for (int i = 0; i < myTrains.Length; i++)
            {
                if (searchingOption == myTrains[i].trainNumber)
                {
                    Console.WriteLine($"\nTrain number: {myTrains[i].trainNumber}");
                    Console.WriteLine($"Train destination: {myTrains[i].destination}");
                    Console.WriteLine($"Departure time : {myTrains[i].departureTime}");
                }
            }
        }
        public static void PrintTrainsArray(MyStruct[] myTrains)
        {
            for (int i = 0; i < myTrains.Length; i++)
            {
                Console.WriteLine($"\nTrain number: {myTrains[i].trainNumber}");
                Console.WriteLine($"Train destination: {myTrains[i].destination}");
                Console.WriteLine($"Departure time : {myTrains[i].departureTime}");
                Console.WriteLine(new string('=', 20));
                //Console.Clear();
            }
        }
        public static void SortTrainsByNumber(MyStruct[] trains)
        {
            MyStruct temp;
            for (int i = 0; i < trains.Length - 1; i++)
                for (int j = i + 1; j < trains.Length; j++)
                    if (trains[i].trainNumber < trains[j].trainNumber)
                    {
                        temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
        }
        public static MyStruct SetTrainInfo(int index)
        {
            int trainNumber;
            string destination;
            DateTime departureTime;
            Console.WriteLine($"Enter info for train number {index+1}");

            Console.Write("Train number:");
            trainNumber = int.Parse(Console.ReadLine());

            Console.Write("Destination:");
            destination = Console.ReadLine();

            Console.Write("Departure time:");
            departureTime = DateTime.Parse(Console.ReadLine());

            MyStruct newTrain = new MyStruct(trainNumber,destination,departureTime);

            return newTrain;
        }
    }
}
