-- Basic Function: Functions are defined with the function name followed by parameters and an equals sign (=), then the function body
doubleMe x= x + x

-- Combining Functions: You can define functions that call other functions
doubleUs x y = doubleMe x + doubleMe y

-- Using if Statements: Haskell’s if statements require an else part and always return a value
doubleSmallNumber x = if x > 100 then x else x * 2

-- Apostrophes in Names: Apostrophes (') can be used in function names to denote a variation of a function
doubleSmallNumber' x = (if x > 100 then x else x *2) + 1

-- Constants: Functions without parameters can be used as constants.
conanO'Brien = "It's a-me, Conan O'Brien!"