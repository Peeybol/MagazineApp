using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Magazine.Entities;
using Magazine.Persistence;


namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new MagazineDbContext());

            CreateSampleDB(dal);
        }

        private void CreateSampleDB(IDAL dal)
        {
            dal.RemoveAllData();
            Console.WriteLine("Creando los datos y almacenándolos en la BD");
            Console.WriteLine("===========================================");

            Console.WriteLine("\n// CREACIÓN DE UNA REVISTA Y SU EDITOR EN JEFE");
            Magazine.Entities.User chiefEditor = new User("1234", "Pepe", "TheBoss", false, "ninguna", "pgarcia@gmail.com", "theboss", "1234");
            dal.Insert<User>(chiefEditor);
            dal.Commit();

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", chiefEditor);
            chiefEditor.Magazine = m;

            dal.Insert<Magazine.Entities.Magazine>(m);
            dal.Commit();

            Console.WriteLine("Nombre de la revista: " + m.Name);
            Console.WriteLine("  Editor de la revista: " + m.ChiefEditor.Name + " " + m.ChiefEditor.Surname);

            

            // Populate here the rest of the database with data
            Magazine.Entities.User editorOfArea = new Magazine.Entities.User("0001", "Pablo", "Perez", false, "el furbo", "pablito@gmail.com", "theEditor", "contraseña");
            Magazine.Entities.User paperResponsible = new Magazine.Entities.User("0002", "Ivan", "Haro", false, "los coche", "ivanote@gmail.com", "ivanyvienen", "12345ab");
            Magazine.Entities.Area area = new Magazine.Entities.Area("area", editorOfArea, m);
            Magazine.Entities.Issue issue = new Magazine.Entities.Issue(10, m);
            Magazine.Entities.Paper paper = new Magazine.Entities.Paper("Paper1", new DateTime(2022, 10, 27), area, paperResponsible);
            area.EvaluationPending.Add(paper);
            m.Areas.Add(area);
            m.Issues.Add(issue);
            paperResponsible.MainAuthoredPapers.Add(paper);
            paper.EvaluationPendingArea = area;

            dal.Insert<Magazine.Entities.User>(editorOfArea);
            dal.Insert<Magazine.Entities.User>(paperResponsible);
            dal.Insert<Magazine.Entities.Area>(area);
            dal.Insert<Magazine.Entities.Issue>(issue);
            dal.Insert<Magazine.Entities.Paper>(paper);
            dal.Commit();

            //Console.ReadKey();
        }

    }

}
