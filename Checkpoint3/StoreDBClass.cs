using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ToDoApp {
        /* This is the data access object that will store and retrieve data from the data warehouse
        memory or otherwise
        also could be interface
    */
    class StoreDB {
        public Context context;
        //public ToDo createToDo;
        public StoreDB () {
            context = new Context ();
            context.Database.EnsureCreated ();
        }
        //Add a ToDo object set ID
        public void addNew (string task, _Priority priority, _Status status, DateTime createdDate) {
            context.toDos.Add (new ToDo (task, priority, status, createdDate));
            context.SaveChanges ();
        }
        public List<ToDo> addList () {
            List<ToDo> addList = new List<ToDo> ();
            foreach (ToDo something in context.toDos) {
                addList.Add (something);
            }
            return addList;
        }

        //Update a ToDo object by getting one first
        public ToDo findById (string findId) {
            foreach (ToDo _id in context.toDos) {
                if (_id.id.ToString () == findId) {
                    return _id;
                }
            }
            return null;
        }

        //update a task on a single Todo
        public void updateTask (string findId, string updatedTask) {
            string find = findId;
            ToDo _updateTask = findById (find);
            _updateTask.task = updatedTask;
            context.SaveChanges ();
            //update List object from addList

        }
        //update a priority on a single Todo
        public void updatePriority (string findId, _Priority updatedPriority) {
            string find = findId;
            ToDo _updatePriority = findById (find);
            _updatePriority.priority = updatedPriority;
            context.SaveChanges ();
            //update List object from addList
        }
        //update a status on a single Todo
        public void updateStatus (string findId, _Status updatedStatus) {
            string find = findId;
            ToDo _updateStatus = findById (find);
            _updateStatus.status = updatedStatus;
            context.SaveChanges ();
            //update List object from addList
        }
        //List ToDo objects

        //Remove a ToDo objects

        //

    }
}