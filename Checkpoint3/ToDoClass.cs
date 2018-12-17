using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ToDoApp {
        /* POCO - creates the ToDo object based on needs.
       ie- Task, ID, status, created date, completed date, deleted date
       These could act as the the model for the database.
     */
    public class ToDo {
        /* COOKIE CUTTER - This is the model for the To-Do item. */
        //ID
        public int id { get; set; }
        //Task
        public string task { get; set; }
        //Priority
        public _Priority priority { get; set; }
        //Status
        public _Status status { get; set; }
        //Created Date
        public DateTime createdDate { get; set; }
        //Closed Date
        //public DateTime closedDate;
        //Deleted Date
        //public DateTime deletedDate;
        // ToDo Constructor
        public ToDo (int id, string task, _Priority priority, _Status status, DateTime createdDate) {
            this.id = id;
            this.task = task;
            this.priority = priority;
            this.status = status;
            this.createdDate = createdDate;
            //test instantiation
            //Console.WriteLine ("I can be made.");
            //Console.WriteLine ($"Test:\n{id}\n{priority}\n{status}\n{task}\n{createdDate}");
        }
        public ToDo (string task, _Priority priority, _Status status, DateTime createdDate) {
            this.task = task;
            this.priority = priority;
            this.status = status;
            this.createdDate = createdDate;
        }
        //
        public override string ToString () {
            return
            id + " " + task + " |Priority: " + priority + " |Status: " + status + " |Created on: " + createdDate.ToString("g");
        }
    }
}