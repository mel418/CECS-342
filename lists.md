# Basics of Lists
![tail monster](https://s3.amazonaws.com/lyah/listmonster.png)


let lostNumbers = [4,8,15,16,23,42]<br>
ghci> lostNumbers<br>
[4,8,15,16,23,42]<br>

Strings as Lists<br>
ghci> [1,2,3,4] ++ [9,10,11,12]<br>
[1,2,3,4,9,10,11,12]
ghci> "hello" ++ " " ++ "world"
"hello world"

Cons Operator  
Using : Adds an element to the beginning of a list.  
ghci> 'A':" SMALL CAT"
"A SMALL CAT"
ghci> 5: [1,2,3,4,5]
[5,1,2,3,4,5]

Indexing  
ghci> "Steve Buscemi" !! 6
'B'
ghci> [9.4,33.2,96.2,11.2,23.25] !! 1
33.2

Nested Lists
Lists of Lists: Lists can contain other lists  
ghci> let b = [[1,2,3,4], [5,3,3,3], [1,2,2,3,4],[1,2,3]]
ghci> b    
[[1,2,3,4],[5,3,3,3],[1,2,2,3,4],[1,2,3]]
ghci> b++ [[1,1,1,1]]
[[1,2,3,4],[5,3,3,3],[1,2,2,3,4],[1,2,3],[1,1,1,1]]

Comparing Lists
Lexicographical Order: Lists are compared element by element  
ghci> [3,2,1] > [2,1,0]
True
ghci> [3,4,2] == [3,4,2]
True

Basic List Functions

head: Returns the first element  
ghci> head [5,4,3,2,1]
5

tail: Returns all elements except the first  
ghci> tail [5,4,3,2,1]
[4,3,2,1]

last: Returns the last element   
ghci> last [5,4,3,2,1]
1

init: Returns all elements except the last.  
ghci> init  [5,4,3,2,1]
[5,4,3,2]

length: Returns the number of elements.  
ghci> length [5,4,3,2,1]
5

null: Checks if a list is empty.  
ghci> null [1,2,3]
False -if non-empty list
ghci> null []
True -if empty list

reverse: Reverses a list.  
ghci> reverse [5,4,3,2,1]
[1,2,3,4,5]

take: Takes the first n elements.  
ghci> take 3 [5,4,3,2,1]
[5,4,3]

drop: Drops the first n elements.  
ghci> drop 3 [8,4,2,1,5,6]
[1,5,6]

maximum: Returns the largest element.  
ghci> maximum [1,9,2,3,4]
9

minimum: Returns the smallest element.  
ghci> minimum [8,4,2,1,5,6]
1

sum: Returns the sum of elements.  
ghci> sum [5,2,1,6,3,2,5,7]
31

product: Returns the product of elements.  
ghci> product [6,2,1,2]
24

elem: Checks if an element is in the list.  
 4 `elem` [3,4,5,6]
True


# Texas Ranges in Haskell
**Creating Ranges**  
Basic Ranges: Use [start..end] to create a list of numbers or characters in a sequence.<br>
ghci> [1..20]
[1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20]  
ghci> ['a'..'z']
"abcdefghijklmnopqrstuvwxyz"  
ghci> ['K'..'Z']
"KLMNOPQRSTUVWXYZ"  

**Specifying Steps**  
Step Ranges: Specify a step by providing the first two elements  
ghci> [2,4..20]
[2,4,6,8,10,12,14,16,18,20]  
ghci> [3,6..20]
[3,6,9,12,15,18]  

**Descending Ranges**  
Reverse Ranges: Use a descending sequence to create a list in reverse order  
ghci> [20,19..1]
[20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1]  

**Floating Point Numbers**  
Caution: Using floating point numbers in ranges can lead to precision issues  
ghci> [0.1,0.3..1]
[0.1,0.3,0.5,0.7,0.8999999999999999,1.0999999999999999]  

**Infinite Lists**  
Creating Infinite Lists: Omit the upper limit to create an infinite list  
ghci> take 24 [13,26..]
[13,26,39,52,65,78,91,104,117,130,143,156,169,182,195,208,221,234,247,260,273,286,299,312]  

**Functions for Infinite Lists**  
**cycle**: Repeats a list infinitely  
take 10 (cycle [1,2,3])
[1,2,3,1,2,3,1,2,3,1]  
ghci> take 12 (cycle "LOL ")
"LOL LOL LOL " --12 characters  

**repeat**: Repeats a single element infinitely  
```
ghci> take 10 (repeat 5)  
[5,5,5,5,5,5,5,5,5,5]
```

**replicate**: Creates a list with a specified number of the same element  
```
ghci> replicate  3 10 -- length 3 element 10  
[10,10,10] 
```

# I'm a list comprehension
**Introduction to List Comprehensions**  
**Definition**: List comprehensions are a way to create lists based on existing lists, similar to set comprehensions in mathematics.  
Basic Example: Generating the first 10 even numbers.
```
ghci> [x*2 | x <- [1..10]]
[2,4,6,8,10,12,14,16,18,20]
```

**Adding Conditions (Predicates)**  
**Filtering with Predicates:** Add conditions to filter elements.  
```
ghci> [x*2 | x<- [1..10], x*2 >=12]
[12,14,16,18,20]

The input list [1..10] generates the elements: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
For each element x, check if x*2 >= 12
Apply the output function x*2
```