namespace structtt
{
     enum ClientType { lvl1, lvl2, lvl3 }
    struct Client
    {
        public string fio;
        public string adress;
        public int phone;
        public int amountOrders;
        public int completedOrders;
        public int summOrders;
        public ClientType clientType;
        public Client(string f, string a, int p, int ao, int co, int so, ClientType cl)  {
            this.fio = f;
            this.adress = a;
            this.phone = p;
            this.amountOrders = ao;
            this.completedOrders = co;
            this.summOrders = so;
            this.clientType = cl;
        }
        public void Print()
        {
            Console.WriteLine("Fio: " + fio);
            Console.WriteLine("Adress: " + adress);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Amount of Orders: " + amountOrders);
            Console.WriteLine("Completed orders: " + completedOrders);
            Console.WriteLine("Summ of orders: " + summOrders);
            Console.WriteLine("Importance: " + clientType);
        }
    }



    struct Method
    {
        public void Summa(int x, int y)
        {
            int result;
            int range = y - x + 1;

            result = range * (x + y) / 2;
            Console.WriteLine("Result: " + result);
        }
    }





    class Plane
    {
        private string name;
        private string namec;
        private int age;
        private string type;
        public Plane(string name, string namec, int age, string type)
        {
            this.name = name;
            this.namec = namec;
            this.age = age;
            this.type = type;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetNamec(string namec)
        {
            this.namec = namec;
        }
        public string GetNamec()
        {
            return namec;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetType(string type)
        {
            this.type = type;
        }
        public string GetType()
        {
            return type;
        }
        public void Input()
        {
            Console.WriteLine("Name of the plane: ");
            name = Console.ReadLine();
            Console.WriteLine("Name of a creator of the plane: ");
            namec = Console.ReadLine();
            Console.WriteLine("Year release of the plane: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type of the plane: ");
            type = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Name of a creator of the plane: " + namec);
            Console.WriteLine("Year release: " + age);
            Console.WriteLine("Type of the plane: " + type);
        }
    }


    class Magazine
    {
         string name;
         int year;
        string description;
         int phone;
        string email;
        public Magazine(string n, int y, string d, int p, string e)
        {
            this.name = n;
            this.year = y;  
            this.description = d;
            this.phone = p;
            this.email = e;
        }

        public string PropertyName
        {
            get { return name; }
            set {  name = value; }
        }
        public int PropertyYear
        {
            get { return year; }
            set { year = value; }
        }
        public string PropertyDescription
        {
            get { return description; }
            set { description = value; }
        }
        public int PropertyPhone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string PropertyEmail
        {
            get { return email; }
            set { email = value; }
        }
        public void Inpt()
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Description: ");
            description = Console.ReadLine();
            Console.WriteLine("Phone: ");
            phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email: ");
            email = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Year " + year);
            Console.WriteLine("Description " +  description);
            Console.WriteLine("Phone " +  phone);
            Console.WriteLine("Email " + email);
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            Client client = new Client("Ivanov, Nikita, Andreev", "Street 24", 324342423, 25, 19, 15000, ClientType.lvl2);
            client.Print();
            //N2
            Method method;
            method.Summa(2, 9);
            //N3
            Plane plane = new Plane("Wix-20006-Wayke", "Waste", 2009, "Alpha");
            plane.Input();
            plane.Output();
            //N4
            Magazine magazine = new Magazine("Gaming", 2023, "About PC gaming", 34324234, "game@.com");
            magazine.Inpt();
            magazine.Show();

            


        }
    }
}
