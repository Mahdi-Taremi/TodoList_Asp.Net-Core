using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.UnitTest
{
    /// <summary>
    /// Summary description for AddTaskUnitTest
    /// </summary>
    [TestClass]
    public class AddTaskUnitTest
    {
        public AddTaskUnitTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void TestMethodAddTask()
        {
            // Arrange
            var task = new TodoList();
            var item = new Todo();
            task.AddTodo(item);

            // Act 
            task.Complete(item);

            // Assert
            task.Equal(0, task.Count);
            //task.Equal(0, task.Items.Count());

        }
    }
}
