# FIFO Animal Shelter

## Challenge

This challenge involves a queue which takes in nodes of two different types, dogs and cats. The challenge is to create a dequeue method that can take in a parameter of a preferred animal type and return the first instance of that type (maintaining the First In First Out structure) while preserving the rest of the queue.

## Classes

This challenge requires different classes.
### Pet
This is the base class for all of the nodes that will go into our queue. Pet is an abstract class.

### Shelter
Shelters are the queues that will store our Pets. 

### Dog and Cat
These two classes are derived from the base Pet class

## Approach

The Peek and Enqueue methods for this challenge can be written as they would be for any queue data structure. I've written a Dequeue method that takes no parameters which acts like a regular Dequeue method would. I've overloaded the Dequeue method which takes a node which will be either a type of Cat or Dog.

The method checks the first node in the queue, if the types match, it simply performs a standard Dequeue.

However, if this is not the case, then all of the nodes in the queue must be cycled through. We do this to ensure that when we exit the method, the queue remains in the same order, except that the first Pet that matches the type passed into the method will be dequeued. 

## Testing

This program features a test suite testing for the following...

1. Tests that the Shelters get instatiated with Pet nodes.
2. Tests that the Enqueue method works as it should
3. Tests that the Dequeue with no params just dequeues the Pet at the Front
4. Tests that the Dequeue with params returns the correct Pet while leaving the rest of the queue unchanged
5. Tests that the first Pet in the queue is dequeued if the preferred Pet type is not in the queue.

## Efficiency

Time: O(n)
Space: O(1)

Because there are a fixed number of variables created for my custom Dequeue method, the space is O(1). However, time is O(n) because the entire queue will need to be iterated on if the first Pet in the queue isn't the preferred type.

## Whiteboard

![alt text](../../assets/fifo_animal_shelter.jpg "Queue with Stacks Whiteboard")