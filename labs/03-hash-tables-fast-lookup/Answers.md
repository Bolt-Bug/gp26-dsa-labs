### Task 1:
> 1. the item will be in the wrong index
> 2. you would have to set a key on every new entrie
> 3. storing the entries

### Task 2:
> | Bukets | Keys |
> | --- | --- |
> | 0 | 205 |
> | 1 | 101, 206 |
> | 2 |  |
> | 3 |  |
> | 4 | 734, 999 |


### Task 4:
> 1. key 6 turns into key 0 by doing ``key = key % bucketCount``
> 2. it will cost more to search through the bucket.
> 3. ``O(1)`` shows how expensive it is to search for one item, not how many CPU operation it takes