const arr = [[1, 2], [3, 4], [5, 7], [3, 4]];

function hasPair(array, a, b) {
    let pairStatus = false;
    for(let pair of arr) {
        if (pair.includes(a) && pair.includes(b)) {
            pairStatus = true;
        }
    }
    return pairStatus;
}

console.log(hasPair(arr, 1, 4)); // false
console.log(hasPair(arr, 3, 4)); // true