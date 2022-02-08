function sortingNumbers(arrayOfNumbers) {
    arrayOfNumbers.sort((a, b) => a - b);
    let sortetArrayFirstMinSecondMax = [];
    while (arrayOfNumbers.length > 0) {
        sortetArrayFirstMinSecondMax.push(arrayOfNumbers.shift());

        sortetArrayFirstMinSecondMax.push(arrayOfNumbers.pop()); 
    }

    return sortetArrayFirstMinSecondMax;
}
console.log(sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));