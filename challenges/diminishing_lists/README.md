# Diminishing Lists

The challenge here is to create a method that takes in a list of strings and an integer. The list continuously counts out the int and removes the string at that position in the list and continues to count from that position until only one final string remains. 

## Approach and Efficiency

* Time: O(n)
* Space: O(1)

Time: The method needs to traverse the entire list at least once.

Space: This method does not need to create a new list.

## Solution

The idea here is that there are two while loops within the method. One of them keeps going until there is only one string left in the list. The other one activates when the pointer (which keeps track of which item in the list is getting removed) is higher than the number of items in the list. This keeps the pointer within the range of existing strings in the list, and keeps selecting a string to remove until there is only one left.