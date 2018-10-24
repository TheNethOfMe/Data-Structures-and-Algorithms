# Multi Bracket Validator

## Challenge

This challenge requires creating a method that will take in a string and evaluate whether or not it uses all of its square brackets "[]", curley braces "{}", and parentheses "()" properly. The strings should have matching opening and closing brackets in the correct order to pass. For example...

"Hello, I am (somewhat) well today" will return true.

"Oh my, I seem to be} missing a bracket" will return false.

## Classes

This challenge uses a Stack class from a previous challenge. The stack is a data structure with a First In First Out structure.

## Approach

The method instantiates and empty stack to record instances of closing brackets which get added to the stack when an opening bracket is found and popped off of the stack when the matching closing bracket is found. If a closing bracket is found that doesn't match the one on top of the stack, or if there isn't anything on the stack when this happens, the method returns false.

While first creating the whiteboard, the original idea was to iterate through all chars in the string. However, we can break out of the stack as soon as anything that would make it false is found, so I also declare a "result" variable at the start of the method that starts as true. Instead of a for loop, I put the string through a while loop that keeps going until we reach the end of the string, or until "result" is made false.

Once the while loop is escaped, we make one more check to see if there is anything left on the stack as it should be empty again once we're out of the while loop. If it's not result it marked false. Either way, we return the result.

## Testing

This program features a test suite testing that string with a proper use of brackets/parens or strings with no brackets/parens at all return true. 

I also test that any instances of strings missing a bracket or paren (either an opening or closing) return false.

Finally, I test that strings with the right amount of brackets/parens but have them in the wrong order also return false.

## Efficiency

Time: O(n)
Space: O(1)

Time is O(n) because the method needs to iterate up to the entire string if the string returns true. As for space, the whiteboard has writen O(n), but that was before I realized that string has a length property, so we don't have to create an array of chars for the string. I think this would make the space O(1) since we only need to create a finite number of variables in the method no matter how long the string.

## Whiteboard

![alt text](../../assets/multi-bracket-validator.jpg "Multi Bracket Validator")