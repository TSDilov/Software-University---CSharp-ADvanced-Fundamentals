function smallestTwoNumbers(input) {
    let smallestNumber = input[0];
    let smallestNumberIndex;
    for (let index = 1; index < input.length; index++) {
        if (input[index] < smallestNumber) {
            smallestNumber = input[index];
            smallestNumberIndex = index;
        }
    }
    input.splice(smallestNumberIndex, 1);
    let secondSmallestNumber = input[0];
    let secondSmallestNUmberIndex;
    for (let index = 0; index < input.length; index++) {
        if (input[index] < secondSmallestNumber) {
            secondSmallestNumber = input[index];
            secondSmallestNUmberIndex = index;
        }
    }
    input.splice(secondSmallestNUmberIndex, 1);
    let twoSmallestNumbers = `${smallestNumber} ${secondSmallestNumber}`;
    console.log(twoSmallestNumbers);
}
smallestTwoNumbers([30, 15, 50, 5]);
