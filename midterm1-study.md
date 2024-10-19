# 1. What is the main reduction rule of the semantic of the λ-calculus?  
```
Answer: β-Reduction

β-Reduction (Beta Reduction)
Definition: β-reduction is the process of applying a function to an argument. It involves substituting the argument for the bound variable in the body of the function.
```

# 2. A list [1,2,3] in Haskell is syntactic sugar for…
```
Answer: 1 : 2 : 3 : [] which is equivalent to 1 : (2 : (3 : []))

Using : (cons operator) Adds an element to the beginning of a list.  
Start with the empty list: []
Prepend 3 to the empty list: 3 : []
Prepend 2 to the result: 2 : (3 : [])
Prepend 1 to the result: 1 : (2 : (3 : []))
```

# 3. Which kind of recursion is an important concept in functional programming?
```
Answer: tail recursion

Definition: A function is tail recursive if the recursive call is the last operation in the function. This means that the function returns the result of the recursive call directly, without any further computation.

-- Factorial with accumulating parameter
factorial n = fact_acc n 1
  where
    fact_acc 0 f = f
    fact_acc n f = fact_acc (n-1) (n * f)

- fact_acc is the tail-recursive helper function
- The recursive call fact_acc (n-1) (n*f) is the last operation in the function
```

# 4. What does it mean that Haskell is a pure functional programming language?
```
Answer: the evaluation of expressions has no side-effects

This means that calling a function with the same arguments will always produce the same result without altering any state or interacting with the outside world (like modifying a global variable or printing to the console).
```

# 5. What language feature is not a feature of haskell?
```
Answer: mutable variables

- Mutable variables are variables whose values can be changed after they are initially set.
- Type inference is the ability of the compiler to automatically deduce the types of expressions without explicit type annotations.
```

# 6. Which technique can be used to transform a recursive function into an equivalent tail recursive function?
```
Answer: accumulating parameters

This technique involves adding extra parameters to the function to accumulate the result as the recursion progresses. These parameters carry the intermediate results, allowing the function to return the final result directly when the base case is reached.

factorial n = factAcc n 1
  where
    factAcc 0 acc = acc
    factAcc n acc = factAcc (n - 1) (n * acc)

The tail recursive version uses an accumulator acc to carry the intermediate result. The recursive call factAcc (n - 1) (n * acc) is the last operation, making it tail recursive.
```

# 7. In the haskell function definition
``` 
product [ ] = 1  
product (x:xs) = x * product xs 
```
we used an example of
```
Answer: pattern matching

base case:
product [] = 1
- This line defines the base case for the recursion. When the input list is empty ([]), the product is 1. This is because the product of an empty list is conventionally defined as the multiplicative identity, which is 1

recursive case: 
product (x:xs) = x * product xs
-  It states that the product of a list with at least one element (x:xs) is the first element x multiplied by the product of the rest of the list xs
- Pattern Matching: x:xs is a pattern that matches a list with a head x and a tail xs
```

# 8. Which haskell language feature is used where other languages would use NULL pointers?
```
Answer: algebraic data types, in particular co-products

Co-Products: Also known as sum types, co-products allow a value to be one of several types. This is particularly useful for representing optional values or results that can be one of multiple types.
- Maybe is a co-product type that represents an optional value. It can either be Just a value or Nothing.
data Maybe a = Nothing | Just a

Either is another co-product type that represents a value that can be one of two types. It is often used for error handling
data Either a b = Left a | Right b

Null Value: A null pointer holds a special value (often 0 or nullptr in C++) that indicates it does not point to any valid memory location such as in C, Python, etc.
```

# 9. What makes a recursive function definition tail recursive?
```
Answer: it contains exactly one recursive call and its return value is immediately returned by the calling function
```
```
factorial :: Integer -> Integer
factorial n = factAcc n 1
  where
    factAcc 0 acc = acc
    factAcc n acc = factAcc (n - 1) (n * acc)
```
The recursive call factAcc (n - 1) (n * acc) is the last operation in the function, and its result is immediately returned.
```
How Tail Recursion Works
Let’s break down the tail recursive factorial function step by step:

Initial Call: factorial 5 calls factAcc 5 1.
First Recursive Call: factAcc 5 1 calls factAcc 4 (5 * 1) which is factAcc 4 5.
Second Recursive Call: factAcc 4 5 calls factAcc 3 (4 * 5) which is factAcc 3 20.
Third Recursive Call: factAcc 3 20 calls factAcc 2 (3 * 20) which is factAcc 2 60.
Fourth Recursive Call: factAcc 2 60 calls factAcc 1 (2 * 60) which is factAcc 1 120.
Fifth Recursive Call: factAcc 1 120 calls factAcc 0 (1 * 120) which is factAcc 0 120.
Base Case: factAcc 0 120 returns 120.
```

# 10. Which of the following expressions is not equivalent to the section (^2) ?
```
Answer: \x -> 2^x

The expression \x -> 2^x is a function that takes an argument x and raises 2 to the power of x. This is different from squaring x ^ 2


flip function:
(^) a b  --> a ^ b        (^) 2 --> 2^x
flip (^) a b  --> b ^ a   flip (^) 2 --> x^2
```

# 11. Evaluate the expression
```
a`b`c
  where
    a = "a"
    b = (++)
    c = "c"
```

```
Answer: "ac"

a = "a" (a string with the value "a")
b = (++) (the string concatenation function)
c = "c" (a string with the value "c")

Substitute values of a, b, and c:
"a" `b` "c"

"a" ++ "c" results in the string "ac"
```

# 12. Evaluate the following Haskell fold expression:
```
foldr (+) 0 [1, 2, 3]
```

```
Answer: 6

foldr stands for fold right.
It applies a binary function (in this case, (+)) to a list from the right-hand side towards the left.
It takes three arguments:
A binary function (here +)
An initial accumulator value (here 0)
A list to fold over (here [1, 2, 3])

foldr (+) 0 [1, 2, 3]
= 1 + (2 + (3 + 0))
```

# 13. Evaluate the following Haskell fold expression:
```
foldr (-) 0 [1, 2, 3]
```
```
Answer: 2

= 1-(2-(3-0)) = 2
```

# 14. Evaluate the following Haskell fold expression:
```
foldl (+) 0 [1,2,3]
```
```
Answer: 6

((0+1) + 2) + 3 = 6
```

# 15. Evaluate the following Haskell fold expression:
```
foldl (-) 0 [1, 2, 3]
```
```
Answer: -6

((0 - 1) - 2) - 3 = -6
```
# 16. Evaluate the following Haskell fold expression:
```
foldr (+) 5 [1, 2, 3]
```

```
Answer: 11

1 + (2 + (3 + 5))= 11
```

# 17. Evaluate the following Haskell fold expression:
```
foldl (-) 5 [1, 2, 3]
```

```
Answer:  -1
((5 - 1) - 2) - 3 = -1
```

# 18. What is the type of the following polymorphic Haskell function? 
```
max a b = if a <= b
```

```Answer: max :: Ord a => a -> a -> a```

The operator (<=) is defined for types that are instances of the Ord typeclass, meaning the types must support ordering

Ord a =>: This indicates that a must be a type that is an instance of the Ord typeclass.

Both a and b can be of any type that satisfies the Ord constraint, which includes types like Int, Float, Char, etc.

a -> a -> a: The function takes two arguments of type a and returns a value of the same type a

# 19. What is the type of the following polymorphic Haskell function? 
```
head (x:xs) = x
```
```Answer: head :: [a] -> a```

```[a]```: This indicates that the function takes a list of elements of type a. The brackets denote that it is a list  

```-> a```: This indicates that the function returns a single element of the same type a.  

```(x:xs)```: pattern matching

# 20. What is the type of the following polymorphic Haskell function? 
```
length [] = 0
length (a:as) = 1 + length as
```

```Answer: length :: Num n => [a] -> n```  

The function takes a list of elements of any type ```a```  

It returns a numeric value of some type ```n``` that is an instance of the Num typeclass.

# 21. What is the type of the following polymorphic Haskell function? 
```
  maximum = foldll max
where
  max a b = if a <= b then b else a
and where foldll us the following function from Data.List:
  foldll :: Foldable t => (a-> a -> a) -> t a -> a
```

```Answer: maximum :: (Foldable t, Ord a) => t a -> a```   
This type signature means that maximum can take any foldable structure (like a list, vector, etc.) containing elements of any type that implements the Ord typeclass and will return the maximum element from that structure. 

```
max a b = if a <= b then b else a
max :: Ord a => a -> a -> a
```
This indicates that max takes two arguments of type a, which must be orderable (Ord)  

```
foldll :: Foldable t => (a -> a -> a) -> t a -> a
```  
Here, ```t a``` represents a foldable structure (like lists or other data structures), and it will ultimately return a value of type a

# 22. Consider the Haskell function definition 
```
const x _ = x

Evaluate
  const  (1+) 10 100
```

```Answer: 101```  

```
const x _ = x
```
```x```: This is the first argument to const, which is returned by the function.  
```_```: This is the second argument. The underscore (```_```) is a wildcard that means "ignore this value."
According to the definition, ```const (1+) 10``` will return ```(1+)```, completely disregarding 10.

```
(1+) 100 = 101
```

# 23. Consider the Haskell function definition 
```
const x _ = x
What is the type of const?
```

```Answer: const :: a -> b -> a```  

```a```: Represents the type of the first argument (which is returned).  
```b```: Represents the type of the second argument (which is ignored). 

The function takes an argument of type ```a``` and an argument of type ```b``` and returns a value of type ```a```

# 24. Consider the Haskell function definition 
```
const x _ = x

Evaluate the Haskell expression
foldr (const (1+)) 0 [2, 31, 1]
```

```Answer: 3```

```
foldr (const (1+)) 0 [2, 31, 1]
= const (1+) 2 (const (1+) 31 (const (1+) 1 0))
= const (1+) 2 (const (1+) 31 (+1))
= const (1+) 2 (2)
= 3
```

# 25. Consider the Haskell function definition (wrong?)
```
const x _ = x 

Evaluate the Haskell expression
foldl (const (1+)) 0 [2, 3, 1]
```
```Answer: 2```

```
(const (1+) 0 2) -> (1+)
const (1+) (1+) 3 -> (1+)
```

# 26. Consider the haskell function definition 
```
(++) []     ys = ys
(++) (x:xs) ys = x : (xs++ys)

Evaluate the Haskell expression   “c” ++ “++”
```
```Answer: "c++"```

# 27. Consider the haskell function definition
```
(++) []     ys = ys
(++) (x:xs) ys = x : (xs++ys)

What is the type of (++)?
```

```Answer: (++) :: [a] -> [a] -> [a] ```

# 28. Consider the haskell function definition 
```
(++) []     ys = ys
(++) (x:xs) ys = x : (xs++ys)

What does the function foldr (++) [] do?
```

```Answer: flatten a list of lists```

```
foldr (++) [] [[1, 2], [3, 4], [5]]

Start with the rightmost list [5] and use [] as the initial accumulator:
[5] ++ []

Next, move left to the list [3, 4]:
[3, 4] ++ [5]

Finally, apply the leftmost list [1, 2]:
[1, 2] ++ [3, 4, 5]

This results in [1, 2, 3, 4, 5].
```

# 29. Consider the Haskell function 
```
flip f a b = f b a 
Evaluate flip (-) 1 2
```

```Answer: 1```

```
(-) 2 1 => 2-1
```

# 30. Consider the Haskell function 
```
flip f a b = f b a 
What is the type of flip?
```

```Answer: flip :: (a -> b -> c) -> (b -> a -> c)```

# 31. Consider the Haskell function 
```
flip f a b = f b a

Evaluate the expression
foldl (flip(:)) [] "drawer"
```

```Answer: "reward"```

```
flip(:) function
[] accumulator

flip (:) [] 'd' = 'd' : [] = ['d']
acc = ['d']
flip (:) ['d'] 'r' = 'r' : ['d'] = ['r', 'd']
acc = ['r', 'd']
...
```

# 32. Consider the Haskell data type and function definitions: 
```
data (a,b) = (a,b) 

fst (a, _) = a
snd (_, b) = b

which kind of algebraic data type is (a, b)?
```

```Answer: a product ```

```
The type (a, b) is a product type in Haskell, specifically a pair (or 2-tuple), which groups together two values of potentially different types.
```

# 33. Consider the Haskell data type and function definitions: 
```
data (a,b) = (a,b) 

fst (a, _) = a
snd (_, b) = b

What kind of functions are fst and snd?
```

```Answer: projections ```

```
Projection functions are functions that extract one component from a composite data structure, such as a tuple.
```


#  34. Consider the Haskell data type and function definitions: 
```
data (a,b) = (a,b) 

fst (a, _) = a
snd (_, b) = b

Evaluate the Expression
let f p = fst p -snd p in f(1,3)
```

```Answer: -2```

```
f (1,3) = fst(1,3) - snd(1,3) 
= 1 - 3
= -2
```

# 35. Consider the following Haskel function defintions:
```
foldr_z [] = z
foldr f z (x:xs) = f x (foldr f z xs)

foldl_z [] = z
foldl f z (x:xs) = foldl f (f z x) xs

Which of these functions are tail recursive?
```

```Answer: foldl but not foldr```

# 36. Consider the following Haskel function defintions:
```
foldr_z [] = z
foldr f z (x:xs) = f x (foldr f z xs)

foldl_z [] = z
foldl f z (x:xs) = foldl f (f z x) xs

What is the type of foldr?
```

```Answer: foldr :: (a -> b -> b) -> b -> [a] -> b```

# 37. Consider the following Haskel function defintions:
```
foldr_z [] = z
foldr f z (x:xs) = f x (foldr f z xs)

foldl_z [] = z
foldl f z (x:xs) = foldl f (f z x) xs

What is the type of foldl?
```
```Answer: foldl :: (b -> a -> b) -> b -> [a] -> b```

# 38. Consider the following Haskell data type definition: 
```
data Maybe a = Nothing | Just a

What can Maybe be used for?
```

```Answer: optional values```
