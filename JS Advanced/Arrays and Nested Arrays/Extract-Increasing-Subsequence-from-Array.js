function extractSequanceOfBiggestNumbers(arrayOfNumbers) {
    let currentBiggestNumber = arrayOfNumbers[0];
    let extractSequance = [currentBiggestNumber];
    arrayOfNumbers.reduce((a, b) => {
        if (b >= extractSequance[extractSequance.length - 1]) {
            extractSequance.push(b);
        }
    })
    return extractSequance;
}
console.log(extractSequanceOfBiggestNumbers([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]
    ));