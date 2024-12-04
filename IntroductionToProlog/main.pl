quicksort(nil, nil).
quicksort(const(X, Xs), S):-
    partition(X, Xs, Ls, Hs),
    quicksort(Ls, LLs),
    quicksort()