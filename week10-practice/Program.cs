using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ef
{
     public class Student {
        public int Id {get;set;}
        public String Name {get;set;}
        public bool passing {get;set;}

        public Student(int Id, String Name){
            this.Id = Id;
            this.Name = Name;
        }

        public Student(String name){
            this.Name = name;
            this.passing = false;
        }

        override
        public String ToString(){
            return Id+": "+Name+" is "+(passing? " passing" : "failing");
        }


    
    }

    class Program
    {
        static void Main(string[] args)
        {

            DAO theDao = new DAO();
            List<Student> theList = theDao.list();
            ConsoleUtils.print(theList);


            Console.Write("Student to add: ");
            String name = Console.ReadLine();
            theDao.add(name);


            Console.Write("Student id to mark as passing: ");
            String id = Console.ReadLine();
            Student studentToPass = theDao.GetStudent(id);
            studentToPass.passing = true;
            theDao.context.SaveChanges();


            List<Student> theUpdatedList = theDao.list();
            ConsoleUtils.print(theUpdatedList);





        }
    }


    public class DAO {

        public Context context;
        public DAO(){
            context = new Context();
            context.Database.EnsureCreated();
        }

        public List<Student> list(){
            List<Student> theResult = new List<Student>();
            foreach(Student aStudent in context.myStudents){
                theResult.Add(aStudent);
            }  
            return theResult;
        }

        public void add(String name){
            // your code here.
            context.myStudents.Add(new Student(name));
            context.SaveChanges();
        }

        public Student GetStudent(String lookingFor){
            foreach(Student aStudent in context.myStudents){
                if(aStudent.Id.ToString() == lookingFor ){
                    return aStudent;
                }
            }  
            return null;
            
        }
    }

    public class Context : DbContext {
        public DbSet<Student> myStudents {get;set;}
        
        override 
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Filename=./students.db");
        }

    }


}
