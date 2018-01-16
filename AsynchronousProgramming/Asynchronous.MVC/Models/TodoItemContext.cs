using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Asynchronous.MVC.Models
{
    // 可以将自定义代码添加到此文件中。将不覆盖更改。
    // 
    // 如果你希望每当更改模型架构时，Entity Framework 就会
    // 自动删除并重新生成数据库，请将以下
    // 代码添加到 Global.asax 文件中的 Application_Start 方法。
    // 注意: 这将在每次更改模型时销毁并重新创建数据库。
    // 
    // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Asynchronous.MVC.Models.TodoItemContext>());
    public class TodoItemContext : DbContext
    {
        public TodoItemContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
    }
}