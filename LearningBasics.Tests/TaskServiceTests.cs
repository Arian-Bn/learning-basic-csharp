namespace LearningBasics.Tests;

public class TaskServiceTests
{
    [Fact]
    public void AddTask_ValidData_ReturnTrueAndAddTask()
    {
        var service = new TaskService();
        bool result = service.AddTask(1, "Learn xUnit");
        Assert.True(result);
    }

    [Fact]
    public void AddTask_DuplicateId_ReturnFalse()
    {
        var service = new TaskService();
        service.AddTask(1, "First task");

        bool result = service.AddTask(1, "Second task");
        Assert.False(result);
    }

    [Fact]
    public void AddTask_EmptyTitle_ThrowsArgumentException()
    {
        var service = new TaskService();
        Assert.Throws<ArgumentException>(() => service.AddTask(1, ""));
    }
}
