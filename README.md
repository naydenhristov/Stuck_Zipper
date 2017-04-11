# Stuck_Zipper
Lists Exercise


You will be given two lists of integers on the first and second line of the input respectively (space-separated). We want to zip these two lists together like a zipper, but one or several of the elements in either of the lists are too large to allow that to happen. Being larger, they have more digits than the element with the smallest amount of digits in the two lists. 
Your task is to find any elements which have more digits than the element with the least amount of digits in the list (if such exist) and remove them, then zip the lists together as shown in the example.
After you stack the lists, print the resulting list on the console (one line, space-separated).

Ideal example (no bad elements):
The initial lists:
2 4 4 3 9
4 1 3 2 7
 
Separate the elements to prepare for zipping:
 2 4 4 3 9
4 1 3 2 7
  
Zip the list:
4 2 1 4 3 4 2 3 7 9
 
Stuck zipper example:
The initial lists:
2 12 4 3 9
22 1 3 88 7
 
Remove the elements with more digits than the element with the smallest amount of digits in both of the lists. In this case, we have to remove anything with more than 1 digit.
 
Lists after removal:
2 4 3 9
1 3 7
 
Separate the elements to prepare for zipping:
 2 4 3 9
1 3 7
 
Finally, we zip the list:
1 2 3 4 7 3 9

Constraints
The integers in both of the lists will always be in the range [1…1000000]


Examples:

Input:
2 4 4 3 9
4 1 3 2 7	

Output:
4 2 1 4 3 4 2 3 7 9

Comments:
Nothing to remove – just zip the lists.
Insert list1[0] into list2 at index 1,
list1[1] into list2 at index 3,
list1[2] into list2 at index 5, etc...
--------------------------------------------

Input:
2 12 4 3 9
22 1 3 88 7

Output:
1 2 3 4 7 3 9

Comments:
We find any elements which have more than 1 digits in both lists. We then zip the two lists like so:
Insert list1[0] into list2 at index 1,
list1[1] into list2 at index 3,
list1[2] into list2 at index 5, etc...
--------------------------------------------

Input:
-156 9128 7223 -938 -923
-918 22282 -848 98127

Output:
-918 -156 -848 -938 -923

Comments:
We find any elements which have more than 3 digits and remove them. We then zip the two lists.
--------------------------------------------

Input:
81728 73234 89 9912
2 5379 -5 92348	

Output:
2 -5	

Comments:
Find elements which have more than 1 digit and remove them.
Since we have nothing to zip (first list is empty), we just print what’s left.
