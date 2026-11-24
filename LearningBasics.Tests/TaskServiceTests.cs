namespace LearningBasics.Tests;

public class TaskServiceTests
{
    [Fact]
    public void AddTask_ValidData_ReturnsTrueAndAddsTask()
    {
        var service = new TaskService();

        bool result = service.AddTask(1, "Learn xUnit");

        Assert.True(result);
        TodoTask? task = service.FindById(1);
        Assert.NotNull(task);
        Assert.Equal(1, task.Id);
        Assert.Equal("Learn xUnit", task.Title);
        Assert.False(task.IsCompleted);
    }

    [Fact]
    public void AddTask_DuplicateId_ReturnsFalse()
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

    [Fact]
    public void FindById_ExistingId_ReturnsTask()
    {
        var service = new TaskService();
        service.AddTask(1, "First task");
        service.AddTask(2, "Second task");

        TodoTask? task = service.FindById(2);

        Assert.NotNull(task);
        Assert.Equal(2, task.Id);
        Assert.Equal("Second task", task.Title);
    }

    [Fact]
    public void FindById_NonExistingId_ReturnsNull()
    {
        var service = new TaskService();
        service.AddTask(1, "First task");

        TodoTask? task = service.FindById(999);

        Assert.Null(task);
    }
}
