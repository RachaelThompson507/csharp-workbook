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
        public List<ToDo> listToDo () {
            List<ToDo> _listToDo = new List<ToDo> ();
            foreach (ToDo something in context.toDos) {
                _listToDo.Add (something);
            }
            return _listToDo;
        }
      //  list complete
        public List<ToDo> completeToDo() {
            List<ToDo> _completeToDo = new List<ToDo> ();
            foreach (ToDo complete in context.toDos) {
                if (complete.status == _Status.complete ) {
                    _completeToDo.Add (complete);
                }
            }
            return _completeToDo;
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
        public void updateTask (string findId, string updatedTask, List<ToDo> _listToDo) {
            string find = findId;
            ToDo _updateTask = findById (find);
            _updateTask.task = updatedTask;
            context.SaveChanges ();
            //update List object from addList
            _listToDo.Clear();
            listToDo();

        }
        //update a priority on a single Todo
        public void updatePriority (string findId, _Priority updatedPriority, List<ToDo> _listToDo) {
            string find = findId;
            ToDo _updatePriority = findById (find);
            _updatePriority.priority = updatedPriority;
            context.SaveChanges ();
            //update List object from addList
            _listToDo.Clear();
            listToDo();
        }
        //update a status on a single Todo
        public void updateStatus (string findId, _Status updatedStatus, List<ToDo> _listToDo) {
            string find = findId;
            ToDo _updateStatus = findById (find);
            _updateStatus.status = updatedStatus;
            context.SaveChanges ();
            //update List object from addList
            _listToDo.Clear();
            listToDo();
        }
        //Remove/Delete a ToDo objects
        public void deleteToDo (string findId, List<ToDo> _listToDo) {
            string find = findId;
            ToDo _deleteToDo = findById(find);
            context.toDos.Remove(_deleteToDo);
            context.SaveChanges();
            //update List object from addList
            _listToDo.Clear();
            listToDo();
        }
    }
}