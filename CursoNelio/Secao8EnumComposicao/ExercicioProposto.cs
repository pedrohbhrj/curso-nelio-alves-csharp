using System.Globalization;

namespace CursoNelio.Secao8EnumComposicao;

public class ExercicioProposto
{
    
    class Worker()
    {
        public string Name { get; set; }
        
        private WorkerLevel Level { get; set; }
        
        private double BaseSalary { get; set; }
        public Department Department { get; set; }

        private List<HourContract> ListHourContract;
        
        
        public Worker(string name, WorkerLevel level, double baseSalary,Department department) : this()
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = baseSalary;
            Department = department;
            ListHourContract = new List<HourContract>();
        }

        public void AddContract(HourContract hourContract)
        {
            ListHourContract.Add(hourContract);
        }
        
        public void RemoveContract(HourContract hourContract)
        {
            ListHourContract.Remove(hourContract);
        }

        public double Income(int month,int year)
        {

            double totalIncome = BaseSalary;
            
            foreach (var contract in ListHourContract)
            {
                int yearOfContract = contract.date.Year;
                int monthOfContract = contract.date.Month;

                bool isYearAndMonth = year == yearOfContract && monthOfContract == month;
                
                if (isYearAndMonth)
                {
                    totalIncome += contract.TotalValue();
                }
            }
            
            return totalIncome;
        }
        
    }

    class Department
    {
        public string name { get; set; }

        public Department(string name)
        {
            this.name = name;
        }
    }

    class HourContract
    {
        public DateTime date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.date = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }


        public double TotalValue()
        {
            return valuePerHour * hours;
        }
        
    }

    enum WorkerLevel
    {
        Junior = 0,
        MidLevel = 1,
        Senior = 2
    }


    public static void Executar()
    {
        Console.Write("Digite um nome de departamento: ");
        string nomeDepartamento = Console.ReadLine();
       
        Console.WriteLine("Digite os dados de um trabalhador: ");
        
        Console.Write("Name: ");
        string nomeWorker = Console.ReadLine();
        Console.Write("Level (Junior/MidLevel/Senior): ");
        string levelWorker = Console.ReadLine();
        Console.Write("Salario base: ");
        double baseSalary = double.Parse(Console.ReadLine());

        Department department = new Department(nomeDepartamento);
        
        Worker worker = new Worker(nomeWorker,Enum.Parse<WorkerLevel>(levelWorker),baseSalary,department);
        
        Console.Write("Quantos contratos para esse trabalhador? ");
        int quantidadeContrato = int.Parse(Console.ReadLine());
        

        int counter = 1;
                
        while (quantidadeContrato > 0)
        {
            Console.Write($"Entre com o #{counter} contrato de dados:");
            Console.WriteLine();
            
            Console.Write("Data (DD/MM/YYYY): ");
            string date = Console.ReadLine();
            
            Console.Write("Valor por hora: ");
            double valuePerHour = double.Parse(Console.ReadLine());
            
            Console.Write("Duracao (hours): ");
            int hours = int.Parse(Console.ReadLine());
            
            HourContract hourContract = new HourContract(DateTime.Parse(date),valuePerHour, hours);
            
            worker.AddContract(hourContract);
            
            quantidadeContrato--;
            counter++;
        }
        
        Console.Write("Digite um mes e um ano para calcular o income (MM/YYYY): ");
        string input = Console.ReadLine();

        string[] yearAndMonth = input.Split("/");

        int month = int.Parse(yearAndMonth[0]);
        int year = int.Parse(yearAndMonth[1]);

        double income = worker.Income(month, year);
        
        Console.WriteLine($"Nome: {worker.Name}");
        Console.WriteLine($"Departamento: {worker.Department.name}");
        Console.WriteLine($"Salario pro dia {input}: {income}");
    


    }
}