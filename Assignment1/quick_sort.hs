quickSort :: Ord a => [a] -> [a]
quickSort [] = []
quickSort (x:xs) = quickSort [y | y <- xs, y <= x] ++ [x] ++ quickSort [y | y <- xs, y > x]

main :: IO ()
main = do
    let a = [10, 7, 8, 9, 1, 5]
    print $ quickSort a
