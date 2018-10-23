using System;
using Xunit;
using queue_in_two_stacks;
using stacks_and_queues.Classes;

namespace TestQueueInStacks
{
    public class UnitTest1
    {
        [Fact]
        // Checks that the node is enqueued into the input stack and that 
        // the output stack instantiates properly (ie, it's top should be null)
        public void ShouldEnqueANodeIntoInputStack()
        {
            Stack iStack = Program.InstantiateEmptyStack();
            Stack oStack = Program.InstantiateEmptyStack();
            Node testNode = new Node("Hello");
            Program.EnqueueWithStacks(iStack, testNode);
            Assert.Equal(testNode, iStack.Top);
            Assert.Null(oStack.Top);
        }

        [Fact]
        // Check that the nodes are removed from the input stack on dequeue and that
        // they are placed in the correct order into the output stack
        // and that the correct node (the first one) gets returned.
        public void ShouldEmptyInputStackOnDequeueFromEmptyOutputStack()
        {
            Stack iStack = Program.InstantiateEmptyStack();
            Stack oStack = Program.InstantiateEmptyStack();
            Node testNode1 = new Node(1);
            Node testNode2 = new Node(2);
            Node testNode3 = new Node(3);
            Program.EnqueueWithStacks(iStack, testNode1);
            Program.EnqueueWithStacks(iStack, testNode2);
            Program.EnqueueWithStacks(iStack, testNode3);
            Node resultNode = Program.DequeueWithStacks(iStack, oStack);
            Assert.Null(iStack.Top);
            Assert.Equal(1, resultNode.Value);
            Assert.Equal(2, oStack.Top.Value);
        }

        [Fact]
        // Check that the enqueue function still places nodes into istack after 
        // a Dequeue has emptied it without disrupting the order of the nodes in the
        // output stack
        public void ShouldEnqueueAfterSucessfulDequeue()
        {
            Stack iStack = Program.InstantiateEmptyStack();
            Stack oStack = Program.InstantiateEmptyStack();
            Node testNode1 = new Node(1);
            Node testNode2 = new Node(2);
            Node testNode3 = new Node(3);
            Node testNode4 = new Node(4);
            Program.EnqueueWithStacks(iStack, testNode1);
            Program.EnqueueWithStacks(iStack, testNode2);
            Program.EnqueueWithStacks(iStack, testNode3);
            Node resultNode = Program.DequeueWithStacks(iStack, oStack);
            Program.EnqueueWithStacks(iStack, testNode4);
            Assert.Equal(4, iStack.Top.Value);
            Assert.Equal(2, oStack.Top.Value);
        }
    }
}
