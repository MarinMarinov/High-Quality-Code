using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern9.Visitor
{
    class Program
    {
        static void Main()
        {
            AbstractLector professor = new Professor { Name = "Ivan Ivanov", Income = 25000, VacationDays = 45, WorkFromHomeDays = 30 };
            AbstractLector teacher = new Teacher { Name = "Petar Petrov", Income = 15000, VacationDays = 30, WorkFromHomeDays = 15 };
            AbstractLector trainer = new Trainer { Name = "Georgi Georgiev", Income = 10000, VacationDays = 22 };

            LectorsList lectors = new LectorsList();
            lectors.Attach(professor);
            lectors.Attach(teacher);
            lectors.Attach(trainer);

            lectors.Accept(new IncomeVisitor());

            professor.Accept(new HomeWorkVisitor());

            lectors.Detach(trainer);
            lectors.Accept(new IncomeVisitor());
        }
    }
}
