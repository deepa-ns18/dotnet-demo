using Xunit;

public class TaskManagerTests
{
    [Fact]
    public void GetPendingTaskCount_ReturnsCorrectCount()
    {
        var taskManager = new TaskManager();

        var pending = taskManager.GetPendingTaskCount();

        Assert.Equal(2, pending);
    }

    [Fact]
    public void GetCompletedTaskCount_ReturnsCorrectCount()
    {
        var taskManager = new TaskManager();

        var completed = taskManager.GetCompletedTaskCount();

        Assert.Equal(1, completed);
    }

    [Fact]
    public void GetNextTask_ReturnsFirstPendingTask()
    {
        var taskManager = new TaskManager();

        var next = taskManager.GetNextTask();

        Assert.Equal("Review pull request", next);
    }
}
