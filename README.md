# F# Mutable Variable Bug

This repository demonstrates an uncommon bug related to mutable variables and function return values in F#.

The `bug.fs` file contains code that showcases the unexpected behavior. The `bugSolution.fs` file provides a corrected version.

## Bug Description

When modifying mutable variables within a function and returning modified values, the behavior may differ from what is expected if the original variables are not correctly handled.

## How to Reproduce

1. Clone this repository.
2. Compile and run `bug.fs`.
3. Observe the unexpected output.
4. Compile and run `bugSolution.fs`.
5. Observe the corrected output.

## Solution

The solution involves careful handling of mutable variables when returning values from a function to ensure that changes are correctly reflected or if copies are intended.