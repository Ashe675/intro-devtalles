/*
=============
🏆 Ejercicio 
=============
*/

// 1. Crear una clase base "Employee" con las siguientes propiedades protegidas:
//    - Name (string)
//    - Salary (double)
//    - Position (string)
//
// 2. Implementar un constructor en "Employee" que inicialice sus valores.
//
// 3. Agregar un método virtual "CalculateBonus()" que retorne un bono del 5% del salario.
//
// 4. Agregar un método "ShowInfo()" que muestre los detalles del empleado:
//    - Nombre
//    - Cargo
//    - Salario
//    - Bono calculado
//
// 5. Crear dos clases derivadas de "Employee":
//    - "TeamLeader": Su bono es del 10% del salario.
//    - "Developer": Su bono es del 7% del salario.
//
// 6. Instanciar una lista de empleados con al menos los siguientes datos:
//    - Carlos (Team Leader, 5000)
//    - Ana (Developer, 4000)
//    - Laura (Team Leader, 6000)
//    - Luis (Developer, 3500)
//
// 7. Recorrer la lista de empleados y mostrar la información de cada uno con el método "ShowInfo()".


partial class Program
{

    static void HomeWork6()
    {
        List<Employee> employees = new()
        {
            new TeamLeader("Carlos", 5000),
            new Developer("Ana", 4000),
            new TeamLeader("Laura", 6000),
            new Developer("Luis", 3500)
        };

        foreach (Employee e in employees)
        {
            e.ShowInfo();
        }
    }

    class Employee
    {
        private string? Name { get; set; }
        protected double Salary { get; set; }
        private string? Position { get; set; }

        public Employee(string name, double salary, string position)
        {
            Name = name;
            Salary = salary;
            Position = position;
        }

        public virtual double CalculateBonus()
        {
            return Salary * 0.05;
        }

        public void ShowInfo()
        {
            WriteLine($"Nombre: {Name}, Cargo: {Position}, Salario: {Salary}, Bono: {CalculateBonus():C}");
        }
    }

    class TeamLeader : Employee
    {
        public TeamLeader(string name, double salary) : base(name, salary, "Team Leader") { }

        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }

    }

    class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary, "Developer") { }

        public override double CalculateBonus()
        {
            return Salary * 0.07;
        }
    }
}