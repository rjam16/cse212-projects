using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: check if exception is thrown if the queue is empty
    // Expected Result: "The queue is empty."
    // Defect(s) Found: No error so far, passed test
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
    // Expected Result: "Check" , "Redo"
    // Defect(s) Found: loop needed to cover more values, and the items needed to actually be removed from queue
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Guess", 5);
        priorityQueue.Enqueue("Check", 9);
        priorityQueue.Enqueue("Correct", 5);
        priorityQueue.Enqueue("Redo", 9);

        if (priorityQueue.Dequeue() != "Check")
        {Assert.Fail("Actual first result doesn't match Expected result");}
        if (priorityQueue.Dequeue() != "Redo")
        {Assert.Fail("Actual second result doesn't match Expected result");}

        

    // Add more test cases as needed below.
    }
}