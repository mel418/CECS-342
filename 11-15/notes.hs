import Prelude hiding (foldr, foldl, (++))

-- Right fold evaluation example
foldr _ z []     = z
foldr f z (x:xs) = x `f` foldr f z xs

-- Example:
--   foldr (+) 0 [1, 2, 3]
--   = 1 + foldr (+) 0 [2, 3]
--   = 1 + (2 + foldr (+) 0 [3])
--   = 1 + (2 + (3 + foldr (+) 0 []))
--   = 1 + (2 + (3 + 0))
--   = 1 + (2 + 3)
--   = 1 + 5
--   = 6


-- Left fold evaluation example
foldl _ z []     = z
foldl f z (x:xs) = foldl f (z `f` x) xs

-- Example:
--   foldl (+) 0 [1, 2, 3]
--   = foldl (+) (0 + 1) [2, 3]
--   = foldl (+) ((0 + 1) + 2) [3]
--   = foldl (+) (((0 + 1) + 2) + 3) []
--   = (((0 + 1) + 2) + 3)
--   = ((1 + 2) + 3)
--   = (3 + 3)
--   = 6


-- Definition:
--   a `seq` b
--   Evaluates `a` to WHNF (Weak Head Normal Form) and returns the value of `b`.


-- Strict left fold (avoids excessive stack usage by forcing evaluation at each step)
foldl' _ z []     = z
foldl' f z (x:xs) = z' `seq` foldl' f z' xs
                    where z' = z `f` x

-- Example:
--   foldl' (+) 0 [1, 2, 3]
--   = foldl' (+) 1 [2, 3]
--   = foldl' (+) 3 [3]
--   = foldl' (+) 6 []
--   = 6


-- List concatenation function (++)
(++) [] ys     = ys
(++) (x:xs) ys = x : (xs ++ ys)


-- Head function
head (x:xs) = x


-- Right fold example with list concatenation

--   head (foldr (++) [] [[], [1], [2, 3]])
--   = head ([] ++ foldr (++) [] [[1], [2, 3]])
--   = head (foldr (++) [] [[1], [2, 3]])
--   = head ([1] ++ foldr (++) [] [[2, 3]])
--   = head (1 : ([] ++ foldr (++) [] [[2, 3]]))
--   = 1
