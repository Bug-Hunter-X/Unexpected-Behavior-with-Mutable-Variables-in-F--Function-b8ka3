# F# Mutable Variable Swap Bug

This repository demonstrates a common pitfall when working with mutable variables in F# functions.  The code attempts to swap two mutable variables using a helper function, but produces unexpected results. The issue stems from a misunderstanding of how mutable variables are passed to functions and how the scope of changes made to these variables affects their values outside of the function.

## Problem

The original `swap` function doesn't correctly swap the values of `x` and `y` as intended.  It only modifies copies of the values passed to the function.

## Solution

The solution provides a correct implementation using tuples to pass values by reference, avoiding the unexpected behavior by working directly with the memory addresses associated with mutable variables. Alternatively, a more functional approach without mutable variables is presented.