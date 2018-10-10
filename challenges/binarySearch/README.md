# Array Binary Search

## Challenge

Given an array of sorted integers and an individual integer, return the index in the array in which the integer matches the individual integer that was passed. If the integer isn't in the array, return -1 instead.

## Approach and Efficiency

* Time: O(log n)
* Space: O(1)

Time: Because we're splitting the array each time, we don't have to check every index in the array until correct integer is found (or isn't found). 

Space: We only need to create three variables regardless of the length of the array being put into the array.

## Solution

![alt text](../../assets/array_binary_search.jpg "Shift Array Solution")
