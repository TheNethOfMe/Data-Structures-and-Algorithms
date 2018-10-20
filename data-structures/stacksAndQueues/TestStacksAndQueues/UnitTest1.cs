using System;
using Xunit;
using stacks_and_queues;
using stacks_and_queues.Classes;

namespace TestStacksAndQueues
{
    public class UnitTest1
    {
        // STACK TESTS
        [Fact]
        // Tests that we can peek at the node at the top of the stack
        public void ShouldPeekAtNodeOnTopOfStack()
        {
            Stack testStack = new Stack(new Node(17));
            Assert.Equal(17, testStack.Peek().Value);
        }
        [Fact]
        // Tests that an existing stack should allow a node to be pushed to it
        public void ShouldPushNodeToTopOfStack()
        {
            Stack testStack = new Stack(new Node(17));
            testStack.Push(new Node(18));
            Assert.Equal(18, testStack.Peek().Value);
        }
        [Fact]
        // Tests that a node can be popped off the stack
        public void ShouldPopNodeOffOfStack()
        {
            Stack testStack = new Stack(new Node(17));
            testStack.Push(new Node(18));
            Node popOff = testStack.Pop();
            Assert.Equal(17, testStack.Peek().Value);
            Assert.Equal(18, popOff.Value);
        }
        // QUEUE TESTS
        [Fact]
        // Tests that you can peek at the node in front of the queue
        public void ShouldPeekAtNodeAtFrontOfQueue()
        {
            Queue testQueue = new Queue(new Node(17));
            testQueue.Enqueue(new Node(18));
            Assert.Equal(17, testQueue.Peek().Value);
        }
        [Fact]
        // Tests that you can enqueue a node to the queue
        public void ShouldEnqueueNodeToRearOfStack()
        {
            Queue testQueue = new Queue(new Node(17));
            testQueue.Enqueue(new Node(18));
            Assert.Equal(18, testQueue.Rear.Value);
        }
        [Fact]
        // Tests that you can dequeue node from front of queue
        public void ShouldDequeueNodeFromFrontOfStack()
        {
            Queue testQueue = new Queue(new Node(17));
            testQueue.Enqueue(new Node(18));
            Node deQedNode = testQueue.Dequeue();
            Assert.Equal(17, deQedNode.Value);
            Assert.Equal(18, testQueue.Peek().Value);
        }
    }
}
