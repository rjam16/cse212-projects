using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: check if exception is thrown if the queue is empty
    // Expected Result: "The queue is empty."
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should be thrown.");
        }
        catch (InvalidOperationException)
        {
            priorityQueue.Equals("The queue is empty.");
        }
        catch (AssertFailedException)
        {
            throw;
        }
    }

    [TestMethod]
    // Scenario: check if when presented two items with the highest priority, it will choose the item closest to the front of the queue
    // Expected Result: 
    // Defect(s) Found: I don't know why, but I'm unable to get rid of the semicolon error. I've tried many things, but doesn't work
    //I tried deleting everything and the error remains
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");

    // Add more test cases as needed below.
    }
}