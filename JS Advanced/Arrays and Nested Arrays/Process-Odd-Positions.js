function processOddPositions(input) {
    let oddPositions = [];
    for (let index = 0; index < input.length; index++) {
        if (index % 2 === 1) {
            oddPositions.push(input[index]);
        }       
    }
    let reverseOddPositions = oddPositions.reverse();
    let doubleReverseOddPositions = reverseOddPositions.map( num => num * 2);
    let doublereverseNumberInOddPositionFromArray = '';
    for (let index = 0; index < doubleReverseOddPositions.length; index++) {
        doublereverseNumberInOddPositionFromArray += `${doubleReverseOddPositions[index]} `;
    }
    return doublereverseNumberInOddPositionFromArray;
}
console.log(processOddPositions([10, 15, 20, 25]));
