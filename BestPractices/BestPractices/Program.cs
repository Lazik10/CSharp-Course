// When is program correct?
// 1) It works
// 2) Follows best practices
// 3) Is tested properly

//  - Variables naming - name them after what they contains, don't use diacritic
//                     - don't use shortcuts
//                     - CamelCase or snake_case

//  - Colections names should be plural!

// Evaluation of bool
// if (age > 18) is enough, we don't need to evaluate it with bool itself THIS IS WRONG! ---> if (age > 18 == true)
// if we have bool variables we can use just if (oldEnough) or if (!oldEnough)

// Pointless last if else condition
// if (a > b)
// else if (a < b)
// else if (a == b) - this is redundant, else is enought, since numbers in this case can be only equal

// Loops
// avoid using of while(true), for(;;)
// use of break and continue in complex expressions
// change of main loop variable in loop

// DRY - Don't repeat yourself
// - Nowhere in the program should exist the same or at least similar sequence of code lines more than once!

// Refactoring - changing of code to make it more simple and avoiding code duplicates 