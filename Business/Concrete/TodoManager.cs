﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class TodoManager : ITodoService
    {
        private ITodoDataAccess _todoDataAccess;

        public TodoManager(ITodoDataAccess todoDataAccess)
        {
            _todoDataAccess = todoDataAccess;
        }

        public Todo Add(Todo todo) => _todoDataAccess.Add(todo);

        public Todo Delete(string todoId) => _todoDataAccess.Delete(todoId);

        public Todo Get(string todoId) => _todoDataAccess.Get(todoId);

        public IList<Todo> GetList(Expression<Func<Todo, bool>> filter = null) => _todoDataAccess.GetList(filter);

        public Todo Update(Todo entity) => _todoDataAccess.Update(entity);
    }
}
