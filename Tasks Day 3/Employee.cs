namespace Tasks_Day_3
{
    class Employee
    {
        private int _id;
        private string _name;
        private int _age;
        private decimal _salary;


        public int GetID()
        {
            return _id;
        }

        public void SetID(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public decimal GetSalary()
        {
            return _salary;
        }

        public void SetSalary(decimal salary)
        {
            _salary = salary;
        }


        public string Print()
        {
            return $" => {_id} : {_name} : {_age} : {_salary}";
        }
    }
}
