import sorting

def shellsort(items, l, r):
     # get first (max) h Value
     h = 1
     while (h < (r-l)/9):
        h = 3*h+1
     # now we have initial h from the 1, 4, 13, 40... sequence
     # reducing h by 3 while it's > 0 let's h-sort our data
     while h > 0:
        i = l + h
        while i <= r:
            # h-sort using insertion sort
            j = i
            v = items[i]
            while j >= l+h and v < items[j-h]:
                items[j] = items[j-h]
                j -= h
            items[j] = v 
            i += 1
        h /= 3     
        
items = list(sorting.getData(15))
sorted = shellsort(items, 0, len(items)-1)

