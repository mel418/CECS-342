{-# LANGUAGE NoMonomorphismRestriction #-}

-- CECS 342 "40 Haskell Types"

-- Determine the type of each of the following 40 Haskell expressions.
-- Then use the :t command in ghci (in repl.it) to verify the results.

module Haskell40Types where

import Data.List(sort)

t01 = 0
t02 = (+)
t03 = (==)
t04 = (<=)
t05 = 'a'
t06 = "text"
t07 = [1, 2, 3]
t08 = []
t09 = (:)
t10 = [[], [0]]
t11 = ('a', 2)
t12 = ('a', "bc")
t13 = fst
t14 = flip
t15 = flip (:)
t16 = head
t17 = tail
t18 = (++)
t19 = map
t20 = foldr
t21 = foldl
t22 = foldr (+) 0
t23 = foldr (++) []
t24 = sum
t25 = product
t26 = filter
t27 = max
t28 = maximum
t29 = sort
t30 = ($)
t31 = \f x -> x
t32 = \f x -> f x
t33 = \f x -> f (f x)
t34 = (.)
t35 = curry
t36 = uncurry
t37 = foldl (flip(:)) []
t38 = flip (foldr (:))
t39 = [2*x | x<-[1..10]]
t40 = map (2*) [1..10]